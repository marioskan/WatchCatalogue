using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatchCatalogue.Core.Entities;
using WatchCatalogue.Core.ViewModels;
using WatchCatalogue.ViewModels;

namespace WatchCatalogue.Infrastructure.Mapper
{
    public class AutomapperWebProfile: AutoMapper.Profile
    {
        public AutomapperWebProfile()
        {
            CreateMap<SubscriptionService, SubscriptionServiceViewModel>();
            CreateMap<SubscriptionService, ServiceViewModel>()
                .ForMember(subvm => subvm.ServiceName, sub => sub.MapFrom(src => src.Name))
                .ForMember(subvm => subvm.Channels, sub => sub.MapFrom(src => src.Channels));
            CreateMap<Channel, ChannelIdViewModel>()
                .ForMember(channelvm => channelvm.ChannelId, channel => channel.MapFrom(src => src.ID))
                .ForMember(channelvm => channelvm.ChannelName, channel => channel.MapFrom(src => src.Name));
            CreateMap<Channel, Core.ViewModels.ChannelViewModel>()
                .ForMember(channelvm => channelvm.ChannelName, channel => channel.MapFrom(src => src.Name))
                .ForMember(channelvm => channelvm.Movies, channel => channel.MapFrom(src => src.Movies));
            CreateMap<Movie, MovieViewModel>()
                .ForMember(movievm => movievm.MovieName, movie => movie.MapFrom(src => src.Name));
            CreateMap<AllViewModel, Movie>()
                .ForMember(movie => movie.Genre, allvm => allvm.MapFrom(src => src.Genres))
                .ForMember(movie => movie.Name, allvm => allvm.MapFrom(src => src.MovieName));
        }

        public static void Run()
        {
            AutoMapper.Mapper.Initialize(item =>
            {
                    item.AddProfile<AutomapperWebProfile>();
            });
        }
    }
}
