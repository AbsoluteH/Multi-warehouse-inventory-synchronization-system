using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Abstractions
{
    public record UserLogInfo (string UserName); 
    public record CloseLoginWindow (); 
    public record CloseAllWindow (); 

}
