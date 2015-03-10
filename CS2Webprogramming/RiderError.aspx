<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RiderError.aspx.cs" Inherits="CS2Webprogramming.RiderError" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="You were not allowed to visit this page"></asp:Label>
        <br />
        <br />
        <asp:Button ID="ButtonBack" runat="server" OnClick="Button1_Click" Text="To start page" />
    
    </div>
    </form>
</body>
</html>
