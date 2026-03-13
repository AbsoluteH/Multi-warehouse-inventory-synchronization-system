using Inventory.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Application.AppEntities
{
    public class InventoryLogDTO
    {
        public int LogId { get; set; }
        public int WarehouseId { get; set; }
        public int ProductId { get; set; }
        /// <summary>
        /// 变动前的数量，表示在此次操作之前的库存数量。这有助于追踪库存变动的历史记录和分析库存趋势。
        /// </summary>
        public int QuantityBefore { get; set; }
        /// <summary>
        /// 变动后的数量，表示在此次操作之后的库存数量。这有助于追踪库存变动的历史记录和分析库存趋势。
        /// </summary>
        public int QuantityAfter { get; set; }
        /// <summary>
        /// 变动数量，表示此次操作导致的库存数量的变化。正数表示入库（增加库存），负数表示出库（减少库存）。这有助于快速了解每次操作对库存的影响。
        /// </summary>
        public int QuantityChanged { get; set; }
        public ChangeTypeEnum ChangeType { get; set; } // "入库" 或 "出库"
        /// <summary>
        /// 操作人，表示执行此次库存变动操作的人员或系统。这有助于追踪责任人和分析操作行为。可以是用户名、系统标识或其他相关信息。
        /// </summary>
        public string Operator { get; set; }
        /// <summary>
        /// 操作时间，表示执行此次库存变动操作的具体时间。这有助于追踪库存变动的时间线和分析库存趋势。通常使用日期时间格式来记录。
        /// </summary>
        public DateTime OperatorTime { get; set; }
        /// <summary>
        /// 相关单据，表示与此次库存变动相关的订单、入库单、出库单等信息。这有助于追踪库存变动的来源和目的。可以是订单编号、单据类型等相关信息。
        /// </summary>
        public int RelatedDocument { get; set; }
    }
}
