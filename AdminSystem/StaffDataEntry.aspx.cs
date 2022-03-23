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
        //Create a new instance of clsStaff
        clsStaff aStaff = new clsStaff();
        //capture the staff ID
        string staffID = txtStaffID.Text;
        //capture the staff email
        string staffEmail = txtStaffEmail.Text;
        //capture the staff name
        string staffName = txtStaffName.Text;
        //capture the department
        string department = txtDepartment.Text;
        //capture the hire date
        string hireDate = txtHireDate.Text;
        //capture the active
        string active = chkActive.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = aStaff.Valid(staffEmail, staffName, department, hireDate);
        if (Error == "")
        {
            //capture the staff ID
            aStaff.staffID = Convert.ToInt32(txtStaffID.Text);
            //capture the staff email
            aStaff.staffEmail = txtStaffEmail.Text;
            //capture the staff name
            aStaff.staffName = txtStaffName.Text;
            //capture the department
            aStaff.department = txtDepartment.Text;
            //capture the hire date
            aStaff.HireDate = Convert.ToDateTime(txtHireDate.Text);
            //cpture the active
            aStaff.Active = Convert.ToBoolean(chkActive.Checked);
            //store the staff memeber in the session object
            Session["aStaff"] = aStaff;
            //redirect to the viewer page
            Response.Redirect("StaffViewer.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the Staff class
        clsStaff aStaff = new clsStaff();
        //variable to store the primary key
        Int32 staffID;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        staffID = Convert.ToInt32(txtStaffID.Text);
        //find the record
        Found = aStaff.Find(staffID);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtStaffEmail.Text = aStaff.staffEmail;
            txtStaffName.Text = aStaff.staffName;
            txtDepartment.Text = aStaff.department;
            txtHireDate.Text = aStaff.HireDate.ToString();
        }
    }
}