<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateFish.aspx.cs" Inherits="FishApplication.CreateFish" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Create fish</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="LabelMessage" runat="server" Text="Message"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="TextBoxType" runat="server"></asp:TextBox>
&nbsp;
        <asp:Label ID="LabelType" runat="server" Text="Type"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="TextBoxLength" runat="server"></asp:TextBox>
&nbsp;
        <asp:Label ID="LabelLength" runat="server" Text="Length"></asp:Label>
        <br />
        <br />
        <asp:Button ID="ButtonCreate" runat="server" OnClick="ButtonCreate_Click" Text="Create" />
    
    </div>
    </form>
</body>
</html>
