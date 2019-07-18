using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchCatalogue.Core.ViewModels
{
    public class RentInfoViewModel
    {
        public string MovieName { get; set; }
        public DateTime RentDate { get; set; }
        public string ChannelName { get; set; }
        public string SubscriptionName { get; set; }
    }
}
