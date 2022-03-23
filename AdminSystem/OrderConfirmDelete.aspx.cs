using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using ClassLibrary;
using System.Web.UI.WebControls;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 FunkoNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        FunkoNo = Convert.ToInt32(Session["FunkoNo"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsOrderCollection Order = new clsOrderCollection();
        Order.ThisOrder.Find(FunkoNo);
        Order.Delete();
        Response.Redirect("OrderList.aspx");
    }
}