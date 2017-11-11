<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InventarioVista.aspx.cs" Inherits="EstiloyColorERP.publico.InventarioVista" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section id="formulario1">
                <br />
                <br />
                <asp:Label ID="lblTitulo" CssClass="agileits-title" runat="server" Text="Inventario de Productos"></asp:Label>
                <br />
                <br />
                <br />
                <div id="divi1">
                    <asp:dropdownlist ID="ddlCategorias" CssClass="form-control1" runat="server">
                    </asp:dropdownlist>
                    <br />
                    <br />                   
                    <asp:Button ID="btnBuscar" CssClass="btn btn-info" runat="server" Text="Buscar" OnClick="btnBuscar_Click"/>
                    <br />
                    <br />                    
                    <asp:GridView ID="gvProductos" CssClass="table table-hover" runat="server" RowHeaderColumn="Ventas"></asp:GridView>
                    <br />
                    <br />                    
                    <asp:ImageButton ID="btnExportarExcel" runat="server" ImageUrl="images/icono-EXCEL.png" OnClick="btnExportarExcel_Click"/>
                    <asp:ImageButton ID="btnExportarPdf" runat="server" ImageUrl="images/icono-PDF.png" OnClick="btnExportarPdf_Click"/>
                    <br />
                    <br />
                </div>
            </section>
        </ContentTemplate>
</asp:Content>
