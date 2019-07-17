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
    public class UserRentService : IUserRentService
    {
        Context db = new Context();
        public async Task ReturnMovie(string userId)
        {
            
        }

        public async Task SaveRent(string movieName,string userId)
        {
            
        }
    }
}
