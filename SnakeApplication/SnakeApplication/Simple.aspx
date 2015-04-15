<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Simple.aspx.cs" Inherits="SnakeApplication.Simple" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Simple</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="SnakeID" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:CommandField ShowEditButton="True" />
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                <asp:BoundField DataField="Owner" HeaderText="Owner" SortExpression="Owner" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SnakesConnectionString1 %>" DeleteCommand="DELETE FROM [Snake] WHERE [SnakeID] = @SnakeID" InsertCommand="INSERT INTO [Snake] ([SnakeID], [Type], [Name], [Length], [Owner]) VALUES (@SnakeID, @Type, @Name, @Length, @Owner)" SelectCommand="SELECT * FROM [Snake]" UpdateCommand="UPDATE [Snake] SET [Type] = @Type, [Name] = @Name, [Length] = @Length, [Owner] = @Owner WHERE [SnakeID] = @SnakeID">
            <DeleteParameters>
                <asp:Parameter Name="SnakeID" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="SnakeID" Type="Int32" />
                <asp:Parameter Name="Type" Type="String" />
                <asp:Parameter Name="Name" Type="String" />
                <asp:Parameter Name="Length" Type="Double" />
                <asp:Parameter Name="Owner" Type="Int32" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Type" Type="String" />
                <asp:Parameter Name="Name" Type="String" />
                <asp:Parameter Name="Length" Type="Double" />
                <asp:Parameter Name="Owner" Type="Int32" />
                <asp:Parameter Name="SnakeID" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <br />
        <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" DataKeyNames="OwnerID" DataSourceID="SqlDataSource2" Height="50px" Width="125px">
            <Fields>
                <asp:BoundField DataField="OwnerID" HeaderText="OwnerID" ReadOnly="True" SortExpression="OwnerID" />
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                <asp:CommandField ShowInsertButton="True" />
            </Fields>
        </asp:DetailsView>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:SnakesConnectionString1 %>" DeleteCommand="DELETE FROM [Owner] WHERE [OwnerID] = @OwnerID" InsertCommand="INSERT INTO [Owner] ([OwnerID], [Name]) VALUES (@OwnerID, @Name)" SelectCommand="SELECT * FROM [Owner]" UpdateCommand="UPDATE [Owner] SET [Name] = @Name WHERE [OwnerID] = @OwnerID">
            <DeleteParameters>
                <asp:Parameter Name="OwnerID" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="OwnerID" Type="Int32" />
                <asp:Parameter Name="Name" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Name" Type="String" />
                <asp:Parameter Name="OwnerID" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <br />
    
    </div>
    </form>
</body>
</html>
