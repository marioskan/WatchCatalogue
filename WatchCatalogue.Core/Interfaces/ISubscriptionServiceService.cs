using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatchCatalogue.Core.Entities;

namespace WatchCatalogue.Core.Interfaces
{
    public interface ISubscriptionServiceService
    {
        void SaveSubscriptionService(SubscriptionService subscriptionService);
        Task<List<SubscriptionService>> ReturnSubscriptionServices();
    }
}
