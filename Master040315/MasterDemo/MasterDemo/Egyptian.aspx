<!--ThemeEgyption henviser til mappen med stylesheets -->
<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Egyptian.aspx.cs" Inherits="MasterDemo.Egyptian" Theme="ThemeEgyptian" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--Tilføjer image med id image1 til billede kat5 -->
    <asp:Image ID="Image1" runat="server" ImageUrl="~/Pictures/kat5.jpg" />
    <br />
    <asp:Label ID="Label1" runat="server" Text="Egyptian mau"></asp:Label>
</asp:Content>
