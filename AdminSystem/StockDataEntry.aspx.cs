using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 itemID;
    protected void Page_Load(object sender, EventArgs e)
    {
        itemID = Convert.ToInt32(Session["itemID"]);
        if (IsPostBack == false)
        {
            if(itemID!= -1)
            {
                DisplayStock();
            }
        }
    }

    void DisplayStock()
    {
        clsStockCollection AnStock = new clsStockCollection();

        AnStock.ThisStock.Find(itemID);

        txtitemID.Text = AnStock.ThisStock.IdNum.ToString();
        txtitemQTY.Text = AnStock.ThisStock.ItemQty.ToString();
        txtItemLastStock.Text = AnStock.ThisStock.DateAdded.ToString();
        txtItemDesc.Text = AnStock.ThisStock.ItemDesc;
        txtitemTag.Text = AnStock.ThisStock.ItemTag;
        chkitemInStock.Checked = AnStock.ThisStock.InStock;
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsStock AnStock = new clsStock();

        string ItemTag = txtitemTag.Text;

        string IdNum = txtitemID.Text;

        string ItemQty = txtitemQTY.Text;

        string ItemDesc = txtItemDesc.Text;

        string DateAdded = txtItemLastStock.Text;

        string Error = "";

        Error = AnStock.Valid( ItemQty, ItemTag, DateAdded,  ItemDesc );
        if(Error == "")
        {
            AnStock.ItemTag = ItemTag;
            AnStock.IdNum = Convert.ToInt32(IdNum);
            AnStock.ItemQty = Convert.ToInt32(ItemQty);
            AnStock.ItemDesc = ItemDesc;
            AnStock.DateAdded = Convert.ToDateTime(DateAdded);
            AnStock.InStock = chkitemInStock.Checked;

            clsStockCollection StockList = new clsStockCollection();
            
            if (Convert.ToInt32(IdNum) == -1)
            {
                StockList.ThisStock = AnStock;
                StockList.Add();
            }
            else
            {
                StockList.ThisStock.Find(Convert.ToInt32(IdNum));

                StockList.ThisStock= AnStock;

                StockList.Update();
            }
            Response.Redirect("StockList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
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