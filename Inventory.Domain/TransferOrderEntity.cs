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
    public class TransferOrderEntity
    {
        public int Id { get; set; }
        /// <summary>
        /// 调出仓库ID，表示从哪个仓库调拨产品。这有助于追踪库存的来源和去向，并确保调拨操作的准确性。通常使用整数来表示，可以根据实际需求进行调整。
        /// </summary>
        public int FromWarehouseId { get; set; }
        /// <summary>
        /// 调入仓库ID，表示调拨产品将被调入哪个仓库。这有助于追踪库存的来源和去向，并确保调拨操作的准确性。通常使用整数来表示，可以根据实际需求进行调整。
        /// </summary>
        public int ToWarehouseId { get; set; }
        public int ProductId { get; set; }
        /// <summary>
        /// 调拨数量，表示从调出仓库调拨到调入仓库的产品数量。这有助于追踪和管理库存的流动，并确保调拨操作的准确性。通常使用整数来表示，可以根据实际需求进行调整。
        /// </summary>
        public int Quantity { get; set; }
        /// <summary>
        /// 调拨状态，表示当前调拨单的状态或阶段。这有助于追踪调拨操作的进展和管理调拨流程。通常使用枚举类型来表示不同的调拨状态选项，如待处理、处理中、已完成等，以提供更清晰的信息。也可以使用具体的状态代码或描述来表示更详细的调拨状态信息。
        /// </summary>
        public ProductOperationStateEnum ProductOperationState { get; set; }
        /// <summary>
        /// 调拨规则，表示在调拨过程中适用的规则或条件。这有助于确保调拨操作符合预定的流程和要求，并提供指导和约束。通常使用枚举类型来表示不同的调拨规则选项，如优先级、限制条件等，以提供更清晰的信息。也可以使用具体的规则描述或代码来表示更详细的调拨规则信息。
        /// </summary>
        public ProductAllocationRulesEnum ProductAllocationRule { get; set; }
        /// <summary>
        /// 调拨时间
        /// </summary>
        public DateTime DateTime { get; set; }
        /// <summary>
        /// 完成时间
        /// </summary>
        public DateTime CompletedTime { get; set; }
    }
}
