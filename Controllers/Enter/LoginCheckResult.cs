using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.Enter
{
    public enum LoginCheckResult
    {
        Success,
        Empty_Login,
        Empty_Password,
        Wrong_Account
    }
}
