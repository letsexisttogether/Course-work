using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace Model.Entities
{
    [Table]
    public class Account
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public Int32 AccountId { get; set; }
        
        [Column]
        public String AccountLogin { get; set; }
        
        [Column]
        public String AccountPassword { get; set; }
        
        [Column]
        public String AccountEmail { get; set; }
    }
}
