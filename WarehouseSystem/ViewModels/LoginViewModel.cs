using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Inventory.Application.Services;
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
    public partial class LoginViewModel(UserService _userService) : ObservableObject
    {
        [ObservableProperty]
        private string userName;
        [ObservableProperty]
        private string password;


        [RelayCommand]
        private async Task LoginAsync(CancellationToken cancellationToken)
        {
            var success = await _userService.UserLoginAsync(UserName, Password, cancellationToken);
            if (success)
            {
                MessageBox.Show("登录成功！");
            }
            else
            {
                MessageBox.Show("用户名或密码错误！");
            }
        }
    }
}
