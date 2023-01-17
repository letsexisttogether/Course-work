using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Entities;
using Model.SQL;

namespace Controllers.Registration
{
    public class AccountRegistrationController
    {
        public Tuple<Int32, RegAccountResult> RegNewAccount(String login, String firstPassword,
            String secondPassword, String email)
        {
            if (!firstPassword.Equals(secondPassword))
            {
                return new Tuple<Int32, RegAccountResult>
                    (-1, RegAccountResult.Passwords_unmatch);
            }
            if (login == String.Empty || firstPassword == String.Empty || email == String.Empty)
            {
                return new Tuple<Int32, RegAccountResult>
                    (-1, RegAccountResult.Empty_data);
            }
            if (_accountHandler.CheckLoginExistence(login)
                || _accountHandler.CheckEmailExistence(email))
            {
                return new Tuple<Int32, RegAccountResult>
                    (-1, RegAccountResult.Account_already_exists);
            }

            return new Tuple<Int32, RegAccountResult>(_accountHandler.AddElement(new Account()
            {
                AccountLogin = login,
                AccountPassword = firstPassword,
                AccountEmail = email
            }),
            RegAccountResult.Success);
        }

        private AccountQuery _accountHandler = new AccountQuery();
    }
}
