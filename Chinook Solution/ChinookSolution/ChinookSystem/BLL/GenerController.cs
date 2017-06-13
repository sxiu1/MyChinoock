using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using System.ComponentModel;//user for ObjectDataSource
using ChinookSystem.Data.Entities;
using ChinookSystem.DAL;
using ChinookSystem.Data.POCOs;
#endregion
namespace ChinookSystem.BLL
{
    [DataObject]
    public class GenreController
    {
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<ForeignKeyList> GenresList()
        {
            using (var context = new ChinookContext())
            {
                var results = from x in context.Genres
                              orderby x.Name
                              select new ForeignKeyList
                              {
                                  PFKeyIdentifier = x.GenreId,
                                  DisplayText = x.Name
                              };
                return results.ToList();

            }//end of using
        }//eom

    }//eoc
}//eon

