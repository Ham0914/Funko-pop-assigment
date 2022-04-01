using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayStaff();
        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["staffID"] = -1;
        //reirect to the data entry page
        Response.Redirect("StaffDataEntry.aspx");
    }

    void DisplayStaff()
    {
        //create an instance of the Staff collection
        clsStaffCollection Staff = new clsStaffCollection();
        //set the data source to list of staff members in the collection
        lstStaffList.DataSource = Staff.StaffList;
        //set the name of the primary key
        lstStaffList.DataValueField = "staffID";
        //set the data field to display
        lstStaffList.DataTextField = "staffName";
        //bind the data to the list
        lstStaffList.DataBind();
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 staffID;
        //if a record has been selected from the list
        if (lstStaffList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            staffID = Convert.ToInt32(lstStaffList.SelectedValue);
            //store the data in the session object
            Session["staffID"] = staffID;
            //redirect to the edit page
            Response.Redirect("StaffDataEntry.aspx");
        }
        else //if no record has been selected
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 staffID;
        //if a record has been selected from the list
        if (lstStaffList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            staffID = Convert.ToInt32(lstStaffList.SelectedValue);
            //store the data in the session object
            Session["staffID"] = staffID;
            //redirect to the edit page
            Response.Redirect("StaffConfirmDelete.aspx");
        }
        else //if no record has been selected
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //create an instance of the Staff collection
        clsStaffCollection Staff = new clsStaffCollection();
        Staff.ReportByDepartment(txtFilter.Text);
        lstStaffList.DataSource = Staff.StaffList;
        //set the name of the primary key
        lstStaffList.DataValueField = "staffID";
        //set the name of the field to display
        lstStaffList.DataTextField = "department";
        //bind the data to the list
        lstStaffList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        //create an instance of the Staff collection
        clsStaffCollection Staff = new clsStaffCollection();
        Staff.ReportByDepartment("");
        //clear any existing filter to tidy up the interface
        txtFilter.Text = "";
        lstStaffList.DataSource = Staff.StaffList;
        //set the name of the primary key
        lstStaffList.DataValueField = "staffID";
        //set the name of the field to display
        lstStaffList.DataTextField = "department";
        //bind the data to the list
        lstStaffList.DataBind();
    }
}