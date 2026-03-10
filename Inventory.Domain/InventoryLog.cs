using Inventory.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Domain.Entities
{
    /// <summary>
    /// 日志记录类，用于记录库存变动的详细信息，包括变动前后数量、变动类型、操作人、操作时间等信息，以便后续查询和审计。
    /// </summary>
    public class InventoryLog
    {
        public int LogId { get; set; }
        public int WarehouseId { get; set; }
        public int ProductId { get; set; }
        public int QuantityBefore { get; set; }
        public int QuantityAfter { get; set; }
        public int QuantityChanged { get; set; }
        public ChangeTypeEnum ChangeType { get; set; } // "入库" 或 "出库"
        public string Operator { get; set; } // 操作人
        public DateTime OperatorTime { get; set; } // 操作时间
        public string RelatedDocument { get; set; } // 相关单据编号（如订单号、调拨单号等）
    }
}
