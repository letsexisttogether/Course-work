using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace Model.Entities
{
    [Table]
    public class UserDesktopImage
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public Int32 UserDesktopImageId { get; set; }   

        [Column]
        public Int32 UserId { get; set; }

        [Column]
        public Int32 DesktopImageId { get; set; }   

        [Column]
        public DateTime AddDate { get; set; }

        [Column(CanBeNull = true)]
        public Int32 Rating { get; set; }

    }
}
