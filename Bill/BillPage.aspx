<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BillPage.aspx.cs" Inherits="Bill.BillPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Header" runat="server" Text="Order/Bill number:"></asp:Label>
        <asp:Label ID="NumberCounter" runat="server" Text="-number goes here-" OnLoad="NumberCounter_Load"></asp:Label>
        <br />
    
    </div>
        <asp:Label ID="Footer" runat="server" Text="Copiright 2017 TUT" BorderStyle="None" Font-Size="X-Small" Width="500px"></asp:Label>
    </form>
</body>
</html>
