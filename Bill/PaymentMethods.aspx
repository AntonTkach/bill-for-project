<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaymentMethods.aspx.cs" Inherits="Bill.PaymentMethods" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="LabelPaymentMethod" runat="server" Text="Select payment method"></asp:Label>
        <br />
        <br />
        <asp:Image ID="ImagePayPal" runat="server" Height="75px" Width="75px" ImageUrl="https://images.seeklogo.net/2015/11/paypal-logo-preview-400x400.png"  />
        <asp:Button ID="ButtonPayPal" runat="server" Text="via PayPal" Height="75px" Width="100px" />
        
        <br />
        
        <br />
        
        <asp:Image ID="ImageAliPay" runat="server" Height="75px" Width="75px" ImageUrl="https://www.brandsoftheworld.com/sites/default/files/styles/logo-thumbnail/public/122016/untitled-1_140.jpg"/>
        <asp:Button ID="ButtonAliPay" runat="server" Text="via AliPay" Height="75px" Width="100px" />
    
    </div>
    </form>
</body>
</html>
