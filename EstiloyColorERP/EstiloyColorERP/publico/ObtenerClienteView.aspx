<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ObtenerClienteView.aspx.cs" Inherits="EstiloyColorERP.ObtenerCliente" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <ContentTemplate>
            <br />
            <br />
            <asp:Label ID="lblTitulo" CssClass="col-sm-2 control-label" runat="server" Text="Obtener Cliente"></asp:Label>
            <br />
            <br />
            <br />
            <asp:ListBox ID="lbBuscar" CssClass="form-control1" runat="server"></asp:ListBox>
            <asp:TextBox ID="tbBuscar" CssClass="form-control1" runat="server"></asp:TextBox>
            <asp:Button ID="btnBuscar" CssClass="btn btn-info" runat="server" Text="Buscar" />
            <br />
            <br />
            <asp:Table ID="tblCliente" CssClass="table table-hover" runat="server" Height="25px">
            </asp:Table>
            <br />
            <br />
            <br />
        </ContentTemplate>
</asp:Content>
