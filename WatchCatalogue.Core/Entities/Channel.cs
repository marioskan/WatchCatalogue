using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchCatalogue.Core.Entities
{
    public class Channel
    {
        public int ID { get; set; }
        public int SubscriptionServiceID { get; set; }
        public string Name { get; set; }
        public string ImgGuid { get; set; }
        public SubscriptionService SubscriptionService { get; set; }
        public List<Movie> Movies { get; set; }

        public Channel()
        {
            Movies = new List<Movie>();
        }
    }
}
