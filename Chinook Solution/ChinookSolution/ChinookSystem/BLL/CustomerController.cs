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
    public  class CustomerController
    {
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<RepresntativeCustomer> RepresntativeCustomer_Get(int employee)
             using (var context = new ChinookContext())
    {
     var results = from x in context.Customers
                   where x.SupportRepId == employeeId

                   orderby x.LastName, x.FirstName
                   select new RepresntativeCustomer
                   {
                     Name = x.LastName + "," + x.FristName,
                       City = x.City
    
                                 State = x.State
    
                                 Phone = x.Phone
    
                                 Email = x.Email
                   };
    results.Dump();

    }
}
