using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Entities;

namespace Model.SQL
{
    public class UserQuery : EntityQuery<AppUser>
    {
        public void AddUser(AppUser user)
        {
            UpdateTable();

            _table.InsertOnSubmit(user);
            _context.SubmitChanges();
        }

        public void UpdateUser(AppUser user)
        {
            UpdateTable();
        }

        public override AppUser GetEntityById(int id)
        {
            UpdateTable();

            return _table.Where(user => user.AccountId == id).FirstOrDefault();
        }

        public Boolean IsAccountBelonsUser(Int32 id)
        {
            UpdateTable();
            return _table
                .Any(user => user.AccountId == id);
        }
    }
}
