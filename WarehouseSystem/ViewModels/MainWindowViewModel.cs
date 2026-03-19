using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using Inventory.Abstractions;
using Inventory.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices; // 必须加
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WarehouseSystem.Views;

namespace WarehouseSystem.ViewModels
{
    public partial class MainWindowViewModel(IHost _host, UserService _userService) : ObservableObject
    {
        [ObservableProperty]
        private string userName;

        public void Load()
        {
            WeakReferenceMessenger.Default.Register<UserLogInfo>(this, (_, u) => UserName = u.UserName);
        }

        [RelayCommand]
        private void Login()
        {
            // 从容器解析登录窗口
            var loginView = _host.Services.GetRequiredService<LoginView>();
            // 或者直接通过已知的 _serviceProvider（需要能访问到）
            // var loginView = _serviceProvider.GetRequiredService<LoginView>();

            loginView.Show();
        }
        // 注销命令（示例）
        [RelayCommand]
        private async Task LogoutAsync(CancellationToken cancellationToken)
        {
            if (!string.IsNullOrWhiteSpace(UserName))
            {
                await _userService.UserLogoutAsync(UserName, cancellationToken);
                MessageBox.Show("已注销");
            }

            List<int> d = new(){ 1, 2, 3 };
            Span<int> span = CollectionsMarshal.AsSpan(d);
        }
    }
}
