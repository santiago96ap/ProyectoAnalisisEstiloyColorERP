<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ObtenerUsuarioVista.aspx.cs" Inherits="EstiloyColorERP.publico.MostrarUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    <Contenttemplate>
            <section id="formulario1" runat="server">
                <br />
                <asp:Label ID="lblTitulo" CssClass="agileits-icons-title" runat="server" Text="Obtener Usuarios"></asp:Label>
                <br />
                <br />
                <div id="divi10">
                    <asp:DropDownList ID="ddlRol" runat="server" CssClass="form-control1" Width="176px">
                        <asp:ListItem Value="todos">Todos</asp:ListItem>
                        <asp:ListItem Value="administrador">Administrador</asp:ListItem>
                        <asp:ListItem Value="vendedor">Vendedor</asp:ListItem>
                    </asp:DropDownList>
                    <asp:Button ID="btnBuscar" CssClass="btn btn-info" runat="server" Text="Mostrar" OnClick="btnBuscar_Click" />
                     
                    <br />
                    <br />
                    <asp:GridView ID="gvUsuarios" CssClass="table table-hover" runat="server" RowHeaderColumn="Usuarios">
                        <HeaderStyle BackColor="#10C7BF" />
                     </asp:GridView>
                    <br />
                    <br />
                    <asp:ImageButton ID="btnExportarExcel" runat="server" ImageUrl="images/icono-EXCEL.png" OnClick="btnExportarExcel_Click"/>
                    <asp:ImageButton ID="btnExportarPdf" runat="server" ImageUrl="images/icono-PDF.png" OnClick="btnExportarPdf_Click"/>
                </div>
            </section>
    </Contenttemplate>



</asp:Content>
