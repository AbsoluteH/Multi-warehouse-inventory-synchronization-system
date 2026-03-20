using Inventory.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Domain
{
    public class UserInfoEntity
    {
        public int Id { get; set; } // 用户ID
        public string Username { get; set; } // 用户名
        public string Password { get; set; } // 密码（实际应用中应加密存储）
        /// <summary>
        /// 用户角色，定义用户在系统中的权限级别，如管理员、经理、员工等
        /// </summary>
        public UserRoleEnum UserRole { get; set; }
    }
}
