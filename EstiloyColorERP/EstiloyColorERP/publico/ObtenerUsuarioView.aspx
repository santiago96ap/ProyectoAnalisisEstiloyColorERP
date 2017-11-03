<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ObtenerUsuarioView.aspx.cs" Inherits="EstiloyColorERP.publico.MostrarUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    <Contenttemplate>
            <section id="formulario1" runat="server">
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
                     <asp:Button ID="btnExcel" runat="server" OnClick="btnExcel_Click" Text="Excel" />
                     <asp:Button ID="pdf" runat="server" OnClick="pdf_Click" Text="PDF" />
    <br />
    <br />
                    <asp:GridView ID="gvUsuarios" CssClass="table table-hover" runat="server" Height="154px" RowHeaderColumn="Usuarios" Width="640px" OnSelectedIndexChanged="gvUsuarios_SelectedIndexChanged" >
                        <HeaderStyle BackColor="#10C7BF" />

                     </asp:GridView>
    <br />
    <br />
                      </div>
                </section>
    </Contenttemplate>



</asp:Content>
