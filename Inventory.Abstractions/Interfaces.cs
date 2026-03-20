using Inventory.Domain.Entities;
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
    /// <summary>
    /// 文件存储服务，提供文件的保存和读取功能，可以用于日志文件、配置文件等的管理
    /// </summary>
    public interface IFileStorageService
    {
        Task SaveFileAsync(string fileText, string filePath, CancellationToken cancellationToken = default);
        Task<string> GetFileAsync(string filePath, CancellationToken cancellationToken = default);
    }
    /// <summary>
    /// 库存服务，提供库存管理相关的功能，如库存查询、库存调整等，可以与数据库交互来实现库存数据的持久化和管理
    /// </summary>
    public interface IInventoryService
    {
        public void Add(InventoryEntity inventory);
        public void Update(InventoryEntity inventory);
        public InventoryEntity GetItem();
        public IEnumerable<InventoryEntity> GetItems();
    }
    /// <summary>
    /// 产品服务，提供产品管理相关的功能，如产品信息查询、产品分类管理等，可以与数据库交互来实现产品数据的持久化和管理
    /// </summary>
    public interface IProductService
    {
        public void Add(ProductEntity product);
        public void Update(ProductEntity product);
        public ProductEntity GetItem();
        public IEnumerable<ProductEntity> GetItems();
    }
    /// <summary>
    /// 仓库服务，提供仓库管理相关的功能，如仓库信息查询、仓库布局管理等，可以与数据库交互来实现仓库数据的持久化和管理
    /// </summary>
    public interface IWarehouseService
    {
        public void Add(WarehouseEntity warehouse);
        public void Update(WarehouseEntity warehouse);
        public WarehouseEntity GetItem();
        public IEnumerable<WarehouseEntity> GetItems();
    }
    /// <summary>
    /// 日志服务，提供日志记录相关的功能，如记录系统操作日志、错误日志等，可以与文件存储服务或数据库交互来实现日志数据的持久化和管理
    /// </summary>
    public interface ILogService
    {
    }
    /// <summary>
    /// 登录服务，提供用户认证相关的功能，如用户登录、用户注销等，可以与数据库交互来实现用户数据的持久化和管理
    /// </summary>
    public interface IAuthenticationService
    {
        bool Authenticate(string userName, string password);
        Task<bool> AuthenticateAsync(string userName, string password, CancellationToken cancellationToken = default);
        Task<bool> LogoutAsync(string userName, CancellationToken cancellationToken = default);
    }
}
