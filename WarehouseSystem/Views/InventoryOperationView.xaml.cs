using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WarehouseSystem.ViewModels;

namespace WarehouseSystem.Views
{
    /// <summary>
    /// InventoryOperationView.xaml 的交互逻辑
    /// </summary>
    public partial class InventoryOperationView : UserControl
    {
        public InventoryOperationView(InventoryOperationViewModel model)
        {
            DataContext = model;
            InitializeComponent();
        }
    }
}
