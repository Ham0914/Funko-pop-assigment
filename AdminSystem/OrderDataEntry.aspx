<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblFunkoNo" runat="server" Text="Funko Number" width="70px"></asp:Label>
        <asp:TextBox ID="txtFunkoNo" runat="server"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        <br />
            <asp:Label ID="lblOrderNo" runat="server" Text="Order Number" width="70px"></asp:Label>
            <asp:TextBox ID="txtOrderNo" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblFunkoName" runat="server" Text="Funko Name" width="70px"></asp:Label>
        <asp:TextBox ID="txtFunkoName" runat="server"></asp:TextBox>
        <br />
            <asp:Label ID="lblDateAdded" runat="server" Text="Date Added" width="70px"></asp:Label>
            <asp:TextBox ID="txtDateAdded" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblPrice" runat="server" Text="Price" width="70px"></asp:Label>
        <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
        <br />
        <asp:CheckBox ID="chkAvailable" runat="server" Text="Available"/>
        <br />
        <asp:Label ID="lblerror" runat="server"></asp:Label>
        <br />
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>
