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
    public class WarehouseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// 仓库位置，表示仓库所在的地理位置或地址信息。这有助于识别和区分不同的仓库，并提供给用户或系统进行查询和操作。可以是具体的地址、城市、国家等信息，以提供更准确的位置信息。
        /// </summary>
        public string Location { get; set; }
        /// <summary>
        /// 表示仓库的类型或分类信息。这有助于组织和管理不同类型的仓库，并提供给用户或系统进行查询和操作。通常使用枚举类型来表示不同的仓库类型选项，如普通仓库、冷藏仓库、危险品仓库等，以提供更清晰的信息。也可以使用具体的分类代码或名称来表示更详细的仓库类型信息。
        /// </summary>
        public WarehouseTypeEnum WarehouseType { get; set; }
        /// <summary>
        /// 管理员姓名，表示负责管理该仓库的人员的姓名信息。这有助于识别和联系仓库管理员，并提供给用户或系统进行查询和操作。可以是具体的姓名，也可以包含更多的细节信息，如职位、部门等，以提供更准确的信息。
        /// </summary>
        public string ManagerName { get; set; }
        /// <summary>
        /// 管理员联系电话，表示负责管理该仓库的人员的联系电话信息。这有助于联系仓库管理员，并提供给用户或系统进行查询和操作。可以是具体的电话号码，也可以包含更多的细节信息，如国家代码、区号等，以提供更准确的信息。
        /// </summary>
        public string ManagerTelephone { get; set; }
    }
}
