<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ObtenerGastoView.aspx.cs" Inherits="EstiloyColorERP.publico.ObtenerGastoView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    

    <ContentTemplate>
    <br />
    <asp:Label ID="lblTitulo" runat="server" Text="Obtener Gastos"></asp:Label>
    <br />
    <br />&nbsp;&nbsp;
            <asp:TextBox ID="tbFechaInicio" runat="server">Fecha de Inicio</asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tbFechaFin" runat="server">Fecha Fin</asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnBuscar" runat="server" Text="Buscar" />
    
    <br />
    
    <br />
    <asp:Table ID="tbResultados" runat="server" Width="407px">
    </asp:Table>
    <br />
    </ContentTemplate>

    

</asp:Content>
