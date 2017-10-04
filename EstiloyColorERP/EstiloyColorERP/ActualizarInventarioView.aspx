<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ActualizarInventarioView.aspx.cs" Inherits="EstiloyColorERP.ActualizarInventarioView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Actualizar Inventario</p>
    <p>
    </p>
    <p>
        &nbsp;</p>
    <p style="margin-left: 80px">
        Producto</p>
    <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 78px" Width="190px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Cantidad<asp:TextBox ID="TextBox2" runat="server" style="margin-left: 30px" Width="49px"></asp:TextBox>
    <p>
        <asp:Button ID="Button1" runat="server" style="margin-left: 122px" Text="Buscar" Width="92px" />
        <asp:Button ID="Button2" runat="server" style="margin-left: 301px" Text="Actualizar" />
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>
