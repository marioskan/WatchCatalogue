using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatchCatalogue.Core.Entities;
using WatchCatalogue.ViewModels;

namespace WatchCatalogue.Core.Interfaces
{
    public interface IMovieService
    {
        void SaveMovieService(AllViewModel allvm);
        Task RestockMoviesAsync(Movie movie, int amount,int id);
        Task<List<Movie>> ReturnMovieListAsync();
    }
}
