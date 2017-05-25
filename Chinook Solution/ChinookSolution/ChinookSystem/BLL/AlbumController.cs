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


namespace ChinookSystem.BLL
{
    [DataObject]
    public class AlbumController
    {
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<FoereginKeyList> AlbumList()
        {
            using (var context = new ChinookContext())
            {
                var results = from x in contxt.Albums
                              orderby x.Title
                              select new FoereginKeyList
                              {
                                  PFKeyIdentifier = x.AlbumId,
                                  DisplayText = x.Title
                              };
                return results.ToList();

            }//eom
        }//eoc
    }//eoc
}
