using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatchCatalogue.Core.Entities;
using WatchCatalogue.Core.Interfaces;
using WatchCatalogue.Infrastructure.Data;
using WatchCatalogue.ViewModels;

namespace WatchCatalogue.Infrastructure.Services
{
    public class MovieService : IMovieService
    {
        Context db = new Context();

        public void SaveMovieService (AllViewModel allvm)
        {
            try
            {
                Movie movie = new Movie();
                movie.Name = allvm.MovieName;
                movie.Amount = allvm.Amount;
                movie.Genre = allvm.Genres;
                movie.ChannelID = allvm.ChannelID;
                db.Movies.Add(movie);
                db.SaveChanges();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
