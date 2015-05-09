<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="CS4Services.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="bootstrap.min.css" />
    <title></title>
</head>
<body style="background-color: bisque">
    <form id="form1" runat="server">
    <div>
    
        <br />
        Enter ONLY Numbers:<br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Number 1"></asp:Label>
        <br />
        <asp:TextBox ID="TextBoxNumber1" runat="server" CssClass="btn-warning"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Total" CssClass="btn-success" />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Number 2"></asp:Label>
        <br />
        <asp:TextBox ID="TextBoxNumber2" runat="server" CssClass="btn-warning"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Average" CssClass="btn-success" />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Number 3"></asp:Label>
        <br />
        <asp:TextBox ID="TextBoxNumber3" runat="server" CssClass="btn-warning"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" Text="Sort" OnClick="Button3_Click" CssClass="btn-success" />
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Output"></asp:Label>
        <br />
        <asp:TextBox ID="TextBoxTotalShow" runat="server" ReadOnly="True" CssClass="btn-danger"></asp:TextBox>
    
        <br />
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Enter Name"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox1" runat="server" CssClass="btn-warning"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonName" runat="server" Text="Get alias" CssClass="btn-success" OnClick="ButtonName_Click" />
        <br />
        <br />
        <asp:ListBox ID="ListBox1" runat="server" Height="189px" Width="488px"></asp:ListBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    
    </div>
    </form>
</body>
</html>
