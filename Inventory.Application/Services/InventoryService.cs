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
        private readonly List<InventoryDTO> _inventoryDTOs;
        public void AddInventory(InventoryDTO inventoryDTO)
        {

        }
        public void UpdateInventory(InventoryDTO productDTO)
        {

        }
        public InventoryDTO GetInventoryDTO()
        {
            InventoryDTO inventoryDTO = new ();
            return inventoryDTO;
        }
        public List<InventoryDTO> GetProducts()
        {
            return _inventoryDTOs;
        }
    }
}
