<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblCustomerId" runat="server" Text="Customer ID"></asp:Label>
        <asp:TextBox ID="txtCustomerId" runat="server"></asp:TextBox>
        <p>
        <asp:Label ID="lblFirstName" runat="server" Text="First name" width="100px"></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
        </p>
            <asp:Label ID="lblLastName" runat="server" Text="Last Name" width="100px"></asp:Label>
            <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
        <p>
        <asp:Label ID="lblEmail" runat="server" Text="Email" width="100px"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblDateOfBirth" runat="server" Text="Date of birth"></asp:Label>
            <asp:TextBox ID="txtDateOfBirth" runat="server"></asp:TextBox>
        </p>
        <p>
        <asp:CheckBox ID="chkActive" runat="server" Text="Active" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <p>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="Ok" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancle" />
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        </p>
    </form>
</body>
</html>
