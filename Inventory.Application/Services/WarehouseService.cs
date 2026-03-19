using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Abstractions;
using Inventory.Application.AppEntities;

namespace Inventory.Application.Services
{
    public class WarehouseService : IWarehouseService
    {
        private  readonly List<WarehouseDTO> _warehouseDTOs;
        public void AddWarehouse (WarehouseDTO warehouseDTO)
        {

        }
        public void UpdateWarehouse(WarehouseDTO warehouseDTO)
        {

        }
        public WarehouseDTO GetWarehouse()
        {
            WarehouseDTO warehouseDTO = new();
            return warehouseDTO;
        }
        public List<WarehouseDTO> GetWarehouseDTOs()
        {
            return _warehouseDTOs;
        }
    }
}
