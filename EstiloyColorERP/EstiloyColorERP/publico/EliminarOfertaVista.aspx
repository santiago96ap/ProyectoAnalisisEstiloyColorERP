<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EliminarOfertaVista.aspx.cs" Inherits="EstiloyColorERP.EliminarOferta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    <ContentTemplate>
    <br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="lblTitulo" runat="server" Text="Eliminar Oferta"></asp:Label>
    <br />
    <br />&nbsp;&nbsp;
            <asp:TextBox ID="tbProducto" runat="server">Producto</asp:TextBox>
    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" Width="74px" />
    <br />
    <br />
    <asp:Table ID="tbResultados" runat="server" Width="407px">
    </asp:Table>
    <br />
    <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" Width="74px" />
    <br />
    </ContentTemplate>



</asp:Content>
