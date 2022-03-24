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

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the custome class
        clsCustomer AnCustomer = new clsCustomer();
        //varible to store primary key
        Int32 CustomerId;
        //varible to store the result of the find operation
        Boolean Found = false;
        //get the primary key enterd by the user
        CustomerId = Convert.ToInt32(txtCustomerId.Text);
        //find the recod
        Found = AnCustomer.Find(CustomerId);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtCustomerId.Text = AnCustomer.CustomerId.ToString();
            txtFirstName.Text = AnCustomer.FirstName;
            txtLastName.Text = AnCustomer.LastName;
            txtEmail.Text = AnCustomer.Email;
            txtDateOfBirth.Text = AnCustomer.DateOfBirth.ToString();
        }
    }
}