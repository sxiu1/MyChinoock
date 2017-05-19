using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Addtional Namespaces
using System.ComponentModel;
using ChinookSystem.Data.Entities;
using ChinookSystem.DAL;
using ChinookSystem.Data.POCOs;
#endregion 

namespace ChinookSystem.DAL
{
    [DataObject]
    public class ArtistController
    {
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<Artist> Artist_ListAll()
        {
            using (var context = new ChinookContext())
            {
                return context.Artists.ToList();
            }
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<ArtistAlbum> ArtistAlbums_Get(int year)
        {
            using (var context = new ChinookContext())
            {
                var results = from x in Albums
                              where x.ReleaseYear == 2000
                              orderby x.Artist.Name, x.Title
                              select new
                              {
                                  Name = x.Artist.Name,
                                  Title = x.Title
                              };
                results.Dump();
            }

        }
    }
}

}
