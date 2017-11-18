<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ActualizarProveedorVista.aspx.cs" Inherits="EstiloyColorERP.publico.ActualizarProveedorView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
                

    <section id="formulario1">
        <br />
        <br />
    <asp:Label ID="lblTitulo" CssClass="agileits-title" runat="server" Text="Actualizar Proveedor"></asp:Label>    
                <br />    <div id="divi">
        <asp:GridView ID="gvProveedores" CssClass="table table-hover" runat="server" RowHeaderColumn="Proveedores" DataKeyNames="Email" OnRowDeleting="DeleteRowButton_Click">
            <AlternatingRowStyle BackColor="#EFEFEF" />
            <Columns>
                <asp:CommandField HeaderText="Acción" ShowDeleteButton="True" DeleteText="Seleccionar"/>                
            </Columns>            
            <HeaderStyle BackColor="#10C7BF"/>            
        </asp:GridView> 
    <br />
    <asp:Label ID="lbNombre" CssClass="col-sm-2 control-label" runat="server" Text="Nombre"></asp:Label>
    <asp:TextBox ID="tbNombre" CssClass="form-control1" runat="server" Enabled="false"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lbDireccion" CssClass="col-sm-2 control-label" runat="server" Text="Direccion"></asp:Label>
    <asp:TextBox ID="tbDireccion" CssClass="form-control1" runat="server" Enabled="false"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lbEmail" CssClass="col-sm-2 control-label" runat="server" Text="Email"></asp:Label>
    <asp:TextBox ID="tbEmail" CssClass="form-control1" runat="server" Enabled="false"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lbTelefono" CssClass="col-sm-2 control-label" runat="server" Text="Telefono"></asp:Label>
    <asp:TextBox ID="tbTelefono" CssClass="form-control1" runat="server" type="number" min="1" Enabled="false"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="btnActualizar" CssClass="btn btn-info" runat="server" Text="Actualizar" OnClick="btnActualizar_Click" Enabled="false"/>
    <br />
    <br />
    </div>
        </section>
</asp:Content>
