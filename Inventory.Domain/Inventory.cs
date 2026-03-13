using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Domain.Entities
{
    /// <summary>
    /// 库存实体类，表示仓库中某个产品的库存信息，包括可用数量、锁定数量、安全库存水平等。
    /// </summary>
    public class Inventory
    {
        public int WarehouseID { get; set; }
        public int ProductID { get; set; }
        /// <summary>
        /// 可用数量，表示当前可以用于满足订单或其他需求的库存数量。这部分库存可以被分配给新的订单或其他操作使用。
        /// </summary>
        public int AvailableQuantity { get; set; }
        /// <summary>
        /// 锁定数量，表示已经预留但尚未完成的订单或其他操作所占用的库存数量。这部分库存不能被其他订单使用，直到相关操作完成或取消。
        /// </summary>
        public int LockedQuantity { get; set; }
        /// <summary>
        /// 安全库存水平，表示当可用数量低于该水平时需要触发补货或其他库存管理操作，以确保供应链的稳定性和客户需求的满足。
        /// </summary>
        public int SafetyStockLevel { get; set; }
        /// <summary>
        /// 最后一次检查库存的时间，用于监控库存状态和触发补货等操作。
        /// </summary>
        public DateTime LastCheckedTime { get; set; }
    }
}
