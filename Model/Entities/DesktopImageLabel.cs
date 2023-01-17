using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace Model.Entities
{
    [Table]
    public  class DesktopImageLabel
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public Int32 DesktopImageMarkId { get; set; }   

        [Column]
        public Int32 DesktopImageId { get; set; }

        [Column]
        public Int32 LabelId { get; set; }
    }
}
