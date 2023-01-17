using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;


namespace Model.SQL
{
    public abstract class EntityQuery<T> where T : class
    {
        public void UpdateTable()
        {
            _table = _context.GetTable<T>();
        }

        public abstract T GetEntityById(Int32 id);

        protected DataContext _context = new DataContext(@"Data Source=.\ALEXSQL;
            Initial Catalog=YourWallpaperFriend;Integrated Security=True");
        protected Table<T> _table;
    }
}
