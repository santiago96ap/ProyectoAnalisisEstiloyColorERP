<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InsertarProductoVista.aspx.cs" Inherits="EstiloyColorERP.publico.InsertarProductoView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

         <contenttemplate>
    <br />
    <br />
        <section id="formulario">
            
            <div id="divi">
                <asp:Label ID="lblTitulo" CssClass="agileits-title" runat="server" Text="Registrar Producto"></asp:Label>
                <br />
                <br />
                <asp:Label ID="lblID" CssClass="col-sm-2 control-label" runat="server" Text="Código"></asp:Label>
                <asp:TextBox ID="tbCodigo" type="number" CssClass="form-control1" runat="server" required=""></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="lblNombre" CssClass="col-sm-2 control-label" runat="server" Text="Nombre"></asp:Label>
                <asp:TextBox ID="tbNombreP" type="text" CssClass="form-control1" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="LblDescripcion" CssClass="col-sm-2 control-label" runat="server" Text="Descripción"></asp:Label>
                <asp:TextBox ID="tbDescrpciom" type="text" CssClass="form-control1" runat="server" required=""></asp:TextBox>
                <br />
                <br />
                 <asp:Label ID="Label4" CssClass="col-sm-2 control-label" runat="server" Text="Costo"></asp:Label>
                <asp:TextBox ID="tbCosto" type="number" CssClass="form-control1"  runat="server" required=""></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="lblPrecio" CssClass="col-sm-2 control-label" runat="server" Text="Precio"></asp:Label>
                <asp:TextBox ID="tbPrecio" type="number" CssClass="form-control1"  runat="server" required=""></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label1" CssClass="col-sm-2 control-label" runat="server" Text="Cantidad"></asp:Label>
                <asp:TextBox ID="tbCant" type="number" CssClass="form-control1"  runat="server" required=""></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label2" CssClass="col-sm-2 control-label" runat="server" Text="Proveedor"></asp:Label>
                <asp:dropdownlist ID="ddlProveedor" CssClass="form-dropdownlist" runat="server"></asp:dropdownlist>
                <br />
                <br /> 
                <asp:Label ID="Label3" CssClass="col-sm-2 control-label" runat="server" Text="Categoría"></asp:Label>
                <asp:dropdownlist ID="ddCategoria" CssClass="form-dropdownlist" runat="server"></asp:dropdownlist>
                <br />
                <br /> 
                <asp:Button ID="btnInsertar" runat="server"  CssClass="btn btn-info" Text="Insertar" OnClick="btnInsertar_Click"  />
                <br />
                <br />
                </div>
            </section>
    </contenttemplate>
</asp:Content>
