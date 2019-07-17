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
using AutoMapper;

namespace WatchCatalogue.Infrastructure.Services
{
    public class MovieService : IMovieService
    {
        Context db = new Context();

        public async Task RestockMoviesAsync(int movieid, int newamount)
        {
            var Movie = await db.Movies.Where(m => m.ID == movieid).FirstOrDefaultAsync();
            Movie.Amount = Movie.Amount + newamount;
            Movie.AvailableAmount = Movie.AvailableAmount + newamount;
            await db.SaveChangesAsync();
        }

        public async Task<List<Movie>> ReturnMovieListAsync()
        {
            var movies = await db.Movies.ToListAsync();
            return movies;
        }

        public void SaveMovieService (AllViewModel allvm)
        {
            try
            {
                Movie movie = new Movie();
                AutoMapper.Mapper.Map(allvm, movie);
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
