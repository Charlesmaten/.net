<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="ControlExamples.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div id="LabelText">
    
        <asp:Label ID="LabelText" runat="server" Text="Examples"></asp:Label>
        <br />
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="150px">
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList2" runat="server" Width="150px">
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" ReadOnly="True" Width="330px"></asp:TextBox>
    
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="ListBox example"></asp:Label>
        <br />
        <asp:TextBox ID="TextBoxItem" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add item to listbox" />
        <br />
        <asp:ListBox ID="ListBox1" runat="server" SelectionMode="Multiple"></asp:ListBox>
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Show Selected Items" />
        <br />
        <br />
        <asp:TextBox ID="TextBoxShow" runat="server" TextMode="MultiLine"></asp:TextBox>
    
    </div>
    </form>
</body>
</html>
