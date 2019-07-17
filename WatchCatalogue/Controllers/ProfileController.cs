using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WatchCatalogue.Core.Interfaces;
using WatchCatalogue.Infrastructure.Services;

namespace WatchCatalogue.Controllers
{
    public class ProfileController : Controller
    {
        // GET: Profile
        public ActionResult MyRents()
        {
            string userId = User.Identity.GetUserId();
            IUserRentService iurs = new UserRentService();
            var rents = iurs.ReturnMovie(userId);
            return View();
        }
    }
}