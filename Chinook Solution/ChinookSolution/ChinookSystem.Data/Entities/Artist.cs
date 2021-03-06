﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#endregion

namespace ChinookSystem.Data.Entities
{
    [Table("Employees")]
    public class Artist
    {
        [Key]
        public int EmployeeId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Title { get; set; }
        public int? resportsTo { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? HireDate{ get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
       public string  PostalCode{ get; set; }
        public string phone { get; set; }
        public string  Fax{ get; set; }
        public string  Email{ get; set; }
        // Navigation property
        public virtual ICollection<Customer> Customers { get; set; }
     public int ArtistId { get; set; }
        public string Name { get; set; }

        // Navigation property used by LINQ
        public virtual ICollection<Album> Albums { get; set; }
    }
}
