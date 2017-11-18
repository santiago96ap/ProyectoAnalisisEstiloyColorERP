<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ActualizarCategoriaVista.aspx.cs" Inherits="EstiloyColorERP.publico.ActualizarCategoriaVista" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <section id="formulario1">
            <br />
            <br />
        <asp:Label ID="lblTitulo" CssClass="agileits-title" runat="server" Text="Actualizar Categoría"></asp:Label>    
                    <br />    <div id="divi">
            <asp:GridView ID="gvCategorias" CssClass="table table-hover" runat="server" RowHeaderColumn="Categorias" DataKeyNames="ID" OnRowDeleting="DeleteRowButton_Click">
                <AlternatingRowStyle BackColor="#EFEFEF" />
                <Columns>
                    <asp:CommandField HeaderText="Acción" ShowDeleteButton="True" DeleteText="Seleccionar"/>                
                </Columns>            
                <HeaderStyle BackColor="#10C7BF"/>            
            </asp:GridView>
        <br />
        <asp:Label ID="Label1" CssClass="col-sm-2 control-label" runat="server" Text="ID"></asp:Label>
        <asp:TextBox ID="tbID" CssClass="form-control1" runat="server" Enabled="false"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lbNombre" CssClass="col-sm-2 control-label" runat="server" Text="Nombre"></asp:Label>
        <asp:TextBox ID="tbNombre" CssClass="form-control1" runat="server" Enabled="false"></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnActualizar" CssClass="btn btn-info" runat="server" Text="Actualizar" OnClick="btnActualizar_Click" Enabled="false"/>
        <br />
        <br />
        </div>
      </section>
</asp:Content>
