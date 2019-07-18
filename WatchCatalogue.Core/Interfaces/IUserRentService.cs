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
        Task SaveRent(Movie movie,string userId);
        Task ReturnMovie(string userId);
        Task<Boolean> CheckAmount(Movie movie);
        Task<Movie> FindMovieByName(string movieName);
    }
}
