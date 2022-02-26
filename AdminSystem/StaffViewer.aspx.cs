using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff aStaff = new clsStaff();

        //get the data from the session object
        aStaff = (clsStaff) Session["aStaff"];


        //display the ID for this entry
        Response.Write(aStaff.staffID + "<br />");

        //display the ID for this entry
        Response.Write(aStaff.staffEmail + "<br />");

        //display the ID for this entry
        Response.Write(aStaff.staffName + "<br />");

        //display the ID for this entry
        Response.Write(aStaff.department + "<br />");

        //display the ID for this entry
        Response.Write(aStaff.HireDate + "<br />");

        //display the ID for this entry
        Response.Write(aStaff.Active + "<br />");
    }
}