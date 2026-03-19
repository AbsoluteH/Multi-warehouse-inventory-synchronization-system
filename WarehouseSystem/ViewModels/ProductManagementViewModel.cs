using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using Inventory.Abstractions;
using Inventory.Application.AppEntities;
using Inventory.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseSystem.ViewModels
{
    public partial class ProductManagementViewModel(ProductService _productService) : ObservableObject
    {
        [ObservableProperty]
        private ProductDTO newProductDTO;
        [ObservableProperty]
        private List<ProductDTO> productsDTOs;
        public void Load()
        {
            
        }
    }
}
