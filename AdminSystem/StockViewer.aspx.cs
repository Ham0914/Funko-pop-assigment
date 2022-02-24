using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsStock AnStock = new clsStock();
        AnStock = (clsStock)Session["AnStock"];
        Response.Write("Item ID " + AnStock.IdNum + "<br/>");
        Response.Write("Item Quantity " + AnStock.ItemQty + "<br/>");
        Response.Write("Item Tag " + AnStock.ItemTag + "<br/>");
        Response.Write("Last time in stock " + AnStock.DateAdded + "<br/>");
        Response.Write("Item Description " + AnStock.ItemDesc + "<br/>");
        Response.Write("Is in stock ? " + AnStock.InStock + "<br/>");

    }
}