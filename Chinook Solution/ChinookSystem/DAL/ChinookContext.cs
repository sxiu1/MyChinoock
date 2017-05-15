using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using System.Data.Entity;
#endregion

namespace ChinookSystem.DAL
{
    //This is an interal class for security reasons
    //Access is restricted to within this class library project
    //Inherits DbContext for Entity Framwork,whch requires
    //System.Data.Entity
    internal class ChinookCont :DbContext 
    {
        //Pass the connnecting string name to the 
        // DbContext usng : base()
        public ChinookContext() : base("ChinookDB")
   { }
    }
}