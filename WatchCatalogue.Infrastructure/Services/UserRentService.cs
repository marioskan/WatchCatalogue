using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatchCatalogue.Core.Entities;
using WatchCatalogue.Core.Interfaces;

namespace WatchCatalogue.Infrastructure.Services
{
    public class UserRentService : IUserRentService
    {
        public Task<List<RentInfo>> ReturnMovie()
        {
            throw new NotImplementedException();
        }

        public Task SaveRent(int movieid)
        {
            throw new NotImplementedException();
        }
    }
}
