<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EliminarUsuarioVista.aspx.cs" Inherits="EstiloyColorERP.publico.Eliminar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <ContentTemplate>
        <div class='modal fade' id='myModal' runat="server" tabindex='-1' role='dialog' aria-labelledby='myModalLabel'>
            <div class='modal-dialog' role='document'>
                <div class='modal-content'>
                    <div class='modal-header'>
                        <h4 class='modal-title' id='myModalLabel'>¿Está seguro de que desea eliminar la actividad?</h4>
                    </div>
                    <div class='modal-footer'>
                        <asp:Button id='btnCancelar' CssClass='btn btn-danger' runat="server" Text="Cancelar" OnClick='btnCancelar_Click'></asp:Button>
                        <asp:Button id='btnConfirmar' CssClass='btn btn-success' runat="server" Text="Confirmar" OnClick='btnConfirmar_Click'></asp:Button>
                    </div>
                </div>
            </div>
        </div>
        <section id="formulario1">
            <br />
            <br />
            <asp:Label ID="lblITitulo" CssClass="agileits-title" runat="server" Text="Eliminar Usuarios"></asp:Label>
            <br />
            <br />
            <br />
             <div id="divi10">
                <asp:Label ID="lblUsuario" CssClass="col-sm-2 control-label" runat="server" Text="Rol"></asp:Label>
                <asp:TextBox ID="tbUsuario" CssClass="form-control1" runat="server"></asp:TextBox>
                <asp:Button ID="btnBuscar" CssClass="btn btn-info" runat="server" Text="Buscar" OnClick="btnBuscar_Click"/> 
                <br />
                <br />
                <asp:GridView ID="gvUsuarios" CssClass="table table-hover" runat="server" DataKeyNames="Nombre Usuario" OnRowDeleting="DeleteRowButton_Click">
                    <Columns>
                        <asp:CommandField HeaderText="Acción" ShowDeleteButton="True"/>
                    </Columns>
                    <HeaderStyle BackColor="#10C7BF" />
                </asp:GridView>
                <br />
                <br />
                <br />
            </div>
        </section>
    </ContentTemplate>
</asp:Content>
