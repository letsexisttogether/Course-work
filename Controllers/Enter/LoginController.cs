using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using Model.SQL;
using View.MainPart.Author;
using View.MainPart.User;

namespace Controllers.Enter
{
    public class LoginController
    {
        public LoginCheckResult AccountCheck(String login, String password)
        {
            if (login.Length == 0)
            {
                return LoginCheckResult.Empty_Login;
            }
            if (password.Length == 0)
            {
                return LoginCheckResult.Empty_Password;
            }


            Boolean existence = _queryHandler.CheckAccountExistence(login, password);

            if (!existence)
            {
                return LoginCheckResult.Wrong_Account;
            }
            
            return LoginCheckResult.Success;
        }

        public Form EnterToAccount(String login)
        {
            Int32 id = _queryHandler.FindAccountByLogin(login);

            if (id == -1)
            {
                id = _queryHandler.FindAccountByEmain(login);
            }

            AuthorQuery authorQuery = new AuthorQuery();
            if (authorQuery.IsAccountBelonsAuthor(id))
            {
                return new AuthorForm(id);
            }
            UserQuery userQuery = new UserQuery();
            if (userQuery.IsAccountBelonsUser(id))
            {
                return new UserForm(id);
            }

            return null;
        }

        private AccountQuery _queryHandler = new AccountQuery();
    }
}
