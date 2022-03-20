using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //capture the order number
        String FunkoName = txtFunkoName.Text;
        String FunkoNo = txtFunkoNo.Text;
        String Price = txtPrice.Text;
        String DateAdded = txtDateAdded.Text;
        String OrderNo = txtOrderNo.Text;

        string Error = "";
        Error = AnOrder.Valid(FunkoName, Price, FunkoNo, DateAdded);
        if (Error == "")
        {
            AnOrder.FunkoName = txtFunkoName.Text;

            AnOrder.FunkoNo = Convert.ToInt32(txtFunkoNo.Text);

            AnOrder.Price = Convert.ToInt32(txtPrice.Text);

            AnOrder.DateAdded = Convert.ToDateTime(txtDateAdded.Text);

            AnOrder.OrderNo = Convert.ToInt32(txtOrderNo.Text);


            //store the address in the session object
            Session["AnOrder"] = AnOrder;
            //navigate to the viewer page
            Response.Redirect("OrderViewer.aspx");
        }
        else
        {
            lblerror.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        {
            //create an instance of the order class
            clsOrder AnOrder = new clsOrder();
            //variable to store the primary key
            Int32 FunkoNo;
            //variable to store the result of the find operation
            Boolean Found = false;
            //get the primary key entered by the user
            FunkoNo = Convert.ToInt32(txtFunkoNo.Text);
            //find the record
            Found = AnOrder.Find(FunkoNo);
            //if found
            if (Found == true)
            {
                //display the values of the properties in the form
                txtFunkoNo.Text = AnOrder.FunkoNo.ToString();
                txtFunkoName.Text = AnOrder.FunkoName;
                txtDateAdded.Text = AnOrder.DateAdded.ToString();
                txtPrice.Text = AnOrder.Price.ToString();
                txtOrderNo.Text = AnOrder.OrderNo.ToString();
            }
            
        }
    }
}