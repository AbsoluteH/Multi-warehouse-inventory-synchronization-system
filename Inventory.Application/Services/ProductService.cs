using Inventory.Abstractions;
using Inventory.Application.AppEntities;
using Inventory.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IEnumerable<ProductEntity> _products;
        public void Add(ProductEntity productDTO)
        {

        }
        public void Update(ProductEntity productDTO)
        {

        }
        public ProductEntity GetItem()
        {
            ProductEntity productDTO = new ();
            return productDTO;
        }
        public IEnumerable<ProductEntity> GetItems()
        {
            return _products;
        }
    }
}
