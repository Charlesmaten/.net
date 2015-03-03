<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="FishApplication.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>FishApplication</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TextBoxFish" runat="server" AutoPostBack="True" Height="123px" TextMode="MultiLine" Width="440px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="ButtonCreatepage" runat="server" OnClick="ButtonCreatepage_Click" Text="Go to create page" />
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Save" OnClick="Button1_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="Read" OnClick="Button2_Click" />
    
        <br />
        <br />
        <asp:Label ID="LabelLogin" runat="server" Text="You are at level 0"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="TextBoxPassword" runat="server"></asp:TextBox>
&nbsp;
        <asp:Label ID="LabelPassword" runat="server" Text="Password"></asp:Label>
        <br />
        <br />
        <asp:Button ID="ButtonLogin" runat="server" OnClick="ButtonLogin_Click" Text="Login" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonLogout" runat="server" OnClick="ButtonLogout_Click" Text="Logout" />
    
    </div>
    </form>
</body>
</html>
