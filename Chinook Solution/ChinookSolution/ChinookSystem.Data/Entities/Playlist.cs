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
    [Table("Playlists")]
    public class Playlist
    {
        [Key]
        public int PlaylistId { get; set; }
        [Required(ErrorMessage = "Name is a required field.")]
        [StringLength(120, ErrorMessage = "Name too long. Max is 120 characters.")]
        public string Name { get; set; }

        //Navigation property
        public virtual ICollection<PlaylistTrack> PlaylistTracks { get; set; }

    }//eoc
}//eon