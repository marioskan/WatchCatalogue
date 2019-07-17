using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatchCatalogue.Core.Entities;

namespace WatchCatalogue.Core.Interfaces
{
    public interface IUserRentService
    {
        Task SaveRent(string movieName,string userId);
        Task ReturnMovie(string userId);
    }
}
