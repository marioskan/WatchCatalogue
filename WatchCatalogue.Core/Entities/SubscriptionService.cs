using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchCatalogue.Core.Entities
{
    public class SubscriptionService
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public List<Channel> Channels { get; set; }

        public SubscriptionService()
        {
            Channels = new List<Channel>();
        }
    }
}
