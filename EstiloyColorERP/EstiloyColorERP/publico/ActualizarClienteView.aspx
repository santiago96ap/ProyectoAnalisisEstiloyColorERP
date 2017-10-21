<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ActualizarClienteView.aspx.cs" Inherits="EstiloyColorERP.ActualizarCliente" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <ContentTemplate>
            <br />
            <br />
            <asp:Label ID="lblTitulo" CssClass="col-sm-2 control-label" runat="server" Text="Actualizar Cliente"></asp:Label>
            <br />
            <br />
            <br />
            <div class="col-sm-5 col-sm-offset-1">
                <asp:TextBox ID="tbBuscar" CssClass="form-control1" runat="server" Width="38%"></asp:TextBox>
                <br />
                <br />
                <asp:ListBox ID="lbBuscar" CssClass="form-control1" runat="server" Width="38%"></asp:ListBox>
                <br />
                <br />
                <asp:Button ID="btnBuscar" CssClass="btn btn-info" runat="server" Text="Buscar" />
                <br />
                <br />
            </div>
            <div class="col-sm-5">
                <asp:Label ID="lblNombre" CssClass="col-sm-2 control-label" runat="server" Text="Nombre"></asp:Label>
                <asp:TextBox ID="tbNombre" CssClass="form-control1" runat="server" Width="38%"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="lblApellidos" CssClass="col-sm-2 control-label" runat="server" Text="Apellidos"></asp:Label>
                <asp:TextBox ID="tbApellidos" CssClass="form-control1" runat="server" Width="38%"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="lblTelefono" CssClass="col-sm-2 control-label" runat="server" Text="Teléfono"></asp:Label>
                <asp:TextBox ID="tbTelefono" CssClass="form-control1" runat="server" Width="38%"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="lblDireccion" CssClass="col-sm-2 control-label" runat="server" Text="Dirección"></asp:Label>
                <asp:TextBox ID="tbDireccion" CssClass="form-control1" runat="server" Width="38%"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="lblCorreo" CssClass="col-sm-2 control-label" runat="server" Text="Correo"></asp:Label>
                <asp:TextBox ID="tbCorreo" CssClass="form-control1" runat="server" Width="38%"></asp:TextBox>
            </div>
            <br />
            <br />
            <br />
            <asp:Button ID="btnInsertar" CssClass="btn btn-info" runat="server" Text="Actualizar" />
            <br />
            <br />
            <br />
        </ContentTemplate>
</asp:Content>
