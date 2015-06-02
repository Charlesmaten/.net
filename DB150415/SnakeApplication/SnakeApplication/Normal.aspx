<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Normal.aspx.cs" Inherits="SnakeApplication.Normal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Normal</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="OwnerID" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="OwnerID" HeaderText="OwnerID" InsertVisible="False" ReadOnly="True" SortExpression="OwnerID" />
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SnakeDBConnectionString1 %>" SelectCommand="SELECT * FROM [Owner]"></asp:SqlDataSource>
        <br />
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="SnakeID" DataSourceID="SqlDataSource2" EmptyDataText="No snakes">
            <Columns>
                <asp:BoundField DataField="SnakeID" HeaderText="SnakeID" InsertVisible="False" ReadOnly="True" SortExpression="SnakeID" />
                <asp:BoundField DataField="Type" HeaderText="Type" SortExpression="Type" />
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                <asp:BoundField DataField="Length" HeaderText="Length" SortExpression="Length" />
                <asp:BoundField DataField="Owner" HeaderText="Owner" SortExpression="Owner" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:SnakeDBConnectionString1 %>" SelectCommand="SELECT * FROM [Snake] WHERE ([Owner] = @Owner)">
            <SelectParameters>
                <asp:ControlParameter ControlID="GridView1" Name="Owner" PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
