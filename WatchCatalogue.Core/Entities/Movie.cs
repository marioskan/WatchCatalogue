using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatchCatalogue.Core.Enumerations;

namespace WatchCatalogue.Core.Entities
{
    public class Movie
    {
        public int ID { get; set; }
        public int ChannelID { get; set; }
        public Channel Channel { get; set; }
        public int Amount { get; set; }
        public string Name { get; set; }
        public string ImgGuid { get; set; }
        public Genre Genre { get; set; }
        
    }
}
