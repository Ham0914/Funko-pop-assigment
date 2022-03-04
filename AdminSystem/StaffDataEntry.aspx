<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblStaffID" runat="server" Text="Staff ID" width="118px"></asp:Label>
&nbsp;<asp:TextBox ID="txtStaffID" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        </div>
        <p>
            <asp:Label ID="lblStaffEmail" runat="server" Text="Email Address"></asp:Label>
&nbsp;
            <asp:TextBox ID="txtStaffEmail" runat="server" Height="16px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblStaffName" runat="server" Text="Full Name" width="118px"></asp:Label>
&nbsp;
            <asp:TextBox ID="txtStaffName" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblDepartment" runat="server" Text="Department" width="118px"></asp:Label>
&nbsp;
        <asp:TextBox ID="txtDepartment" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblHireDate" runat="server" Text="Date Hired" width="118px"></asp:Label>
&nbsp;
            <asp:TextBox ID="txtHireDate" runat="server"></asp:TextBox>
        </p>
        <asp:CheckBox ID="chkActive" runat="server" Text="Active" />
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>
