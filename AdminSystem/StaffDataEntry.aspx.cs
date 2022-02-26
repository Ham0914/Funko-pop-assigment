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
        clsStaff aStaff = new clsStaff
        {
            staffID = Convert.ToInt32(txtStaffID.Text),
            staffEmail = txtStaffEmail.Text,
            staffName = txtStaffName.Text,
            department = txtDepartment.Text,
            HireDate = Convert.ToDateTime(txtHireDate.Text),
            Active = Convert.ToBoolean(chkActive.Checked)
        };

        Session["aStaff"] = aStaff;

        Response.Redirect("StaffViewer.aspx");
    }
}