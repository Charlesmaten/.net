<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Exercise4_3.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
        Firstname<br />
        <br />
        <asp:DropDownList ID="DropDownList2" runat="server">
        </asp:DropDownList>
        Secondname<br />
        <br />
        <asp:Button ID="ButtonEvaluate" runat="server" OnClick="ButtonEvaluate_Click" Text="Evaluate" />
        <br />
        <br />
        <asp:Label ID="LabelEvaluate" runat="server" Text="Evaluatetion"></asp:Label>
    
    </div>
    </form>
</body>
</html>
