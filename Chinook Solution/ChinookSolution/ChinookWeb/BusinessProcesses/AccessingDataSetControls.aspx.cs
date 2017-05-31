using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BusinessProcesses_AccessingDataSetControls : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }//eom
    protected  void CheckForExcepton(object sender, ObjectData e)
    {
        MessageUserControl.HandlDataBoundException(e);

    }
}//eom