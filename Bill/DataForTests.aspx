<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataForTests.aspx.cs" Inherits="Bill.DataForTests" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Font-Size="X-Large" Text="Store Page"></asp:Label>
        <br />
        <asp:Label ID="LabelTable" runat="server" Text="Table of content"></asp:Label>
        <asp:Table ID="TableContent" runat="server" Height="120px" Width="150px">
            <asp:TableRow ID="TableRowDescription" runat="server">
                <asp:TableCell runat="server">.</asp:TableCell>
                <asp:TableCell runat="server">Name</asp:TableCell>
                <asp:TableCell runat="server">Address</asp:TableCell>
                <asp:TableCell runat="server">IBAN</asp:TableCell>
            </asp:TableRow>
            <asp:TableRow ID="TableRowCustomer" runat="server">
                <asp:TableCell ID="CustomerInfo" runat="server">Customer</asp:TableCell>
                <asp:TableCell runat="server">Bob</asp:TableCell>
                <asp:TableCell runat="server">Tab</asp:TableCell>
                <asp:TableCell runat="server">EE123456789</asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server">
            </asp:TableRow>
        </asp:Table>
        <br />
        <asp:CheckBox ID="CheckBoxEmail" runat="server" Text="send bill by email" />
        <br />
        <asp:Button ID="ButtonPay" runat="server" Text="Pay/Create a bill" />
    
    </div>
    </form>
</body>
</html>
