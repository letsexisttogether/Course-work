using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using Model.Entities;


namespace Model.SQL
{
    public class AccountQuery : EntityQuery<Account>
    {
        // Add
        public Int32 AddElement(Account account)
        {
            UpdateTable();

            _table.InsertOnSubmit(account);
            _context.SubmitChanges();

            return FindAccountByEmain(account.AccountEmail);
        }

        // Change (undone)
        public void UpdateAccount(Account example)
        {
            UpdateTable();

            Account current =
                _table.Where(acc => acc.AccountId == example.AccountId)
                .FirstOrDefault();
            current.AccountLogin = example.AccountLogin;
            current.AccountEmail = example.AccountEmail;
            current.AccountPassword = example.AccountPassword;
            
            _context.SubmitChanges();
        }

        // Delete 
        public void DeleteAccount(Int32 id)
        {

            UpdateTable();
            _table.DeleteOnSubmit(GetEntityById(id));
            _context.SubmitChanges();
        }

        // Existence check
        public Boolean CheckAccountExistence(String login, String password)
        {
            UpdateTable();

            Account account = null;
            try
            {
                account = _table.Where(acc => acc.AccountLogin == login).Single();
            }
            catch
            {
                try
                {
                    account = _table.Where(acc => acc.AccountEmail == login).Single();
                }
                catch
                {
                    return false;
                }
            }

            return account.AccountPassword == password;
        }
        public Boolean CheckLoginExistence(String login)
        {
            return FindAccountByLogin(login) != -1;
        }
        public Boolean CheckEmailExistence(String email)
        {
            return FindAccountByEmain(email) != -1;
        }
          
        // Find methods
        public Int32 FindAccountByLogin(String login)
        {
            UpdateTable();

            Int32 resultId;
            try
            {
                resultId = _table
                   .Where(account => account.AccountLogin == login)
                   .Select(account => account.AccountId).Single();
            }
            catch
            {
                resultId = -1;
            }

            return resultId; 
        }
        public Int32 FindAccountByEmain(String email)
        {
            UpdateTable();

            try
            {
                return _table
                       .Where(account => account.AccountEmail == email)
                       .Select(account => account.AccountId).Single();
            }
            catch
            {
                return -1;
            }
        }

        // Get methods
        public override Account GetEntityById(Int32 id)
        {
            UpdateTable();

            Account account;
            try
            {
                account = _table.Where(acc => acc.AccountId == id).Single();
            }
            catch
            {
                account = null;
            }

            return account;
        }
    }
}
