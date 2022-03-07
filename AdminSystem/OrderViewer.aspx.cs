using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using ClassLibrary;
using System.Web.UI.WebControls;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new insatnce of clsOrder
        clsOrder anOrder = new clsOrder();
        //get the data from the session object
        anOrder = (clsOrder)Session["AnOrder"];
        //display the order number for this entry
        Response.Write(anOrder.FunkoName + "<br/>");
        Response.Write(anOrder.OrderNo + "<br/>");
        Response.Write(anOrder.Price + "<br/>");
        Response.Write(anOrder.DateAdded + "<br/>");
        Response.Write(anOrder.Available + "<br/>");
        Response.Write(anOrder.FunkoNo + "<br/>");
    }
}