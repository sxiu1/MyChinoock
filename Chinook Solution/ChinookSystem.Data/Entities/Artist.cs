using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region  Additional Namespaces
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#endregion

namespace ChinookSystem.Data.Entities
{
    [Table("Artists")]
    public class Artist
    class Artist
    {
        [Key]
        public int Artistid { get; set; }
        public string Name { get; set; }
        //Navigatin property used by LINQ
        public virtual ICollection<Album> Albums { get; set; }
    }
}
