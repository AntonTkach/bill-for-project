<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderingPage.aspx.cs" Inherits="Bill.CheckOutPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ImageButton ID="ImageButtonLogo" runat="server" AlternateText="Logo Image Clickable" />
        <br />
        <asp:Label ID="LabelCart" runat="server" Font-Size="XX-Large" Text="Your Cart"></asp:Label>
        <br />
        <asp:Label ID="LabelProduct" runat="server" Text="Product"></asp:Label>
        <br />
        <br />
        <asp:Button ID="ButtonCheckOut" runat="server" Text="Procced to checkout" />
    
    </div>
    </form>
</body>
</html>
