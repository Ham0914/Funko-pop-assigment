<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstStockList" runat="server" Height="190px" Width="248px"></asp:ListBox>
        </div>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
            <asp:Button ID="btn_edit" runat="server" OnClick="btn_edit_Click" Text="Edit" />
            <asp:Button ID="btn_delete" runat="server" OnClick="btn_delete_Click" Text="Delete" />
        </p>
        <p>
            <asp:Label ID="lbl_tag" runat="server" Text="Enter Tag"></asp:Label>
            <asp:TextBox ID="txt_tag" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btn_apply" runat="server" OnClick="btn_apply_Click" Text="Apply" />
            <asp:Button ID="btn_clear" runat="server" OnClick="btn_clear_Click" Text="Clear" />
        </p>
        <asp:Label ID="lblError" runat="server"></asp:Label>
    </form>
</body>
</html>
