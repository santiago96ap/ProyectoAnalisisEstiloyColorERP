<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InsertarApartadoVista.aspx.cs" Inherits="EstiloyColorERP.publico.InsertarApartadoView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <ContentTemplate>
        <section id="formulario">
            <br />
            <br />
            <asp:Label ID="lblITitulo" CssClass="agileits-title" runat="server" Text="Insertar Apartado"></asp:Label>
            <br />
            <br />
            <br />
            <div id="divi2">
            <asp:Label ID="lblCliente" CssClass="col-sm-2 control-label" runat="server" Text="Cliente"></asp:Label>
            <asp:TextBox ID="tbCliente" CssClass="form-control1" runat="server"></asp:TextBox>
            <br />
            <br />
                </div>
            <section id="formulario3">
                <div id= "divi">
                    <asp:Label ID="lblProducto" CssClass="col-sm-2 control-label" runat="server" Text="Producto"></asp:Label>
                    <asp:TextBox ID="tbProducto" CssClass="form-control1" runat="server"></asp:TextBox>
                </div>
                <div id= "divi6">
                <br />
            <br />
                    <asp:Label ID="lblCategoria" CssClass="col-sm-2 control-label" runat="server" Text="Categoría"></asp:Label>
                    <asp:dropdownlist ID="ddlCategoria" CssClass="from-dropdownlist" runat="server"></asp:dropdownlist>
                </div>
                </section>
            <br />
            <br />
            <br />
            <br />
            <section id="formulario1">
                <div id="divi1">
                    <asp:Label ID="lblMonto" CssClass="col-sm-2 control-label" runat="server" Text="Monto"></asp:Label>
                    <asp:TextBox ID="tbMonto" CssClass="form-control1" runat="server"></asp:TextBox>
                </div>
                <div id="divi3">
                    <asp:Label ID="lblAbono" CssClass="col-sm-2 control-label" runat="server" Text="Abono"></asp:Label>
                    <asp:TextBox ID="tbAbono" CssClass="form-control1" runat="server"></asp:TextBox>
                </div>
            </section>
            <br />
            <br />
            <section id="formulario2">
                <div id="divi4">
                    <asp:Label ID="lblFechaInicio" CssClass="col-sm-2 control-label" runat="server" Text="F. Inicio"></asp:Label>
                    <asp:TextBox ID="tbTelefono" CssClass="form-control1" runat="server"></asp:TextBox>
                </div>
                <div id="divi5">
                     <asp:Label ID="lblFechaFinal" CssClass="col-sm-2 control-label" runat="server" Text="F. Final"></asp:Label>
                    <asp:TextBox ID="tbCorreo" CssClass="form-control1" runat="server"></asp:TextBox>
                </div>
            </section>
            <br />
            <br />
            <br />
            <asp:Button ID="btnInsertar" CssClass="btn btn-info" runat="server" Text="Insertar"/>
            <br />
            <br />
            <br />
            </section>
        </ContentTemplate>
</asp:Content>
