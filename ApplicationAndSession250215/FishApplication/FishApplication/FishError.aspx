﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FishError.aspx.cs" Inherits="FishApplication.FishError" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Error page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="You were not allowed to visit that page"></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="To start page" />
    
    </div>
    </form>
</body>
</html>
