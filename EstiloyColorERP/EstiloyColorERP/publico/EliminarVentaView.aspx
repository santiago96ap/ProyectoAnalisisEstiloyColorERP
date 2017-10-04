<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EliminarVentaView.aspx.cs" Inherits="EstiloyColorERP.EliminarAgendaView" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <ContentTemplate>
            <br />
            <asp:Label ID="lblTituloVenta" runat="server" Text="Eliminar Venta"></asp:Label>
            <br />
            <br />
            &nbsp;&nbsp;
            <asp:TextBox ID="tbDatos" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:CheckBox ID="cbVendedor" runat="server" Text="Vendedor" />
            &nbsp;&nbsp;
            <asp:CheckBox ID="cbCliente" runat="server" Text="Telefono de cliente" />
            &nbsp;&nbsp;
            <asp:CheckBox ID="cbFactura" runat="server" Text="Factura" />
            <br />
            <br />
            &nbsp;&nbsp;
            <asp:TextBox ID="tbFechaInicio" runat="server">Fecha de Inicio</asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tbFechaFin" runat="server">Fecha Fin</asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnBuscar" runat="server" Text="Buscar" />
            <br />
            <br />
            <br />
            <asp:Table ID="tbResultadosVenta" runat="server" Width="368px">
            </asp:Table>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnEliminarVenta" runat="server" Text="Eliminar" />
            <br />
            <br />
            <br />
            <br />
            <br />
        </ContentTemplate>
</asp:Content>
