<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ObtenerClienteView.aspx.cs" Inherits="EstiloyColorERP.ObtenerCliente" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <ContentTemplate>
            <section id="formulario1">
                <br />
                <br />
                <asp:Label ID="lblTitulo" CssClass="agileits-icons-title" runat="server" Text="Obtener Cliente"></asp:Label>
                <br />
                <br />
                <br />
                <div id="divi10">
                    <asp:dropdownlist ID="ddlBuscar" CssClass="form-dropdownlist" runat="server"></asp:dropdownlist>
                    <asp:TextBox ID="tbBuscar" CssClass="form-control1" runat="server"></asp:TextBox>
                    <asp:Button ID="btnBuscar" CssClass="btn btn-info" runat="server" Text="Buscar" />
                    <br />
                    <br />
                    <asp:GridView ID="gvClientes" CssClass="table table-hover" runat="server"> </asp:GridView>
                    <br />
                    <br />
                    <br />
                </div>
            </section>
        </ContentTemplate>
</asp:Content>
