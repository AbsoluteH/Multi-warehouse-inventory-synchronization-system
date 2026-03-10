using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Domain.Enums;

namespace Inventory.Domain.Entities
{
    /// <summary>
    /// 调拨单实体类，表示仓库之间调拨产品的订单信息，包括调出仓库、调入仓库、产品ID、调拨数量、调拨状态、调拨规则、调拨时间和完成时间等属性。
    /// </summary>
    public class TransferOrder
    {
        public int Id { get; set; }
        public int FromWarehouseId { get; set; } // 调出仓库ID
        public int ToWarehouseId { get; set; } // 调入仓库ID
        public int ProductId { get; set; } // 产品ID
        public int Quantity { get; set; } // 调拨数量
        public ProductOperationStateEnum ProductOperationState { get; set; } // 调拨状态（如：待审核、已审核、已完成等）
        public ProductAllocationRulesEnum ProductAllocationRule { get; set; } // 调拨规则（如：先进先出、后进先出等）
        public DateTime DateTime { get; set; } // 调拨时间
        public DateTime CompletedTime { get; set; } // 完成时间（如果已完成）
    }
}
