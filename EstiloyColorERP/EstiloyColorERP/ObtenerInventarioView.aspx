<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ObtenerInventarioView.aspx.cs" Inherits="EstiloyColorERP.ObtenerInventarioView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
    </p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Obtener Inventario<p>
        <asp:TextBox ID="TextBoxObtenerInventario" runat="server" style="margin-left: 55px" Width="147px"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" style="margin-left: 30px" Text="Buscar" Width="76px" />
    </p>
    <p>
    </p>
    <asp:Table ID="tblObtInventario" runat="server" Height="107px" Width="441px">
    </asp:Table>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>
