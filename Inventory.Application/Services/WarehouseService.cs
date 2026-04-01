using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Abstractions;
using Inventory.Application.AppEntities;
using Inventory.Domain.Entities;

namespace Inventory.Application.Services
{
    public class WarehouseService : IWarehouseService
    {
        private  readonly List<WarehouseEntity> _warehouses;
        public void Add (WarehouseEntity warehouse)
        {

        }
        public void Update(WarehouseEntity warehouse)
        {

        }
        public WarehouseEntity GetItem()
        {
            WarehouseEntity warehouse = new();
            return warehouse;
        }
        public IEnumerable<WarehouseEntity> GetItems()
        {
            return _warehouses;
        }
    }
}
