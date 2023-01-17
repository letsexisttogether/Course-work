using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.SQL;
using Model.Entities;

namespace Controllers.Registration
{
    public class UserRegistrationController : AuthorRegistrationController
    {
        public RegAccountResult RegNewUser(String login, String firstPassword, 
            String secondPassword, String email, String name, String surname, 
            DateTime birthDate)
        {
            Tuple<Int32, RegAccountResult> accountResult = 
                    RegNewAccount(login, firstPassword, secondPassword, email);

            if (accountResult.Item1 != -1)
            {
                _userHandler.AddUser(new AppUser()
                {
                    AccountId = accountResult.Item1,
                    UserName = name,
                    UserSurname = surname,
                    UserBirthDate = birthDate
                });
            }

            return accountResult.Item2;
        }

        private UserQuery _userHandler = new UserQuery();

    }
}
