<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="CS2Webprogramming.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TextBoxRiders" runat="server" Height="242px" TextMode="MultiLine" Width="572px"></asp:TextBox>

        <br />
        <br />
        <asp:Button ID="ButtonCreateRider" runat="server" OnClick="ButtonCreateRider_Click" Text="Create Rider Page" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonEditRider" runat="server" Text="Edit Rider" OnClick="ButtonEditRider_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonEditStaff" runat="server" Text="Edit Staff" />
        <br />
        <br />
        <asp:Button ID="ButtonSave" runat="server" OnClick="ButtonSave_Click" Text="Save" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonLoad" runat="server" OnClick="ButtonLoad_Click" Text="Load" />

        <br />
        <br />
        <br />
        <asp:Label ID="LabelLogin" runat="server" Text="You are at level 0"></asp:Label>
        <br />
        <asp:TextBox ID="TextBoxPassword" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
        <br />
        <br />
        <asp:Button ID="ButtonLogin" runat="server" OnClick="ButtonLogin_Click" Text="Login" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonLogout" runat="server" OnClick="ButtonLogout_Click" Text="Logout" />

    </div>
    </form>
</body>
</html>
