<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EliminarAgendaVista.aspx.cs" Inherits="EstiloyColorERP.EliminarAgendaView" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <contenttemplate>
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
                <asp:Label ID="lblTitulo" CssClass="agileits-title" runat="server" Text="Eliminar Actividad"></asp:Label>
                <br />
                <br />
                <br />
                <div id="divi10">
                    <asp:GridView ID="gvActividades" CssClass="table table-hover" runat="server" DataKeyNames="Fecha y Hora" OnRowDeleting="DeleteRowButton_Click">
                        <Columns>
                            <asp:CommandField HeaderText="Acción" DeleteText="Eliminar" ShowDeleteButton="True"/>
                        </Columns>
                        <HeaderStyle BackColor="#10C7BF" />
                    </asp:GridView>
                    <br />
                    <br />
                    <br />
                </div>
            </section>
        </contenttemplate>
</asp:Content>
