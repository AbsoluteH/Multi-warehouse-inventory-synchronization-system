using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Domain.Enums;

namespace Inventory.Domain.Entities
{
    /// <summary>
    /// 仓库实体类，表示一个仓库的信息，包括仓库ID、名称、位置、类型、负责人姓名和联系电话等属性。
    /// </summary>
    public class Warehouse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public WarehouseTypeEnum WarehouseType { get; set; }
        public string ManagerName { get; set; }
        public string ManagerTelephone { get; set; }
    }
}
