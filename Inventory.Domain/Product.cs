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
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Weight { get; set; }
        public float Volume { get; set; }
        public ProductSizeEnum Size { get; set; }
        public ProductColorEnum Color { get; set; }
        public ProductCategoryEnum Category { get; set; }
        public decimal Price { get; set; }
    }
}
