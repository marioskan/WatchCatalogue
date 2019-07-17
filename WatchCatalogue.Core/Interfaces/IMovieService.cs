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
        Task RestockMoviesAsync(int id, int newamount);
        Task<List<Movie>> ReturnMovieListAsync();
    }
}
