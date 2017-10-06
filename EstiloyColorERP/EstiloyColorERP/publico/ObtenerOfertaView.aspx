<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ObtenerOfertaView.aspx.cs" Inherits="EstiloyColorERP.ObtenerOferta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    <ContentTemplate>
    <br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="lblTitulo" runat="server" Text="Obtener Ofertas"></asp:Label>
    <br />
    <br />&nbsp;&nbsp;
            <asp:TextBox ID="tbProducto" runat="server">Producto</asp:TextBox>
    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" Width="74px" />
    <br />
    <br />
    <asp:Table ID="tbResultados" runat="server" Width="407px">
    </asp:Table>
    <br />
    </ContentTemplate>



</asp:Content>
