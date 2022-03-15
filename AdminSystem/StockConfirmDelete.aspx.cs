using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 itemID;
    protected void Page_Load(object sender, EventArgs e)
    {
        itemID = Convert.ToInt32(Session["itemID"]);
    }

    protected void btn_yes_Click(object sender, EventArgs e)
    {
        clsStockCollection AnStock = new clsStockCollection();

        AnStock.ThisStock.Find(itemID);
        AnStock.Delete();

        Response.Redirect("StockList.aspx");
    }
}