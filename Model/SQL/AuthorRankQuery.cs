using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Entities;

namespace Model.SQL
{
    public class AuthorRankQuery : EntityQuery<AuthorRank>
    {
        public override AuthorRank GetEntityById(int id)
        {
            UpdateTable();

            return _table.Where(rank => rank.AuthorRankId == id)
                .FirstOrDefault();
        }

        public Int32 FindByTitle(String title)
        {
            UpdateTable();

            try
            {
                return _table.Where(rank => rank.AuthorRankTitle == title)
                    .Single().AuthorRankId;
            }
            catch
            {
                return -1;
            }
            
        }
    }
}
