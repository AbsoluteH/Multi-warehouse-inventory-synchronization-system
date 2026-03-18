using Inventory.Abstractions;
using Inventory.Application.Services;
using Inventory.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Configuration;
using System.Data;
using System.Windows;
using WarehouseSystem.ViewModels;
using WarehouseSystem.Views;

namespace WarehouseSystem
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly IHost _host;
        public App()
        {
            _host = Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    //注册view
                    services.AddSingleton<MainWindowView>();
                    services.AddSingleton<InventoryOperationView>();
                    services.AddSingleton<LogViewerView>();
                    services.AddSingleton<ProductManagementView>();
                    services.AddSingleton<WarehouseSettingsView>();
                    services.AddSingleton<LoginView>();

                    //注册viewmodel
                    services.AddTransient<MainWindowViewModel>();
                    services.AddTransient<InventoryOperationViewModel>();
                    services.AddTransient<LogViewerViewModel>();
                    services.AddTransient<ProductManagementViewModel>();
                    services.AddTransient<WarehouseSettingsViewModel>();
                    services.AddTransient<LoginViewModel>();
                    // 注册其他服务...
                    services.AddSingleton<IWarehouseService, WarehouseService>();
                    services.AddSingleton<IProductService, ProductService>();
                    services.AddSingleton<ILogService, LogService>();
                    services.AddSingleton<IInventoryService, InventoryService>();
                    services.AddSingleton<IAuthenticationService, AuthenticationService>();

                    services.AddSingleton<EventAggregator>();
                    services.AddSingleton<UserService>();
                })
                .Build();
        }
        protected override async void OnStartup(StartupEventArgs e)
        {
            await _host.StartAsync();
            var mainWindow = _host.Services.GetRequiredService<MainWindowView>();
            mainWindow.DataContext = _host.Services.GetRequiredService<MainWindowViewModel>();
            mainWindow.Show();
            base.OnStartup(e);
        }
        protected override async void OnExit(ExitEventArgs e)
        {
            await _host.StopAsync();
            _host.Dispose();
            base.OnExit(e);
        }
    }

}
