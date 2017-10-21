<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InsertarApartadoView.aspx.cs" Inherits="EstiloyColorERP.publico.InsertarApartadoView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <ContentTemplate>
            <br />
            <br />
            <asp:Label ID="lblITitulo" CssClass="col-sm-2 control-label" runat="server" Text="Insertar Apartado"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Label ID="lblCliente" CssClass="col-sm-2 control-label" runat="server" Text="Cliente"></asp:Label>
            <asp:TextBox ID="tbCliente" CssClass="form-control1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblProducto" CssClass="col-sm-2 control-label" runat="server" Text="Producto"></asp:Label>
            <asp:TextBox ID="tbProducto" CssClass="form-control1" runat="server"></asp:TextBox>
            <asp:Label ID="lblCategoria" CssClass="col-sm-2 control-label" runat="server" Text="Categoría"></asp:Label>
            <asp:ListBox ID="lbCategoria" CssClass="form-control1" runat="server"></asp:ListBox>
            <br />
            <br />
            <asp:Table ID="tblProducto" CssClass="table table-hover" runat="server">
            </asp:Table>
            <br />
            <br />
            <asp:Label ID="lblMonto" CssClass="col-sm-2 control-label" runat="server" Text="Monto"></asp:Label>
            <asp:TextBox ID="tbMonto" CssClass="form-control1" runat="server"></asp:TextBox>
            <asp:Label ID="lblAbono" CssClass="col-sm-2 control-label" runat="server" Text="Abono"></asp:Label>
            <asp:TextBox ID="tbAbono" CssClass="form-control1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblFechaInicio" CssClass="col-sm-2 control-label" runat="server" Text="Fecha inicio"></asp:Label>
            <asp:TextBox ID="tbTelefono" CssClass="form-control1" runat="server"></asp:TextBox>
            <asp:Label ID="lblFechaFinal" CssClass="col-sm-2 control-label" runat="server" Text="Fecha final"></asp:Label>
            <asp:TextBox ID="tbCorreo" CssClass="form-control1" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="btnInsertar" CssClass="btn btn-info" runat="server" Text="Insertar" />
            <br />
            <br />
            <br />
        </ContentTemplate>
</asp:Content>
