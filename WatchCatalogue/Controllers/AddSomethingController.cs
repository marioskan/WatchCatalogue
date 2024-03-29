﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WatchCatalogue.Core.Entities;
using WatchCatalogue.Core.Interfaces;
using WatchCatalogue.Infrastructure.Services;
using WatchCatalogue.ViewModels;

namespace WatchCatalogue.Controllers
{
    public class AddSomethingController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AddSubscriptionService()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddSubscriptionServicePost(SubscriptionService subscriptionService)
        {
            ISubscriptionServiceService iss = new SubscriptionServiceService();
            iss.SaveSubscriptionService(subscriptionService);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult AddChannelPost(ChannelSubscriptionViewModel vm)
        {
            vm.SubscriptionID = Int32.Parse(Request.Form.Get("select"));
            IChannelService ics = new ChannelService();
            ics.SaveChannelService(vm);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<ActionResult> AddChannel()
        {
            ISubscriptionServiceService iss = new SubscriptionServiceService();
            var list = await iss.ReturnSubscriptionServices();
            ChannelViewModel channelvm = new ChannelViewModel(list);
            return View(channelvm);
        }

        [HttpGet]
        public async Task<ActionResult> AddMovie()
        {
            IChannelService ics = new ChannelService();
            var list = await ics.ReturnChannelServices();
            AllViewModel allvm = new AllViewModel(list);
            return View(allvm);
        }

        [HttpPost]
        public ActionResult AddMoviePost(AllViewModel allvm)
        {
            IMovieService ims = new MovieService();
            allvm.AvailableAmount = allvm.Amount;
            allvm.ChannelID = Int32.Parse(Request.Form.Get("select"));
            ims.SaveMovieService(allvm);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<ActionResult> Restock()
        {
            IMovieService ims = new MovieService();
            var list = await ims.ReturnMovieListAsync();
            return View(list);
        }

        [HttpPost]
        public async Task<ActionResult> RestockPost()
        {
            int movieid = Int32.Parse(Request.Form.Get("select"));
            int newamount = Int32.Parse(Request.Form.Get("newamount"));
            IMovieService ims = new MovieService();
            await ims.RestockMoviesAsync(movieid,newamount);
            return RedirectToAction("Index");
        }
    }
}