using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Abstractions
{
    public record UserLogInfoMsg (string UserName); 
    /// <summary>
    /// 关闭登录窗口
    /// </summary>
    public record CloseLoginWindowMsg ();
    /// <summary>
    /// 关闭程序
    /// </summary>
    public record CloseAllWindowMsg (); 
    public record UpdatedProduct();
    public record UpdatedInventory();
    public record UpdatedWarehouse();
}
