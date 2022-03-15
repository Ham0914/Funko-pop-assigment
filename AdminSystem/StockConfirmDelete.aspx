<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Are you sure you want to delete this ?</div>
        <asp:Button ID="btn_yes" runat="server" OnClick="btn_yes_Click" Text="Yes" />
        <asp:Button ID="btn_no" runat="server" Text="No" />
    </form>
</body>
</html>
