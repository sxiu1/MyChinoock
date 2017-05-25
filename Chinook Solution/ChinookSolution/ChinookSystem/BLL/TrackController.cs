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
    public class TrackController
    {
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<TracksForPlayListSelection> TracksForPlayListSelection_Get(int ID, string fetchBy)
        {
            List<TracksForPlayListSelection> results = null;
            using (var context = new ChinookContext())
            {
               switch(fetchBy)
                {
                    case "Artist":
                        results = (
                            from x in context.Tracks
                            where x.Album.AlbumId.ArtistId == id
                            select new TracksForPlayListSelection
                            {
                                TrackId = x.TrackId


                Name = x.Name,
                                MediaType = x.MediaType.Name,
                                GenerName = x.Gener.Name,

                                composer = x.composer,
                                Milliseconds = x.Milliseconds,
                                Bytes = x.Bytes,
                                UnitPrice = x.UnitPrice,
                            }
                            ).ToList();
                            break;
                        case "Media"
                        results = (
                            from x in context.Tracks
                            where x.Album.AlbumId.ArtistId == id
                            select new TracksForPlayListSelection
                            {
                                TrackId = x.TrackId
              
                Name = x.Name,
                                MediaType = x.MediaType.Name,
                                GenerName = x.Gener.Name,

                                composer = x.composer,
                                Milliseconds = x.Milliseconds,
                                Bytes = x.Bytes,
                                UnitPrice = x.UnitPrice,
                            }
                            ).ToList
                        break;
                        case "Gener"
                        results = (
                                         from x in context.Tracks
                                          where x.Album.AlbumId.ArtistId == id
                                          select new TracksForPlayListSelection
                                          {
                                              TrackId = x.TrackId


                                              Name = x.Name,
                                              MediaName = x.MediaType.Name,
                                              GenerName = x.Gener.Name,

                                              composer = x.composer,
                                              Milliseconds = x.Milliseconds,
                                              Bytes = x.Bytes,
                                              UnitPrice = x.UnitPrice,
                                          }
				
                            ).ToList
                        break;



                }
            }//end of using
        }//end of using
    }//eoc
    return results;
}//eoc
