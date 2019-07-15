using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatchCatalogue.Core.Entities;
using WatchCatalogue.ViewModels;

namespace WatchCatalogue.Core.Interfaces
{
    public interface IChannelService
    {
        void SaveChannelService(ChannelSubscriptionViewModel channelviewmodel);
        Task<List<Channel>> ReturnChannelServices();
    }
}
