using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.SQL;
using Model.Entities;

namespace Controllers.Registration
{
    public class AuthorRegistrationController : AccountRegistrationController
    {
        public RegAccountResult RegNewAuthor(String login, String firstPassword, String secondPassword, 
            String email)
        {
            Tuple<Int32, RegAccountResult> accountRegResult = 
                RegNewAccount(login, firstPassword, secondPassword, email);

            if (accountRegResult.Item1 != -1)
            {
                _authorQuery.AddAuthor(new Author()
                {
                    AccountId = accountRegResult.Item1,
                    AuthorRankId = 1
                });
            }

            return accountRegResult.Item2;
        }

        private AccountQuery _accounthandler = new AccountQuery();
        private AuthorQuery _authorQuery = new AuthorQuery();
    }
}
