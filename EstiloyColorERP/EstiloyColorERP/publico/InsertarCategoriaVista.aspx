<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InsertarCategoriaVista.aspx.cs" Inherits="EstiloyColorERP.publico.InsertarCategoria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

       <contenttemplate>
    <br />
    <br />
        <section id="formulario">
            <div id="divi">
                <asp:Label ID="lblTitulo" CssClass="agileits-title" runat="server" Text="Insertar Categoría"></asp:Label>
                <br />
                <br />
                <asp:Label ID="LblNombre" CssClass="col-sm-2 control-label" runat="server" Text="Nombre"></asp:Label>
                <asp:TextBox ID="tbNombre" type="text" CssClass="form-control1" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="btnInsertar" runat="server"  CssClass="btn btn-info" Text="Insertar" OnClick="btnInsertar_Click"  />
                <br />
                <br />
                </div>
            </section>
    </contenttemplate>
</asp:Content>
