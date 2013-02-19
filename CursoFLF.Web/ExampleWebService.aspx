<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ExampleWebService.aspx.cs" Inherits="CursoFLF.Web.ExampleWebService" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Valor 1:"></asp:Label>
    <asp:TextBox ID="txtValor1" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label2" runat="server" Text="Valor 2:"></asp:Label>
    <asp:TextBox ID="txtValor2" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="btnCalcular" runat="server" Text="Calcular" OnClick="btnCalcular_Click" />
    <br/>
    <asp:Label ID="lblresultado" runat="server"></asp:Label>
</asp:Content>
