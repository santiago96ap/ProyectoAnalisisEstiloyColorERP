<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ObtenerVentaVista.aspx.cs" Inherits="EstiloyColorERP.ObtenerVentaView" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <ContentTemplate>
            <br />
            <asp:Label ID="lblTitulo" CssClass="col-sm-2 control-label" runat="server" Text="Obtener Ventas"></asp:Label>
            <br />
            <br />
            &nbsp;&nbsp;
            <asp:TextBox ID="tbDatos" CssClass="form-control1" runat="server"></asp:TextBox>
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
            <asp:TextBox ID="tbFechaInicio" CssClass="form-control1" runat="server">Fecha de Inicio</asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tbFechaFin" CssClass="form-control1" runat="server">Fecha Fin</asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnBuscar" CssClass="btn btn-info" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
            <br />
            <br />
            <br />
            <asp:Table ID="tbResultados" CssClass="table table-hover" runat="server" Width="407px">
            </asp:Table>
            <br />
            <br />
        </ContentTemplate>
</asp:Content>
