using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WatchCatalogue.Core.Entities;
using WatchCatalogue.Core.Interfaces;
using WatchCatalogue.Core.ViewModels;
using WatchCatalogue.Infrastructure.Services;

namespace WatchCatalogue.Controllers
{
    public class HomeController : Controller
    {
        IDisplayService _display;
        public HomeController()
        {
            _display = new DisplayService();
        }

        public async Task<ActionResult> Index()
        {
            var fullDisplayModel = await _display.DisplayModels();
            var displayvm = new DisplayAllViewModel(fullDisplayModel);

            return View(displayvm);
        }

        [HttpPost]
        public async  Task<ActionResult> UserRent (string movieName)
        {
            string userId = User.Identity.GetUserId();
            IUserRentService iurs = new UserRentService();
            Movie movie = await iurs.FindMovieByName(movieName);
            bool amount = await iurs.CheckAmount(movie);
            if(amount)
            {
                await iurs.SaveRent(movie,userId);
                ViewBag.Save = "Success rent";
            }
            else
            {
                ViewBag.Save = "Failed rent";
            }
            return RedirectToAction("Index");
        }
    }
}
