using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.MainPart
{
    public enum AccountUpdateResult
    {
        Success, 
        Login_busy,
        Email_busy,
        Empty_data
    }
}
