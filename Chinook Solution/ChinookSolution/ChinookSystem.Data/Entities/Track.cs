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
    [Table("Tracks")]
    public class Track
    {
        [Key]
        public int TrackId { get; set; }
        [Required(ErrorMessage = "Name is a required field.")]
        [StringLength(200, ErrorMessage = "Name is too long. Max is 200 characters. ")]
        [MinLength(2, ErrorMessage = "Name must be at least 2 characters")]
        public string Name { get; set; }
        [Range(1.0, double.MaxValue, ErrorMessage = "Invalid AlbumID...please try again.")]
        public int? AlbumId { get; set; }
        [Required(ErrorMessage = "MediaTypeId is a required field.")]
        [Range(1.0, double.MaxValue, ErrorMessage = "Invalid MediaTypeID...please try again.")]
        public int MediaTypeId { get; set; }
        [Range(1.0, double.MaxValue, ErrorMessage = "Invalid GenreID...please try again.")]
        public int? GenreId { get; set; }
        [StringLength(220, ErrorMessage = "Composer is too long. Max is 220 charactes. ")]
        public string Composer { get; set; }
        [Required(ErrorMessage = "Milliseconds is a required field.")]
        public int Milliseconds { get; set; }
        public int? Bytes { get; set; }
        [Required(ErrorMessage = "UnitPrice is a required field.")]
        [Range(1.0, double.MaxValue, ErrorMessage = "Invalid price...must be 0 or greater.")]
        public decimal UnitPrice { get; set; }

        //Navigation Properties
        public virtual Album Album { get; set; }
        public virtual Genre Genre { get; set; }
        public virtual MediaType MediaType { get; set; }
    }
}
