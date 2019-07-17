using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchCatalogue.Core.Entities
{
    public class RentInfo
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int MovieID { get; set; }
        public DateTime RentDate { get; set; }
    }
}
