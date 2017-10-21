<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VentaView.aspx.cs" Inherits="EstiloyColorERP.VentaView" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <ContentTemplate>
            <br />
&nbsp;<asp:Label ID="titulo" CssClass="col-sm-2 control-label" runat="server" Text="Insertar Venta"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblFecha" CssClass="col-sm-2 control-label" runat="server" Text="Fecha"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tbFecha"  CssClass="form-control1" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="lblHora" runat="server" Text="Hora"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tbHora" CssClass="form-control1" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblArticulos"  CssClass="col-sm-2 control-label" runat="server" Text="Articulos"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tbArticulos" CssClass="form-control1" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblCategoria" runat="server" Text="Categoria"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;<asp:ListBox ID="lbCategoria" runat="server" Height="27px" Width="112px"></asp:ListBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnAgregar" CssClass="btn btn-info" runat="server" Text="Agregar" />
            <br />
            <br />
            <asp:Table ID="tbInsertarProducto"  CssClass="table table-hover" runat="server" Width="640px">
            </asp:Table>
            <asp:Label ID="lblTelefono" CssClass="col-sm-2 control-label" runat="server" Text="Numero deTelefono"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tbTelefono" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblTipoServicio" runat="server" Text="Tipo de servicio"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ListBox ID="lbTipoServicio"  CssClass="form-control1" runat="server" Height="26px" Width="103px"></asp:ListBox>
            <br />
            <br />
            <asp:Label ID="lblTipoPago"  CssClass="col-sm-2 control-label" runat="server" Text="Tipo de Pago"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ListBox ID="lbTipoPago"  CssClass="form-control1" runat="server" Height="24px" Width="114px"></asp:ListBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblVendedor" runat="server" Text="Vendedor"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tbVendedor" CssClass="form-control1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblSubTotal" CssClass="col-sm-2 control-label" runat="server" Text="Sub total"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tbSubtotal" CssClass="form-control1" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblTotal" CssClass="col-sm-2 control-label" runat="server" Text="Total"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tbTotal" CssClass="form-control1" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnInsertar" CssClass="btn btn-info" runat="server" Text="Insertar" />
            <br />
            <br />
        </ContentTemplate>
</asp:Content>
