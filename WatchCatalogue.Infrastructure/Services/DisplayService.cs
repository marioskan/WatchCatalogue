using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatchCatalogue.Core.Entities;
using WatchCatalogue.Core.Interfaces;
using WatchCatalogue.Core.ViewModels;
using WatchCatalogue.Infrastructure.Data;

namespace WatchCatalogue.Infrastructure.Services
{
    public class DisplayService : IDisplayService
    {
        Context db = new Context();
        public async Task<List<SubscriptionService>> DisplayModels()
        {
            var subServices = await db.SubscriptionServices.Include(ss => ss.Channels.Select(c => c.Movies)).ToListAsync();
            return subServices;          
        }

        public async Task<List<RentInfoViewModel>> SearchRentedMovies(string userId)
        {           
            return await db.Rents
                .Include(mr => mr.Movie)
                .Include(mr => mr.Movie.Channel)
                .Include(mr => mr.Movie.Channel.SubscriptionService).
                Where(rent => rent.UserID == userId)
                .Select(rs => new RentInfoViewModel() {
                    ChannelName = rs.Movie.Channel.Name,
                    MovieName = rs.Movie.Name,
                    SubscriptionName = rs.Movie.Channel.SubscriptionService.Name,
                    RentDate = rs.DateRented
                })
                .ToListAsync();

        }
    }
}
