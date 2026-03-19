using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Abstractions;
using Inventory.Application.AppEntities;

namespace Inventory.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly List<ProductDTO> _products;
        public void AddProduct(ProductDTO productDTO)
        {

        }
        public void UpdateProduct(ProductDTO productDTO)
        {

        }
        public ProductDTO GetProductDTO()
        {
            ProductDTO productDTO = new ();
            return productDTO;
        }
        public List<ProductDTO> GetProducts()
        {
            return _products;
        }
    }
}
