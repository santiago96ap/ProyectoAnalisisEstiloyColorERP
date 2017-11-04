<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EliminarAgendaView.aspx.cs" Inherits="EstiloyColorERP.EliminarAgendaView" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <ContentTemplate>
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
                            <asp:CommandField HeaderText="Acción" ShowDeleteButton="True"/>
                        </Columns>
                    </asp:GridView>
                    <br />
                    <br />
                    <br />
                </div>
            </section>
        </ContentTemplate>
</asp:Content>
