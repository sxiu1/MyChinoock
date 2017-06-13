
#region Additional Namespaces
using ChinookSystem.Data.Entities;
#endregion

namespace ChinookSystem.DAL
{
    // This is an internal class for security reasons
    // Access is resstricted to within this class library project
    // Inherits DbContext for Entity Framework, which requires System.Data.Entity
    internal class ChinookContext : DbContext
    {
        // Pass the connection string name to the DbContext using :base()
        public ChinookContext() : base("ChinookDB")
        { }

        // Setup for all DbSet properties once the Entity classes are created
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Track> Tracks { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<MediaType> MediaTypes { get; set; }
        public DbSet<Playlist> Playlists { get; set; }
        public DbSet<PlaylistTrack> PlaylistTracks { get; set; }
    }

    internal class DbContext
    {
        private string v;

        public DbContext(string v)
        {
            this.v = v;
        }
    }

    public class Employee
    {
    }

    public class DbSet<T>
    {
    }
}

