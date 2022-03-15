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
        if(IsPostBack == false)
        {
            DisplayStock();
        }
    }

    void DisplayStock()
    {
        clsStockCollection AnStock = new clsStockCollection();

        lstStockList.DataSource = AnStock.StockList;

        lstStockList.DataValueField = "IDNum";

        lstStockList.DataTextField = "ItemTag";

        lstStockList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["itemID"] = -1;

        Response.Redirect("StockDataEntry.aspx");
    }

    protected void btn_edit_Click(object sender, EventArgs e)
    {
        Int32 itemID;

        if (lstStockList.SelectedIndex != 1)
        {
            itemID = Convert.ToInt32(lstStockList.SelectedValue);

            Session["itemID"] = itemID;

            Response.Redirect("StockDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to edit";
        }
    }

    protected void btn_delete_Click(object sender, EventArgs e)
    {
        Int32 itemID;

        if(lstStockList.SelectedIndex != 1)
        {
            itemID = Convert.ToInt32(lstStockList.SelectedValue);

            Session["itemId"] = itemID;

            Response.Redirect("StockConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete";
        }
    }

    protected void btn_apply_Click(object sender, EventArgs e)
    {
        clsStockCollection Stock = new clsStockCollection();
        Stock.ReportByItemTag(txt_tag.Text);
        lstStockList.DataSource = Stock.StockList;

        lstStockList.DataValueField = "IDNum";

        lstStockList.DataTextField = "ItemTag";

        lstStockList.DataBind();
    }

    protected void btn_clear_Click(object sender, EventArgs e)
    {
        clsStockCollection Stock = new clsStockCollection();

        Stock.ReportByItemTag("");

        txt_tag.Text = "";

        lstStockList.DataSource = Stock.StockList;

        lstStockList.DataValueField = "IDNum";

        lstStockList.DataTextField = "ItemTag";

        lstStockList.DataBind();
    }
}