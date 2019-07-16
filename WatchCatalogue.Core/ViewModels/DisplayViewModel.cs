using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatchCatalogue.Core.Entities;

namespace WatchCatalogue.Core.ViewModels
{
    public class DisplayAllViewModel
    {
        public List<ServiceViewModel> Services { get; set; }

        public DisplayAllViewModel()
        {
            Services = new List<ServiceViewModel>();
        }

        public DisplayAllViewModel(List<SubscriptionService> services) :this()
        {
            //foreach (var service in services)
            //{
            //    Services.Add(new ServiceViewModel(service.Name, service.Channels));
            //}
            Mapper.Map(services,Services);
        }
    }
    public class ServiceViewModel
    {
        public List<ChannelViewModel> Channels { get; set; }
        public string ServiceName { get; set; }

        public ServiceViewModel()
        {
            Channels = new List<ChannelViewModel>();
        }
        public ServiceViewModel(string serviceName, List<Channel> channels) : this()
        {
            //here
            ServiceName = serviceName;
            Channels = new List<ChannelViewModel>();
            Mapper.Map(channels, Channels);
        }
    }

    public class ChannelViewModel
    {
        public List<MovieViewModel> Movies { get; set; }
        public string ChannelName { get; set; }

        public ChannelViewModel()
        {
            Movies = new List<MovieViewModel>();
        }

        public ChannelViewModel(string channelName, List<Movie> movies)
        {
            Movies = new List<MovieViewModel>();
            ChannelName = channelName;
            Mapper.Map(movies, Movies);
        }
    }

    public class MovieViewModel
    {
        public string MovieName { get; set; }

        public MovieViewModel()
        {
            //this.MovieName = MovieName;
        }
        public MovieViewModel(string movieName)
        {
            MovieName = movieName;
        }
    }

}
