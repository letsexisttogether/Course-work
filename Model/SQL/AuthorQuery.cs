using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using Model.Entities;


namespace Model.SQL
{
    public class AuthorQuery : EntityQuery<Author>
    {
        public void AddAuthor(Author author)
        {
            UpdateTable();

            _table.InsertOnSubmit(author);
            _context.SubmitChanges();
        }

        public override Author GetEntityById(int id)
        {
            UpdateTable();

            return _table.Where(atr => atr.AuthorId == id)
                    .FirstOrDefault();
        }

        public Author GetEntityByAccountId(Int32 id)
        {
            UpdateTable();

            return _table.Where(atr => atr.AccountId == id)
                    .FirstOrDefault();
        }

        public void UpdateRank(Int32 authorId, Int32 rankId)
        {
            UpdateTable();

            Author author = GetEntityById(authorId);
            author.AuthorRankId = rankId;
            _context.SubmitChanges();
        }

        public Boolean IsAccountBelonsAuthor(Int32 id)
        {
            UpdateTable();
            return _table
                .Any(atr => atr.AccountId == id);
        }
    }
}
