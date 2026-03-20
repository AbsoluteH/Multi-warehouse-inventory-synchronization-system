using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using Inventory.Abstractions;
using Inventory.Application.AppEntities;
using Inventory.Application.Services;
using Inventory.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseSystem.ViewModels
{
    public partial class ProductManagementViewModel(IProductService _productService) : ObservableObject
    {
        private ProductDTO newProductDTO;
        [ObservableProperty]
        private List<ProductDTO> productsDTOs;
        [ObservableProperty]
        private int productID;
        [ObservableProperty]
        private string productName;
        [ObservableProperty]
        private float productWeight;
        [ObservableProperty]
        private float productVolume;
        [ObservableProperty]
        private ObservableCollection<string> productSizes;
        [ObservableProperty]
        private string productSize;
        [ObservableProperty]
        private ObservableCollection<string> productColors;
        [ObservableProperty]
        private string productColor;
        [ObservableProperty]
        private ObservableCollection<string> productCategorys;
        [ObservableProperty]
        private string productCategory;
        [ObservableProperty]
        private decimal productPrice;
        public void Load()
        {
            var list = Enum.GetValues<ProductSizeEnum>().Select(e => EnumTranslateClass.GetEnumDescription(e)).ToList();
            ProductSizes = new ObservableCollection<string>(list);
            list = Enum.GetValues<ProductColorEnum>().Select(e => EnumTranslateClass.GetEnumDescription(e)).ToList();
            ProductColors = new ObservableCollection<string>(list);
            list = Enum.GetValues<ProductCategoryEnum>().Select(e => EnumTranslateClass.GetEnumDescription(e)).ToList();
            ProductCategorys = new ObservableCollection<string>(list);
        }
        [RelayCommand]
        private void AddProduct()
        {

        }
        [RelayCommand]
        private void UpdateProduct()
        {

        }
    }
}
