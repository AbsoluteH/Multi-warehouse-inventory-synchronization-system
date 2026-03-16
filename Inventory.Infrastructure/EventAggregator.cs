using Inventory.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Infrastructure
{
    public class EventAggregator : IEventAggregator
    {
        private readonly Dictionary<Type, List<WeakReference>> _syncSubscriptions = new();
        private readonly Dictionary<Type, List<WeakReference>> _asyncSubscriptions = new();
        private readonly SynchronizationContext _uiContext;

        public EventAggregator()
        {
            // 捕获 UI 同步上下文（需在 UI 线程创建）
            _uiContext = SynchronizationContext.Current ?? new SynchronizationContext();
        }

        // 同步订阅
        public void Subscribe<TMessage>(Action<TMessage> action) where TMessage : class
        {
            AddSubscription(_syncSubscriptions, action);
        }

        public void Unsubscribe<TMessage>(Action<TMessage> action) where TMessage : class
        {
            RemoveSubscription(_syncSubscriptions, action);
        }

        // 异步订阅
        public void SubscribeAsync<TMessage>(Func<TMessage, Task> asyncAction) where TMessage : class
        {
            AddSubscription(_asyncSubscriptions, asyncAction);
        }

        public void UnsubscribeAsync<TMessage>(Func<TMessage, Task> asyncAction) where TMessage : class
        {
            RemoveSubscription(_asyncSubscriptions, asyncAction);
        }

        // 同步发布（即发即忘）
        public void Publish<TMessage>(TMessage message) where TMessage : class
        {
            // 获取存活的目标
            var syncActions = GetAliveActions<TMessage, Action<TMessage>>(_syncSubscriptions);
            var asyncActions = GetAliveActions<TMessage, Func<TMessage, Task>>(_asyncSubscriptions);

            // 在后台线程执行，避免阻塞发布者
            Task.Run(async () =>
            {
                // 执行同步委托（将其包装为异步）
                foreach (var action in syncActions)
                {
                    try
                    {
                        action(message);
                    }
                    catch (Exception ex)
                    {
                        // 记录异常
                    }
                }

                // 执行异步委托
                foreach (var asyncAction in asyncActions)
                {
                    try
                    {
                        await asyncAction(message).ConfigureAwait(false);
                    }
                    catch (Exception ex)
                    {
                        // 记录异常
                    }
                }
            });
        }

        // 异步发布（等待所有完成）
        public async Task PublishAsync<TMessage>(TMessage message) where TMessage : class
        {
            var syncActions = GetAliveActions<TMessage, Action<TMessage>>(_syncSubscriptions);
            var asyncActions = GetAliveActions<TMessage, Func<TMessage, Task>>(_asyncSubscriptions);

            // 收集所有任务
            var tasks = new List<Task>();

            // 同步委托需要在线程池执行，避免阻塞
            foreach (var action in syncActions)
            {
                tasks.Add(Task.Run(() => action(message)));
            }

            // 添加异步委托的任务
            foreach (var asyncAction in asyncActions)
            {
                tasks.Add(asyncAction(message));
            }

            // 等待所有完成，并处理异常
            await Task.WhenAll(tasks).ConfigureAwait(false);
        }

        // 辅助方法：添加弱引用
        private void AddSubscription<TDelegate>(Dictionary<Type, List<WeakReference>> dict, TDelegate handler)
        {
            lock (dict)
            {
                var type = typeof(TDelegate).GetGenericArguments()[0]; // 获取消息类型
                if (!dict.ContainsKey(type))
                    dict[type] = new List<WeakReference>();
                var weakRefs = dict[type];
                // 避免重复添加相同的委托
                if (!weakRefs.Any(wr => wr.IsAlive && wr.Target?.Equals(handler) == true))
                {
                    weakRefs.Add(new WeakReference(handler));
                }
            }
        }

        private void RemoveSubscription<TDelegate>(Dictionary<Type, List<WeakReference>> dict, TDelegate handler)
        {
            lock (dict)
            {
                var type = typeof(TDelegate).GetGenericArguments()[0];
                if (dict.TryGetValue(type, out var weakRefs))
                {
                    weakRefs.RemoveAll(wr => wr.IsAlive && wr.Target?.Equals(handler) == true);
                }
            }
        }

        private List<TDelegate> GetAliveActions<TMessage, TDelegate>(Dictionary<Type, List<WeakReference>> dict)
        {
            var result = new List<TDelegate>();
            lock (dict)
            {
                var messageType = typeof(TMessage);
                if (dict.TryGetValue(messageType, out var weakRefs))
                {
                    var dead = new List<WeakReference>();
                    foreach (var wr in weakRefs)
                    {
                        if (wr.IsAlive && wr.Target is TDelegate del)
                            result.Add(del);
                        else
                            dead.Add(wr);
                    }
                    foreach (var d in dead)
                        weakRefs.Remove(d);
                }
            }
            return result;
        }
    }
}
