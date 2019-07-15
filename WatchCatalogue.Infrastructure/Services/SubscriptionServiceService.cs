using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using WatchCatalogue.Core.Entities;
using WatchCatalogue.Core.Interfaces;
using WatchCatalogue.Infrastructure.Data;


namespace WatchCatalogue.Infrastructure.Services
{
     public class SubscriptionServiceService : ISubscriptionServiceService
    {
        Context db = new Context();

        public void SaveSubscriptionService(SubscriptionService subscriptionService)
        {
            try
            {
                SubscriptionService item = new SubscriptionService();
                item.Name = subscriptionService.Name;
                item.Price = subscriptionService.Price;
                db.SubscriptionServices.Add(item);
                db.SaveChanges();
            }catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }     
        public async Task<List<SubscriptionService>> ReturnSubscriptionServices()
        {
            var subscriptionServices = await db.SubscriptionServices.ToListAsync();
            return subscriptionServices;
        }
    }
}
