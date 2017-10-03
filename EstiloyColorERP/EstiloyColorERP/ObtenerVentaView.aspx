<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ObtenerVentaView.aspx.cs" Inherits="EstiloyColorERP.ObtenerVentaView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:Label ID="lblTitulo" runat="server" Text="Obtener Ventas"></asp:Label>
            <br />
            <br />
            &nbsp;&nbsp;
            <asp:TextBox ID="tbDatos" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:CheckBox ID="cbVendedor" runat="server" Text="Vendedor" />
            &nbsp;&nbsp;&nbsp;
            <asp:CheckBox ID="cbCliente" runat="server" Text="Telefono de cliente" />
            &nbsp;&nbsp;&nbsp;
            <asp:CheckBox ID="cbFactura" runat="server" Text="Factura" />
            <br />
            <br />
            <br />
            &nbsp;&nbsp;
            <asp:TextBox ID="tbFechaInicio" runat="server">Fecha de Inicio</asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tbFechaFin" runat="server">Fecha Fin</asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnBuscar" runat="server" Text="Buscar" />
            <br />
            <br />
            <br />
            <asp:Table ID="tbResultados" runat="server" Width="407px">
            </asp:Table>
            <br />
            <br />
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
