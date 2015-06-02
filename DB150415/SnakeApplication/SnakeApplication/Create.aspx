<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="SnakeApplication.Create" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Create</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="RequiredFieldValidator" EnableClientScript="False" ForeColor="Red">Name missing</asp:RequiredFieldValidator>
&nbsp;
        <asp:Label ID="Label1" runat="server" Text="Name of owner"></asp:Label>
        <br />
        <br />

        <asp:Label ID="Label3" runat="server" Text="Another TextBox for owner id, if not automatic (identity)."></asp:Label>
        <br />

        <br />
        <asp:Label ID="Label2" runat="server" Text="Messages"></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Create" OnClick="Button1_Click" />
    
    </div>
    </form>
</body>
</html>
