using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region Additional Namespaces
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#endregion
namespace ChinookSystem.Data.Entities
{
    [Table("PlaylistTracks")]
    public class PlaylistTrack
    {
        //The following shows a composite primary key
        [Key, Column(Order = 1)]
        public int PlaylistId { get; set; }
        [Key, Column(Order = 2)]
        public int TrackId { get; set; }
        //Navigation property
        public virtual Playlist Playlist { get; set; }
        public virtual Track Track { get; set; }
    }//eoc
}//eon