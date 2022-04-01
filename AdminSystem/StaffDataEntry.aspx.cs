using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primay key with page level scope
    Int32 staffID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the staff ID to be processed
        staffID = Convert.ToInt32(Session["staffID"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (staffID != -1)
            {
                //display the current data for the record
                DisplayStaff();
            }
        }
    }

    void DisplayStaff()
    {
        //create an instance of the Staff collection
        clsStaffCollection Staff = new clsStaffCollection();
        //find the ecord to update
        Staff.ThisStaff.Find(staffID);
        //display the data for this record
        txtStaffID.Text = Staff.ThisStaff.staffID.ToString();
        txtStaffEmail.Text = Staff.ThisStaff.staffEmail;
        txtStaffName.Text = Staff.ThisStaff.staffName;
        txtDepartment.Text = Staff.ThisStaff.department;
        txtHireDate.Text = Staff.ThisStaff.HireDate.ToString();
        chkActive.Checked = Staff.ThisStaff.Active;
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //Create a new instance of clsStaff
        clsStaff aStaff = new clsStaff();
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
            aStaff.staffID = staffID;
            //capture the staff email
            aStaff.staffEmail = staffEmail;
            //capture the staff name
            aStaff.staffName = staffName;
            //capture the department
            aStaff.department = department;
            //capture the hire date
            aStaff.HireDate = Convert.ToDateTime(hireDate);
            //capture active
            aStaff.Active = chkActive.Checked;
            //create a new instance of the staff collection
            clsStaffCollection StaffList = new clsStaffCollection();
            
            //if this is a new record i.e. staffID = -1 then add the data
            if (staffID == -1)
            {
                //set the ThisStaff property
                StaffList.ThisStaff = aStaff;
                //add the new record
                StaffList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                StaffList.ThisStaff.Find(staffID);
                //set the ThisStaff property
                StaffList.ThisStaff = aStaff;
                //update the record
                StaffList.Update();
            }
            //redirect back to the list page
            Response.Redirect("StaffList.aspx");
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