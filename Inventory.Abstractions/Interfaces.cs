using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Abstractions
{
    /// <summary>
    /// 数据库
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepositoryService<T> where T : class // 通常约束为聚合根
    {
        Task<T> GetByIdAsync<TId>(TId id, CancellationToken cancellationToken = default);
        Task<IReadOnlyList<T>> ListAllAsync(CancellationToken cancellationToken = default);
        Task<T> AddAsync(T entity, CancellationToken cancellationToken = default);
        void Update(T entity);
        void Delete(T entity);
    }
    /// <summary>
    /// 序列化
    /// </summary>
    public interface ISerializer
    {
        string Serialize<T>(T obj);
        T? Deserialize<T>(string text);
        object? Deserialize(string text, Type type);
    }
    /// <summary>
    /// 日志
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IAppLogger<T>
    {
        void LogInformation(string message, params object[] args);
        void LogWarning(string message, params object[] args);
        void LogError(string message, params object[] args);
        void LogDebug(string message, params object[] args);
    }
    public interface IFileStorageService
    {
        Task SaveFileAsync(string fileText, string filePath, CancellationToken cancellationToken = default);
        Task<string> GetFileAsync(string filePath, CancellationToken cancellationToken = default);
    }
    public interface IInventoryService
    {

    }
    public interface IProductService
    {
    }
    public interface IWarehouseService
    {
    }
    public interface ILogService
    {
    }
    }
