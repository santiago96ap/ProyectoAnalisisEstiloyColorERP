<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VentaView.aspx.cs" Inherits="EstiloyColorERP.VentaView" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <ContentTemplate>
            <br />
&nbsp;<asp:Label ID="titulo" runat="server" Text="Insertar Venta"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblFecha" runat="server" Text="Fecha"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tbFecha" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="lblHora" runat="server" Text="Hora"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tbHora" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblArticulos" runat="server" Text="Articulos"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tbArticulos" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblCategoria" runat="server" Text="Categoria"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;<asp:ListBox ID="lbCategoria" runat="server" Height="27px" Width="112px"></asp:ListBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnAgregar" runat="server" Text="Agregar" />
            <br />
            <br />
            <asp:Table ID="tbInsertarProducto" runat="server" Width="640px">
            </asp:Table>
            <asp:Label ID="lblTelefono" runat="server" Text="Numero deTelefono"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tbTelefono" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblTipoServicio" runat="server" Text="Tipo de servicio"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ListBox ID="lbTipoServicio" runat="server" Height="26px" Width="103px"></asp:ListBox>
            <br />
            <br />
            <asp:Label ID="lblTipoPago" runat="server" Text="Tipo de Pago"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ListBox ID="lbTipoPago" runat="server" Height="24px" Width="114px"></asp:ListBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblVendedor" runat="server" Text="Vendedor"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tbVendedor" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblSubTotal" runat="server" Text="Sub total"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tbSubtotal" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblTotal" runat="server" Text="Total"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tbTotal" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnInsertar" runat="server" Text="Insertar" />
            <br />
            <br />
        </ContentTemplate>
</asp:Content>
