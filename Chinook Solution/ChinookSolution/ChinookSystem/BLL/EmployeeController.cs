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
    public  class EmployeeController
    {
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<EmployeeNameList> EmployeeNameList Get()
        {
            using (var context = new ChinookContext())
            { 
                var results = from x in context.Employees

                              orderby x.LastName, x.FirstName
                              select new EmployeeNameList
                              {
                                  EmployeeId = x.EmployeeId


                                 Name = x.LastName + "," + x.FirstName
                              };
            results.Dump();
        }
        //
    }//
}//
