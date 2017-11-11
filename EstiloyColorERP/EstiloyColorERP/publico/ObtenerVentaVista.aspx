<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ObtenerVentaVista.aspx.cs" Inherits="EstiloyColorERP.ObtenerVentaView" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <ContentTemplate>
            <section id="formulario1">
                <br />
                <br />
                <asp:Label ID="lblTitulo" CssClass="agileits-title" runat="server" Text="Obtener Ofertas"></asp:Label>
                <br />
                <br />
                <br />
                <div id="divi1">
                    <asp:dropdownlist ID="ddlProveedores" CssClass="form-control1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlProveedores_SelectedIndexChanged">
                        <asp:ListItem Value="cliente">Telefono cliente</asp:ListItem>
                        <asp:ListItem Value="usuario">Usuario</asp:ListItem>
                    </asp:dropdownlist>
                    <br />
                    <br /> 
                    <asp:Label ID="lblInfo" CssClass="col-sm-2 control-label" runat="server" Text="Telefono"></asp:Label>
                    <asp:TextBox ID="tbBuscar" CssClass="form-control1" runat="server"></asp:TextBox>
                    <br />
                    <br />                    
                    <asp:Button ID="btnBuscar" CssClass="btn btn-info" runat="server" Text="Buscar" OnClick="btnBuscar_Click"/>
                    <br />
                    <br />                    
                    <asp:GridView ID="gvVentas" CssClass="table table-hover" runat="server" RowHeaderColumn="Ventas"></asp:GridView>
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
