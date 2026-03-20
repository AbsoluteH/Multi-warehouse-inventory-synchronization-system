using Inventory.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Domain.Entities
{
    /// <summary>
    /// 商品实体类，包含商品的基本属性，如ID、名称、重量、体积、尺寸、颜色、类别和价格等。
    /// </summary>
    public class ProductEntity
    {
        public int Id { get; set; }
        /// <summary>
        /// 商品名称，表示商品的名称或描述信息。这有助于识别和区分不同的商品，并提供给用户或系统进行查询和操作。可以是简单的文本描述，也可以包含更多的细节信息。
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 重量，表示商品的重量信息。这有助于计算运输成本、仓储需求和其他与重量相关的操作。通常使用浮点数来表示，可以包含单位（如千克、磅等）以提供更准确的信息。
        /// </summary>
        public float Weight { get; set; }
        /// <summary>
        /// 体积，表示商品的体积信息。这有助于计算运输成本、仓储需求和其他与体积相关的操作。通常使用浮点数来表示，可以包含单位（如立方米、升等）以提供更准确的信息。
        /// </summary>
        public float Volume { get; set; }
        /// <summary>
        /// 尺寸，表示商品的尺寸信息。这有助于计算运输成本、仓储需求和其他与尺寸相关的操作。通常使用枚举类型来表示不同的尺寸选项，如小、中、大等，以提供更清晰的信息。也可以使用具体的数值来表示长度、宽度和高度等维度信息。
        /// </summary>
        public ProductSizeEnum Size { get; set; }
        /// <summary>
        /// 颜色，表示商品的颜色信息。这有助于区分不同颜色的商品，并提供给用户或系统进行查询和操作。通常使用枚举类型来表示不同的颜色选项，如红色、蓝色、绿色等，以提供更清晰的信息。也可以使用具体的颜色代码（如RGB值）来表示更详细的颜色信息。
        /// </summary>
        public ProductColorEnum Color { get; set; }
        /// <summary>
        /// 类别，表示商品所属的类别或分类信息。这有助于组织和管理不同类型的商品，并提供给用户或系统进行查询和操作。通常使用枚举类型来表示不同的类别选项，如电子产品、服装、食品等，以提供更清晰的信息。也可以使用具体的分类代码或名称来表示更详细的类别信息。
        /// </summary>
        public ProductCategoryEnum Category { get; set; }
        /// <summary>
        /// 价格
        /// </summary>
        public decimal Price { get; set; }
    }
}
