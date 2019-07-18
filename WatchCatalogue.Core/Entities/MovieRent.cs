using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchCatalogue.Core.Entities
{
    public class MovieRent
    {
        public int ID { get; set; }
        public int MovieID { get; set; }
        public string UserID { get; set; }
        public DateTime DateRented { get; set; }
        public Movie Movie { get; set; }
        public double Price { get; set; }
    }
}
