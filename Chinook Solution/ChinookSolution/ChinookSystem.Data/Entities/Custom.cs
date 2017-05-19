using System;
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
    [Table("Customers")]
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public int  FirstName{ get; set; }
        public int LastName { get; set; }
        public string Title { get; set; }
        public int? resportsTo { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? HireDate { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        [ForeignKey("Employee")]
        public int? SupportRepId { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
