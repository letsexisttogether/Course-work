using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Entities;
using Model.SQL;

namespace Controllers.MainPart
{
    public class AccountController
    {
        public AccountController(Int32 id)
        {
            _account = _queryHandler.GetEntityById(id);
        }
        
        public AddResult AddAccount(String login, String password, String email)
        {
            if (_queryHandler.CheckLoginExistence(login)
                || _queryHandler.CheckEmailExistence(email))
            {
                return AddResult.Entity_already_exists;
            }

            Account nAccount = new Account()
            {
               AccountLogin = login,
               AccountPassword = password,
               AccountEmail = email
            };
            _account = _queryHandler.GetEntityById(
                _queryHandler.AddElement(_account));

            return AddResult.Success;
        }
        public AccountUpdateResult UpdateAccount(String login, String password, String email)
        {
            if (login == String.Empty || password == String.Empty
                || email == String.Empty)
            {
                return AccountUpdateResult.Empty_data;
            }

            Int32 loginId = _queryHandler.FindAccountByLogin(login);
            Int32 emailId = _queryHandler.FindAccountByEmain(email);

            if (loginId != _account.AccountId && loginId != -1)
            {
                return AccountUpdateResult.Login_busy;
            }
            if (emailId != _account.AccountId && emailId != -1)
            {
                return AccountUpdateResult.Email_busy;
            }

            _account.AccountLogin = login;
            _account.AccountPassword = password;
            _account.AccountEmail = email;
            _queryHandler.UpdateAccount(_account);

            return AccountUpdateResult.Success;
        }
        public void DeleteAccount()
        {
            _queryHandler.DeleteAccount(_account.AccountId);
        }

        // Get
        public String GetLogin()
        {
            return _account.AccountLogin;
        }
        public String GetPassword()
        {
            return _account.AccountPassword;
        }
        public String GetEmail()
        {
            return _account.AccountEmail;
        }

        private Account _account;
        private AccountQuery _queryHandler = new AccountQuery();
    }
}
