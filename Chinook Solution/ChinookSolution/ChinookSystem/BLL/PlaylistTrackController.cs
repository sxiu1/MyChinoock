using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using System.ComponentModel;//user for ObjectDataSource
using ChinookSystem.Data.Entities;//nedd to know about the Artist.cs
using ChinookSystem.DAL;
using ChinookSystem.Data.POCOs;//needed for AlbumArtist.cs
#endregion
namespace ChinookSystem.BLL
{
    [DataObject]
    public class PlaylistTracksController
    {
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<UserPlaylistTrack> List_TracksForPlaylist(string playlistName)
        {
            using (var context = new ChinookContext())
            {
                //Return:trackid,title,timelength,size,unitprice
                var results = from x in context.PlaylistTracks
                              where x.Playlist.Name.Equals(playlistName)
                              orderby x.Track.Name
                              select new UserPlaylistTrack
                              {
                                  TrackId = x.TrackId,
                                  Title = x.Track.Name,
                                  TimeLength = x.Track.Milliseconds,
                                  Size = x.Track.Bytes,
                                  UnitPrice = x.Track.UnitPrice
                              };
                return results.ToList();
            }//end of using
        }//eom
        //THIS METHOD IS NOT NEEDED IN THIS EXAMPLE
        public void Update_TracksForPlaylist(string palylistName, List<UserPlaylistTrack> playlistTitles)
        {
            using (var context = new ChinookContext())
            {

            }//end of using
        }//eom
        public void Add_TracksToPlaylist(string playlistName, int trackId)
        {
            using (var context = new ChinookContext())
            {
                //need to know if there is an existing playlist with the playlistName parameter
                //if one exits then load the Playlist
                //to find a item use a DbContext lookup
                Playlist existing = (
                    from x in context.Playlists
                    where x.Name.Equals(playlistName)
                    select x).FirstOrDefault();
                //create a PlaylistTrack
                PlaylistTrack newTrack = null;
                //is it empty/null
                if (existing == null)
                {
                    //make a new Playlist
                    existing = new Playlist();
                    //fill its properties
                    existing.Name = playlistName;
                    //save the Playlist
                    existing = context.Playlists.Add(existing);
                }
                else
                {
                    //Playlist already exists,thus try to add a new track
                    newTrack = existing.PlaylistTracks.SingleOrDefault(x => x.TrackId == trackId);

                }
                //need to check if there is an existing track in the playlist
                //duplicates tracks are NOT allowed in a playlist
                if (newTrack != null)
                {
                    //there is already a track on the playlist with the same TraclId
                    throw new Exception("Playlist already has the required track.");
                }
                //now add the requested track to PlaylistTrack
                newTrack = new PlaylistTrack();
                newTrack.TrackId = trackId;
                existing.PlaylistTracks.Add(newTrack);
                //save in the database
                //only works if there are NO errors
                context.SaveChanges();
            }//end of using
        }//eom
        public void Remove_TracksFromPlaylist(string playlistName, int trackId)
        {
            using (var context = new ChinookContext())
            {
                //need to get the Playlist with the playlistName parameter
                Playlist existing = (
                   from x in context.Playlists
                   where x.Name.Equals(playlistName)
                   select x).FirstOrDefault();
                //find the track with the traclId
                var trackToRemove = context.PlaylistTracks.Find(existing.PlaylistId, trackId);
                //remove the track
                context.PlaylistTracks.Remove(trackToRemove);
                //save the changes to the database
                context.SaveChanges();
            }//end of using
        }//eom
    }//eoc
}//eon
