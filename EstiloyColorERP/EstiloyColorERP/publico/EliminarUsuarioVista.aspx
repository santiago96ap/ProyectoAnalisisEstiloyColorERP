<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EliminarUsuarioVista.aspx.cs" Inherits="EstiloyColorERP.publico.Eliminar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    <ContentTemplate>
    <br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="lblTitulo" runat="server" Text="Eliminar Usuarios"></asp:Label>
    <br />
    <br />&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tbRol" runat="server">Rol</asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnBuscar" runat="server" Text="Buscar" />
    <br />
    <br />
    <asp:Table ID="tbResultados" runat="server" Width="407px">
    </asp:Table>
    <br />
    <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" />
    </ContentTemplate>



</asp:Content>
