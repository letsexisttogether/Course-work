using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace Model.Entities
{
    [Table]
    public class Label
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public Int32 LabelId { get; set; }

        [Column]
        public String LabelTitle { get; set; }
    }
}
