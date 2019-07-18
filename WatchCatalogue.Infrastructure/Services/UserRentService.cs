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

        public async Task<Movie> FindMovieByName(string movieName)
        {
            Movie movieobj = await db.Movies.Where(movie => movie.Name == movieName).SingleOrDefaultAsync();
            return movieobj;
        }
        public async Task<Boolean> CheckAmount(Movie movie)
        {
            if(movie.AvailableAmount>0)
            {
                movie.AvailableAmount = movie.AvailableAmount - 1;
                await db.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task ReturnMovie(string userId)
        {
            
        }

        public async Task SaveRent(Movie movie,string userId)
        {
            MovieRent rent = new MovieRent
            {
                MovieID = movie.ID,
                UserID = userId,
                DateRented = DateTime.Now
            };
            db.Rents.Add(rent);
            await db.SaveChangesAsync();
        }

        
    }
}
