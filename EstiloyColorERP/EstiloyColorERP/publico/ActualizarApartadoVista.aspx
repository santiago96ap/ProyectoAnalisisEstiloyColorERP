<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ActualizarApartadoVista.aspx.cs" Inherits="EstiloyColorERP.ActualizarApartadoView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <ContentTemplate>
            <br />
            <br />
            <asp:Label ID="lblITitulo" CssClass="col-sm-2 control-label" runat="server" Text="Actualizar Apartado"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Label ID="lblCliente" CssClass="col-sm-2 control-label" runat="server" Text="Cliente:"></asp:Label>
            <asp:TextBox ID="tbCliente" CssClass="form-control1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Table ID="tblProducto" CssClass="table table-hover" runat="server">
            </asp:Table>
            <br />
            <br />
            <section id="formulario">
                <div id="divi">
                    <asp:Label ID="lblAbono" CssClass="col-sm-2 control-label" runat="server" Text="Abono:"></asp:Label>
                    <asp:TextBox ID="tbAbono" CssClass="form-control1" runat="server"></asp:TextBox>
                </div>
                <div id="divi1">
                    <asp:Label ID="lblSaldo" CssClass="col-sm-2 control-label" runat="server" Text="Saldo:"></asp:Label>
                    <asp:TextBox ID="tbSaldo" CssClass="form-control1" runat="server"></asp:TextBox>
                </div>
            </section>
            <br />
            <br />
            <br />
            <asp:Button ID="btnActualizar" CssClass="btn btn-info" runat="server" Text="Actualizar" />
            <br />
            <br />
            <br />
        </ContentTemplate>
</asp:Content>
