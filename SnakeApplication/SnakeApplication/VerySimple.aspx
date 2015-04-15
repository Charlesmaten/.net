<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VerySimple.aspx.cs" Inherits="SnakeApplication.VerySimple" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="SnakeID" DataSourceID="SqlDataSource1" EmptyDataText="There are no data records to display." ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="SnakeID" HeaderText="SnakeID" ReadOnly="True" SortExpression="SnakeID" />
                <asp:BoundField DataField="Type" HeaderText="Type" SortExpression="Type" />
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                <asp:BoundField DataField="Length" HeaderText="Length" SortExpression="Length" />
                <asp:BoundField DataField="Owner" HeaderText="Owner" SortExpression="Owner" />
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SnakesConnectionString1 %>" DeleteCommand="DELETE FROM [Snake] WHERE [SnakeID] = @SnakeID" InsertCommand="INSERT INTO [Snake] ([SnakeID], [Type], [Name], [Length], [Owner]) VALUES (@SnakeID, @Type, @Name, @Length, @Owner)" ProviderName="<%$ ConnectionStrings:SnakesConnectionString1.ProviderName %>" SelectCommand="SELECT [SnakeID], [Type], [Name], [Length], [Owner] FROM [Snake]" UpdateCommand="UPDATE [Snake] SET [Type] = @Type, [Name] = @Name, [Length] = @Length, [Owner] = @Owner WHERE [SnakeID] = @SnakeID">
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
        <asp:GridView ID="GridView2" runat="server" AllowSorting="True" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" DataKeyNames="OwnerID" DataSourceID="SqlDataSource2" EmptyDataText="There are no data records to display." OnSelectedIndexChanged="GridView2_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="OwnerID" HeaderText="OwnerID" ReadOnly="True" SortExpression="OwnerID" />
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
            </Columns>
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FFF1D4" />
            <SortedAscendingHeaderStyle BackColor="#B95C30" />
            <SortedDescendingCellStyle BackColor="#F1E5CE" />
            <SortedDescendingHeaderStyle BackColor="#93451F" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:SnakesConnectionString1 %>" DeleteCommand="DELETE FROM [Owner] WHERE [OwnerID] = @OwnerID" InsertCommand="INSERT INTO [Owner] ([OwnerID], [Name]) VALUES (@OwnerID, @Name)" ProviderName="<%$ ConnectionStrings:SnakesConnectionString1.ProviderName %>" SelectCommand="SELECT [OwnerID], [Name] FROM [Owner]" UpdateCommand="UPDATE [Owner] SET [Name] = @Name WHERE [OwnerID] = @OwnerID">
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
