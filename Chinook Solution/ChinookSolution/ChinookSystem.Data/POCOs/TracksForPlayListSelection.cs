using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#endregion


namespace ChinookSystem.Data.POCOs
{
  public   class TracksForPlayListSelection
    {
        public int TrackId { get; set; }
        public string Name { get; set; }
        public string MediaName { get; set; }
        public string GenerName { get; set; }
        public string composer { get; set; }
        public string Millisecongs { get; set; }
        public string Bytes { get; set; }
        public string  UnitPrice   { get; set; }
    }
}
