using Inventory.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Application.Services
{
    public class UserService(IAuthenticationService _authenticationService)
    {
        public bool UseLogin(string userName, string password)
        {
            return _authenticationService.Authenticate(userName, password);
        }
        /// <summary>
        /// 用户登录方法，接受用户名和密码，并调用认证服务进行验证，返回登录结果（成功或失败）。可以在这里添加更多的登录逻辑，例如记录登录日志、处理多因素认证等。
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<bool> UserLoginAsync(string userName, string password, CancellationToken cancellationToken)
        {
            return await _authenticationService.AuthenticateAsync(userName, password, cancellationToken);
        }
        /// <summary>
        /// 用户注销方法，接受用户名，并调用认证服务进行注销操作，返回注销结果（成功或失败）。可以在这里添加更多的注销逻辑，例如清除用户会话、记录注销日志等。
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<bool> UserLogoutAsync(string userName, CancellationToken cancellationToken)
        {
            return await _authenticationService.LogoutAsync(userName, cancellationToken);
        }
    }
}
