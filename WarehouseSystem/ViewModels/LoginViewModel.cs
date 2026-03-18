using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Inventory.Abstractions;
using Inventory.Application.Services;
using Inventory.Infrastructure;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace WarehouseSystem.ViewModels
{
    public partial class LoginViewModel(UserService _userService, EventAggregator _eventAggregator) : ObservableObject
    {
        [ObservableProperty]
        private string userName;
        [ObservableProperty]
        private string password;


        [RelayCommand]
        private void LoginAsync()
        {
            var success = _userService.UseLogin(UserName, Password);
            if (success)
            {
                MessageBox.Show("登录成功！");
                _eventAggregator.Publish(new UserLogInfo(UserName));
                _eventAggregator.Publish(new CloseLoginWindow());
            }
            else
            {
                MessageBox.Show("用户名或密码错误！");
            }
        }
        [RelayCommand]
        private async Task LogoutAsync()
        {
            await _userService.UserLogoutAsync(UserName, new CancellationToken());
        }
        [RelayCommand]
        private void CloseWindow()
        {

            MessageBox.Show("关闭！");
        }
    }
}
