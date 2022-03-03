<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblitemID" runat="server" Text="Item ID" width="100px"></asp:Label>
            <asp:TextBox ID="txtitemID" runat="server"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        </div>
        <asp:Label ID="lblitemQTY" runat="server" Text="Item Quantity" width="100px"></asp:Label>
        <asp:TextBox ID="txtitemQTY" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblitemTag" runat="server" Text="Item Tag" width="100px"></asp:Label>
        <asp:TextBox ID="txtitemTag" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblitemLastStock" runat="server" Text="Item Last Stock" width="100px"></asp:Label>
        <asp:TextBox ID="txtItemLastStock" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblitemDesc" runat="server" Text="Item Description"></asp:Label>
        <asp:TextBox ID="txtItemDesc" runat="server"></asp:TextBox>
        <br />
        <asp:CheckBox ID="chkitemInStock" runat="server" Text="Item In stock" />
        <br />
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
    </form>
</body>
</html>
