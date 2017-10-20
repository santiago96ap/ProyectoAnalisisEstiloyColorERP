<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EliminarIngresosView.aspx.cs" Inherits="EstiloyColorERP.publico.EliminarGastoView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    <ContentTemplate>
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="lblTitulo" runat="server" Text="Eliminar Ingresos"></asp:Label>
    <br />
    <br />&nbsp;&nbsp;
            <asp:TextBox ID="tbFechaInicio" runat="server">Fecha de Inicio</asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tbFechaFin" runat="server">Fecha Fin</asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnBuscar" runat="server" Text="Buscar" Width="74px" />
    <br />
    <br />
    <br />
    <asp:Table ID="tbResultados" runat="server" Width="407px">
    </asp:Table>
    <br />
    <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" Width="74px" />
    <br />
    </ContentTemplate>



</asp:Content>
