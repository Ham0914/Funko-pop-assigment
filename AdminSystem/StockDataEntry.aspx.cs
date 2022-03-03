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
        clsStock AnStock = new clsStock();

        AnStock.ItemTag = txtitemTag.Text;

        AnStock.IdNum = Convert.ToInt32(txtitemID.Text);

        AnStock.ItemQty = Convert.ToInt32(txtitemQTY.Text);

        AnStock.ItemDesc = txtItemDesc.Text;

        AnStock.DateAdded = Convert.ToDateTime(txtItemLastStock.Text);

        AnStock.InStock = chkitemInStock.Checked;


        Session["AnStock"] = AnStock;
        
        Response.Redirect("StockViewer.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        {
            clsStock AnStock = new clsStock();

            Int32 itemID;
            Boolean Found = false;

            itemID = Convert.ToInt32(txtitemID.Text);
            Found = AnStock.Find(itemID);
            if (Found == true)
            {
                txtitemID.Text = AnStock.IdNum.ToString();
                txtItemDesc.Text = AnStock.ItemDesc.ToString();
                txtitemQTY.Text = AnStock.ItemQty.ToString();
                txtitemTag.Text = AnStock.ItemTag.ToString();
                txtItemLastStock.Text = AnStock.DateAdded.ToString();
            }
        }
    }
}