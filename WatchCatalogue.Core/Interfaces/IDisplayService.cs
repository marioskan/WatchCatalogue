using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatchCatalogue.Core.Entities;
using WatchCatalogue.Core.ViewModels;

namespace WatchCatalogue.Core.Interfaces
{
    public interface IDisplayService
    {
        Task<List<SubscriptionService>> DisplayModels();
    }
}
