<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ActualizarProveedorView.aspx.cs" Inherits="EstiloyColorERP.publico.ActualizarProveedorView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
                

    <section id="formulario1">
    <asp:Label ID="lblTitulo" CssClass="agileits-title" runat="server" Text="Actualizar Proveedor"></asp:Label>    
                <br />    <div id="divi">
        <asp:GridView ID="gvProveedores" CssClass="table table-hover" runat="server" Height="154px" RowHeaderColumn="Usuarios" Width="640px" >
            <Columns>
                <asp:ButtonField ButtonType="Button" CommandName="Update" HeaderText="Accion" ShowHeader="True" Text="Actualizar" />
            </Columns>
            <HeaderStyle BackColor="#10C7BF"/>
        </asp:GridView>
    <br />
    <asp:Label ID="lbNombre" CssClass="col-sm-2 control-label" runat="server" Text="Nombre"></asp:Label>
    <asp:TextBox ID="tbNombre" CssClass="form-control1" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lbDireccion" CssClass="col-sm-2 control-label" runat="server" Text="Direccion"></asp:Label>
    <asp:TextBox ID="tbDireccion" CssClass="form-control1" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lbEmail" CssClass="col-sm-2 control-label" runat="server" Text="Email"></asp:Label>
    <asp:TextBox ID="tbEmail" CssClass="form-control1" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lbTelefono" CssClass="col-sm-2 control-label" runat="server" Text="Telefono"></asp:Label>
    <asp:TextBox ID="tbDireccion0" CssClass="form-control1" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="btnActualizar" CssClass="btn btn-info" runat="server" Text="Actualizar" OnClick="btnActualizar_Click" />
    </div>
        </section>
</asp:Content>
