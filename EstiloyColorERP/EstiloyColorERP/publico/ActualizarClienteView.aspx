<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ActualizarClienteView.aspx.cs" Inherits="EstiloyColorERP.ActualizarCliente" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <ContentTemplate>
            <section id="formulario1">
                <br />
                <br />
                <asp:Label ID="lblTitulo" CssClass="agileits-title" runat="server" Text="Actualizar Cliente"></asp:Label>
                <br />
                <br />
                <br />
                <section id="formulario">
                    <div id="divi">
                        <asp:TextBox ID="tbBuscar" CssClass="form-control1" runat="server"></asp:TextBox>
                        <br />
                        <br />
                        <asp:dropdownlist ID="ddlClientes" CssClass="form-dropdownlist" runat="server"></asp:dropdownlist>
                        <br />
                        <br />
                        <asp:Button ID="btnBuscar" CssClass="btn btn-info" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
                        <br />
                        <br />
                    </div>
                    <div id="divi1">
                        <asp:Label ID="lblNombre" CssClass="col-sm-2 control-label" runat="server" Text="Nombre"></asp:Label>
                        <asp:TextBox ID="tbNombre" CssClass="form-control1" runat="server"></asp:TextBox>
                        <br />
                        <br />
                        <asp:Label ID="lblApellidos" CssClass="col-sm-2 control-label" runat="server" Text="Apellidos"></asp:Label>
                        <asp:TextBox ID="tbApellidos" CssClass="form-control1" runat="server"></asp:TextBox>
                        <br />
                        <br />
                        <asp:Label ID="lblTelefono" CssClass="col-sm-2 control-label" runat="server" Text="Teléfono"></asp:Label>
                        <asp:TextBox ID="tbTelefono" CssClass="form-control1" runat="server" Enabled="false"></asp:TextBox>
                        <br />
                        <br />
                        <asp:Label ID="lblDireccion" CssClass="col-sm-2 control-label" runat="server" Text="Dirección"></asp:Label>
                        <asp:TextBox ID="tbDireccion" CssClass="form-control1" runat="server"></asp:TextBox>
                        <br />
                        <br />
                        <asp:Label ID="lblCorreo" CssClass="col-sm-2 control-label" runat="server" Text="Correo"></asp:Label>
                        <asp:TextBox ID="tbCorreo" CssClass="form-control1" runat="server"></asp:TextBox>
                    </div>
                </section>
                <br />
                <br />
                <br />
                <asp:Button ID="btnInsertar" CssClass="btn btn-info" runat="server" Text="Actualizar" OnClick="btnInsertar_Click" />
                <br />
                <br />
                <br />
            </section>
        </ContentTemplate>
</asp:Content>
