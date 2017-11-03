<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ObtenerUsuarioView.aspx.cs" Inherits="EstiloyColorERP.publico.MostrarUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    <Contenttemplate>
            <section id="formulario1">
    <br />
    <asp:Label ID="lblTitulo" CssClass="agileits-icons-title" runat="server" Text="Obtener Usuarios"></asp:Label>
    <br />
    <br />
                 <div id="divi10">
            <asp:DropDownList ID="ddlRol" runat="server" CssClass="form-dropdownlist" Width="176px">
                <asp:ListItem Value="todos">Todos</asp:ListItem>
                <asp:ListItem Value="adm">Administrador</asp:ListItem>
                <asp:ListItem Value="vendedor">Vendedor</asp:ListItem>
    </asp:DropDownList>
            <asp:Button ID="btnBuscar" CssClass="btn btn-info" runat="server" Text="Mostrar" OnClick="btnBuscar_Click" />
    <br />
    <br />
                    <asp:GridView ID="gvUsuarios" CssClass="table table-hover" runat="server" > </asp:GridView>
    <br />
    <br />
                      </div>
                </section>
    </Contenttemplate>



</asp:Content>
