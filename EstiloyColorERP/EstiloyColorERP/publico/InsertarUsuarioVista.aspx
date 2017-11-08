<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InsertarUsuarioVista.aspx.cs" Inherits="EstiloyColorERP.publico.InsertarUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <contenttemplate>
    <br />
    <br />
        <section id="formulario">
            
            <div id="divi">
                <asp:Label ID="lblTitulo" CssClass="agileits-title" runat="server" Text="Registrar Usuario"></asp:Label>
                <br />
                <br />
                <asp:Label ID="lblID" CssClass="col-sm-2 control-label" runat="server" Text="Usuario"></asp:Label>
                <asp:TextBox ID="tbUsuario" type="text" CssClass="form-control1" runat="server" required=""></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="lblNombre" CssClass="col-sm-2 control-label" runat="server" Text="Nombre"></asp:Label>
                <asp:TextBox ID="tbNombreP" type="text" CssClass="form-control1" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="LblDescripcion" CssClass="col-sm-2 control-label" runat="server" Text="Apellidos"></asp:Label>
                <asp:TextBox ID="tbApellidos" type="text" CssClass="form-control1" runat="server" required=""></asp:TextBox>
                <br />
                <br />
                 <asp:Label ID="Label4" CssClass="col-sm-2 control-label" runat="server" Text="Contraseña"></asp:Label>
                <asp:TextBox ID="tbPass" type="password" CssClass="form-control1"  runat="server" required=""></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="lblPrecio" CssClass="col-sm-2 control-label" runat="server" Text="E-mail"></asp:Label>
                <asp:TextBox ID="tbEmail" type="email" CssClass="form-control1"  runat="server" required=""></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label1" CssClass="col-sm-2 control-label" runat="server" Text="Teléfono"></asp:Label>
                <asp:TextBox ID="tbTelefono" type="number" CssClass="form-control1"  runat="server" required=""></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label2" CssClass="col-sm-2 control-label" runat="server" Text="Rol"></asp:Label>
                <asp:dropdownlist ID="ddTipoUsuario" CssClass="form-dropdownlist" runat="server"></asp:dropdownlist>
                <br />
                <br /> 
                <asp:Button ID="btnInsertar" runat="server"  CssClass="btn btn-info" Text="Insertar" OnClick="btnInsertar_Click"  />
                <br />
                <br />
                </div>
            </section>
    </contenttemplate>

</asp:Content>
