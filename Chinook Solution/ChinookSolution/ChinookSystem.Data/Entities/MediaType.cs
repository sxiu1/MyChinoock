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
    [Table("MediaTypes")]
    public class MediaType
    {
        [Key]
        public int MediaTypeId { get; set; }
        [StringLength(120, ErrorMessage = "Name is too long. Max is 120 characters. ")]
        [MinLength(2, ErrorMessage = "Name must be at least 2 characters")]
        public string Name { get; set; }

        //Navigation Properties
        public virtual ICollection<Track> Tracks { get; set; }

    }
}
