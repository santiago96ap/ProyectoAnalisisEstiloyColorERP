<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InsertarClienteView.aspx.cs" Inherits="EstiloyColorERP.InsertarCliente" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <ContentTemplate>
            <br />
            <br />
            <asp:Label ID="lblTitulo" CssClass="col-sm-2 control-label" runat="server" Text="Insertar Cliente"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Label ID="lblNombre" CssClass="col-sm-2 control-label" runat="server" Text="Nombre"></asp:Label>
            <asp:TextBox ID="tbNombre" CssClass="form-control1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblApellidos" CssClass="col-sm-2 control-label" runat="server" Text="Apellidos"></asp:Label>
            <asp:TextBox ID="tbApellidos" CssClass="form-control1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblTelefono" CssClass="col-sm-2 control-label" runat="server" Text="Teléfono"></asp:Label>
            <asp:TextBox ID="tbTelefono" CssClass="form-control1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblDireccion" CssClass="col-sm-2 control-label" runat="server" Text="Dirección"></asp:Label>
            <asp:TextBox ID="tbDireccion" CssClass="form-control1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblCorreo" CssClass="col-sm-2 control-label" runat="server" Text="Correo"></asp:Label>
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
