using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;


namespace Model.Entities
{
    [Table]
    public class Author
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public Int32 AuthorId { get; set; }

        [Column]
        public Int32 AccountId { get ; set; }

        [Column]
        public Int32 AuthorRankId { get; set; } 
    }
}
