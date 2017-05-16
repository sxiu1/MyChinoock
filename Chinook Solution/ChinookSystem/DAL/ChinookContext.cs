using ChinookSystem.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces


#endregion

namespace ChinookSystem.DAL
{
    //This is an interal class for security reasons
    //Access is restricted to within this class library project
    //Inherits DbContext for Entity Framwork,whch requires
    //System.Data.Entity
    internal class ChinookCont : DbContext 
    {
        //Pass the connnection string name to the 
        // DbContext usng :base()
        public ChinookContext() : base("ChinookDB")
   { }
        //Setup for all DbSet properties once the Entity classes are created
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Track> Tracks { get; set; }
    }
}