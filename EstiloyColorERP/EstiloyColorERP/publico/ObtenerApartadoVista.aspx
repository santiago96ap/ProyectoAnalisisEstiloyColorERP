<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ObtenerApartadoVista.aspx.cs" Inherits="EstiloyColorERP.publico.ObtenerApartadoView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <ContentTemplate>
            <br />
            <br />
            <asp:Label ID="lblITitulo" CssClass="col-sm-2 control-label" runat="server" Text="Obtener Apartados"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Label ID="lblCliente" CssClass="col-sm-2 control-label" runat="server" Text="Cliente"></asp:Label>
            <asp:TextBox ID="tbCliente" CssClass="form-control1" runat="server"></asp:TextBox>
            <asp:Button ID="btnBuscar" CssClass="btn btn-info" runat="server" Text="Buscar" />
            <br />
            <br />
            <asp:Table ID="tblProducto" CssClass="table table-hover" runat="server">
            </asp:Table>
            <br />
            <br />
            <br />
        </ContentTemplate>
</asp:Content>
