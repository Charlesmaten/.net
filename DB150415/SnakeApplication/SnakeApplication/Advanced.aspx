<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Advanced.aspx.cs" Inherits="SnakeApplication.Advanced" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Advanced</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="Owner">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SnakeDBConnectionString1 %>" SelectCommand="SELECT * FROM [Snake]"></asp:SqlDataSource>
        <br />
        <br />
        <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" DataKeyNames="OwnerID" DataSourceID="SqlDataSource2" Height="50px" Width="125px">
            <Fields>
                <asp:BoundField DataField="OwnerID" HeaderText="OwnerID" InsertVisible="False" ReadOnly="True" SortExpression="OwnerID" />
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
            </Fields>
        </asp:DetailsView>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:SnakeDBConnectionString1 %>" SelectCommand="SELECT * FROM [Owner] WHERE ([OwnerID] = @OwnerID)">
            <SelectParameters>
                <asp:ControlParameter ControlID="DropDownList1" Name="OwnerID" PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
