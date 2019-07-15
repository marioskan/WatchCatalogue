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

        public DisplayAllViewModel(List<SubscriptionService> services)
        {
            Services = new List<ServiceViewModel>();
            foreach (var service in services)
            {
                Services.Add(new ServiceViewModel(service.Name, service.Channels));
            }
        }
    }
    public class ServiceViewModel
    {
        public List<ChannelViewModel> Channels { get; set; }
        public string ServiceName { get; set; }

        public ServiceViewModel(string serviceName, List<Channel> channels)
        {
            ServiceName = serviceName;
            Channels = new List<ChannelViewModel>();
            foreach (var channel in channels)
            {
                Channels.Add(new ChannelViewModel(channel.Name, channel.Movies));
            }
        }
    }

    public class ChannelViewModel
    {
        public List<MovieViewModel> Movies { get; set; }
        public string ChannelName { get; set; }

        public ChannelViewModel(string channelName, List<Movie> movies)
        {
            Movies = new List<MovieViewModel>();
            ChannelName = channelName;

            foreach (var movie in movies)
            {
                Movies.Add(new MovieViewModel(movie.Name));
            }
        }
    }

    public class MovieViewModel
    {
        public string MovieName { get; set; }

        public MovieViewModel(string movieName)
        {
            MovieName = movieName;
        }
    }

}
