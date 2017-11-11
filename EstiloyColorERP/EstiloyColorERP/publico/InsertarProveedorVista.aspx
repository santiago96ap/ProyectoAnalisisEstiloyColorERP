<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InsertarProveedorVista.aspx.cs" Inherits="EstiloyColorERP.publico.AgregarProveedorView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <contenttemplate>
    <br />
    <br />
        <section id="formulario">
            <div id="divi">
                <asp:Label ID="lblTitulo" CssClass="agileits-title" runat="server" Text="Registrar Proveedor"></asp:Label>
                <br />
                <br />
                <asp:Label ID="lblEmail" CssClass="col-sm-2 control-label" runat="server" Text="E-mail"></asp:Label>
                <asp:TextBox ID="tbEmail" type="email" CssClass="form-control1" runat="server" required=""></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="lblNombre" CssClass="col-sm-2 control-label" runat="server" Text="Nombre"></asp:Label>
                <asp:TextBox ID="tbNombre" type="text" CssClass="form-control1" runat="server" required=""></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="lblTelefono" CssClass="col-sm-2 control-label" runat="server" Text="Teléfono"></asp:Label>
                <asp:TextBox ID="tbTelefono" type="number" CssClass="form-control1"  runat="server" required=""></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label1" CssClass="col-sm-2 control-label" runat="server" Text="Dirección"></asp:Label>
                <asp:TextBox ID="TbDireccion" type="text" CssClass="form-control1" runat="server" required=""></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="lblPagina" CssClass="col-sm-2 control-label" runat="server" Text="Pagina Web"></asp:Label>
                <asp:TextBox ID="tbPagina" type="text" CssClass="form-control1" runat="server" required=""></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="btnInsertar" runat="server"  CssClass="btn btn-info" Text="Insertar" OnClick="btnInsertar_Click"  />
                <br />
                <br />
                </div>
            </section>
    </contenttemplate>
</asp:Content>
