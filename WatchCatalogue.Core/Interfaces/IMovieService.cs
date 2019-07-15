using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatchCatalogue.ViewModels;

namespace WatchCatalogue.Core.Interfaces
{
    public interface IMovieService
    {
        void SaveMovieService(AllViewModel allvm);
    }
}
