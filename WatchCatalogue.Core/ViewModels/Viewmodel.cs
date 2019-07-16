using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WatchCatalogue.Core.Entities;
using WatchCatalogue.Core.Enumerations;

namespace WatchCatalogue.ViewModels
{
    public class ChannelViewModel
    {
        public string Name { get; set; }
        public string ImgGuid { get; set; }
        public List<SubscriptionServiceViewModel> SubscriptionServiceVM { get; set; }


        public ChannelViewModel()
        {
            SubscriptionServiceVM = new List<SubscriptionServiceViewModel>();
        }


        public ChannelViewModel(List<SubscriptionService> subscriptionServices) : this()
        {
            Mapper.Map(subscriptionServices, SubscriptionServiceVM);
        }

    }
    public class SubscriptionServiceViewModel
        {
            public string Name { get; set; }
            public int ID { get; set; }
        }

    public class ChannelSubscriptionViewModel
    {
        public string Name { get; set; }
        public int SubscriptionID { get; set; }
    }


    public class AllViewModel
    {
        public int Rating { get; set; }
        public int ChannelID { get; set; }
        public string MovieName { get; set; }
        public Genre Genres { get; set; }
        public List<ChannelIdViewModel> ChannelVM{ get; set; }

        public AllViewModel()
        {
            ChannelVM = new List<ChannelIdViewModel>();
        }

        public AllViewModel(List<Channel> channelList) : this()
        {
            Mapper.Map(channelList, ChannelVM);
        }
    }


    public class ChannelIdViewModel
    {
        public int ChannelId { get; set; }
        public string ChannelName { get; set; }
    }


}