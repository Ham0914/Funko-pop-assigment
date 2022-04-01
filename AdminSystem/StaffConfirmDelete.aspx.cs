using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //var to store the primary key value of the record to be deleted
    Int32 staffID;

    //event handler for the load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the ID of the staff member to be deleted from the session object
        staffID = Convert.ToInt32(Session["staffID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the staff class
        clsStaffCollection Staff = new clsStaffCollection();
        //find the record to delete
        Staff.ThisStaff.Find(staffID);
        //delete the record
        Staff.Delete();
        //redirect back to the main page
        Response.Redirect("StaffList.aspx");
    }
}