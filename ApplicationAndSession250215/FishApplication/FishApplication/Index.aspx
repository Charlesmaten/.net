<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="FishApplication.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Fish application</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="LabelHeader" runat="server" Text="Fish in collection"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="TextBoxFish" runat="server" Height="100px" TextMode="MultiLine" Width="400px"></asp:TextBox>
        <br />
        <br />
&nbsp;<asp:Button ID="ButtonCreatePage" runat="server" Text="Go to create page" OnClick="ButtonCreatePage_Click" />
        &nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <br />
        <asp:Button ID="ButtonSave" runat="server" OnClick="ButtonSave_Click" Text="Save" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonRead" runat="server" OnClick="ButtonRead_Click" Text="Read" />
    
        <br />
        <br />
        <br />
        <asp:Label ID="LabelLogin" runat="server" Text="You are at level 0"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="TextBoxPassword" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="LabelPassword" runat="server" Text="Password"></asp:Label>
        <br />
        <br />
        <asp:Button ID="ButtonLogin" runat="server" OnClick="ButtonLogin_Click" Text="Login" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonLogout" runat="server" OnClick="ButtonLogout_Click" Text="Logout" />
        <br />
    
    </div>
    </form>
</body>
</html>
