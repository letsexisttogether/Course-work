using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.Registration
{
    public enum RegAccountResult
    {
        Success, 
        Passwords_unmatch,
        Account_already_exists,
        Empty_data
    }
}
