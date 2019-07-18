using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WatchCatalogue.Core.Interfaces;
using WatchCatalogue.Infrastructure.Services;

namespace WatchCatalogue.Controllers
{
    public class ProfileController : Controller
    {
        // GET: Profile
        public async Task<ActionResult> MyRents()
        {
            string userId = User.Identity.GetUserId();
            IDisplayService ids = new DisplayService();
            var rentedlist = await ids.SearchRentedMovies(userId);
            return View(rentedlist);
        }
    }
}