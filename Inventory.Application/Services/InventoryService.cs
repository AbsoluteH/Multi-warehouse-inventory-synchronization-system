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
    public class InventoryService : IInventoryService
    {
        private readonly List<InventoryEntity> _inventorys;
        public void Add(InventoryEntity inventory)
        {

        }
        public void Update(InventoryEntity product)
        {

        }
        public InventoryEntity GetItem()
        {
            InventoryEntity inventory = new ();
            return inventory;
        }
        public IEnumerable<InventoryEntity> GetItems()
        {
            return _inventorys;
        }
    }
}
