using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinookSystem.Data.POCOs
{
    public class UserPlaylistTrack
    {
        public int TrackId { get; set; }
        public string Title { get; set; }
        public int TimeLength { get; set; }
        public int? Size { get; set; }
        public decimal UnitPrice
        {
            get; set;
        }
    }
}
