<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ObtenerCategoriaVista.aspx.cs" Inherits="EstiloyColorERP.publico.ObtenerCategoria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <ContentTemplate>
            <section id="formulario1">
                <br />
                <br />
                <asp:Label ID="lblTitulo" CssClass="agileits-title" runat="server" Text="Obtener Categorías"></asp:Label>
                <br />
                <br />
                <br />
                <div id="divi10">
                    <asp:GridView ID="gvClientes" CssClass="table table-hover" runat="server" RowHeaderColumn="ID" Width="670px"></asp:GridView>
                    <br />
                    <asp:ImageButton ID="btnExportarExcel" runat="server" ImageUrl="images/icono-EXCEL.png" OnClick="btnExportarExcel_Click"/>
                    <asp:ImageButton ID="btnExportarPdf" runat="server" ImageUrl="images/icono-PDF.png" OnClick="btnExportarPdf_Click"/>
                    <br />
                    <br />
                    <br />
                </div>
            </section>
        </ContentTemplate>
</asp:Content>
