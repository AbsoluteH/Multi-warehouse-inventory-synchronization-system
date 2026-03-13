using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Application.AppEntities
{
    public class InventoryDTO
    {
        public int WarehouseID { get; set; }
        public int ProductID { get; set; }
        /// <summary>
        /// 可用数量，表示当前可以用于满足订单或其他需求的库存数量。这部分库存可以被分配给新的订单或其他操作使用。
        /// </summary>
        public int AvailableQuantity { get; set; }
    }
}
