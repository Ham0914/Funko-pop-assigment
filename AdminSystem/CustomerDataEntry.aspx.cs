using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer AnCustomer = new clsCustomer();
        //capture the first name
        AnCustomer.FirstName = txtFirstName.Text;
        //store the first name in the session object
        Session["AnCustomer"] = AnCustomer;
        //capture the last name
        AnCustomer.LastName = txtLastName.Text;
        //store the last name in the session object
        Session["AnCustomer"] = AnCustomer;
        //capture the Email
        AnCustomer.Email = txtEmail.Text;
        //store the email in the session object
        Session["AnCustomer"] = AnCustomer;
        //capture the date of birth and convert it into a date
        ///String dateInput = txtDateOfBirth;
        ///var parsedDate = DateTime.Parse(dateInput);
        ///AnCustomer.DateOfBirth = txtDateOfBirth.t;
        //capture the active
        AnCustomer.Active = chkActive.Checked;
        //store the active in the session object
        Session["AnCustomer"] = AnCustomer;
        //navigate to the viewer page
        Response.Redirect("CustomerViewer.aspx");
    }
}