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
        public int AvailableQuantity { get; set; }
        public int LockedQuantity { get; set; }
        public int SafetyStockLevel { get; set; }
        public DateTime LastCheckedTime { get; set; }
    }
}
