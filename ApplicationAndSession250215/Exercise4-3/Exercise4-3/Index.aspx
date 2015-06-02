<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Exercise4_3.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Exercise 4-3</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Text="1st name"></asp:Label>
        <br />
        <br />
        <asp:DropDownList ID="DropDownList2" runat="server">
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Text="2nd name"></asp:Label>
        <br />
        <br />
        <asp:Button ID="ButtonEvaluate" runat="server" OnClick="ButtonEvaluate_Click" Text="Evaluate" />
        <br />
        <br />
        <asp:Label ID="LabelEvaluate" runat="server" Text="Evaluation"></asp:Label>
    
    </div>
    </form>
</body>
</html>
