<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EliminarInventarioView.aspx.cs" Inherits="EstiloyColorERP.EliminarInventarioView" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Eliminar Inventario</p>
    <p>
    </p>
    <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 55px" Width="169px"></asp:TextBox>
    <asp:Button ID="btnEliminarInventario" runat="server" style="margin-left: 26px" Text="Buscar" Width="79px" />
    <p>
    </p>
    <asp:Table ID="tblEliminarInventario" runat="server" Height="43px" style="margin-left: 56px" Width="215px">
    </asp:Table>
    <p>
        <asp:Button runat="server" style="margin-left: 49px" Text="Eliminar" Width="95px" />
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
