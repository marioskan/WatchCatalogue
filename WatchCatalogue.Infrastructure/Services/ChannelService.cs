using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatchCatalogue.Core.Entities;
using WatchCatalogue.Core.Interfaces;
using WatchCatalogue.Infrastructure.Data;
using WatchCatalogue.ViewModels;

namespace WatchCatalogue.Infrastructure.Services
{
    public class ChannelService : IChannelService
    {
        Context db = new Context();
        public void SaveChannelService(ChannelSubscriptionViewModel channelviewmodel)
        {
            try
            {
                Channel vm = new Channel();
                vm.Name = channelviewmodel.Name;
                vm.SubscriptionServiceID = channelviewmodel.SubscriptionID;
                db.Channels.Add(vm);
                db.SaveChanges();
            }catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public async Task<List<Channel>> ReturnChannelServices()
        {
            var channelServices = await db.Channels.ToListAsync();
            return channelServices;
        }
    }
}
