﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using System.Data.Entity;
using ChinookSystem.Data.Entities;
#endregion

namespace ChinookSystem.BLL
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
        public Dbset<Gener> Geners { get; set; }
        public Dbset<MediaType> MediaTypes { get; set; }
        public object Genres { get; internal set; }

        internal class ChinookContext : IDisposable
        {
            internal object Genres;
        }
    }
}
