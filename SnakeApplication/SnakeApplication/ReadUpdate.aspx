<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReadUpdate.aspx.cs" Inherits="SnakeApplication.ReadUpdate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
        <br />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Select an owner"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label3" runat="server" Text="OwnerId"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label4" runat="server" Text="Name"></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Update" />
    
    </div>
    </form>
</body>
</html>
