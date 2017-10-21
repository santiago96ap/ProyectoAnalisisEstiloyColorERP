<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EliminarAgendaView.aspx.cs" Inherits="EstiloyColorERP.EliminarAgendaView" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <ContentTemplate>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />&nbsp;<asp:Label ID="lblTitulo" CssClass="col-sm-2 control-label" runat="server" Text="Eliminar Actividad"></asp:Label>
            <br />
            <br />
            &nbsp;<asp:Table ID="tbResultados" CssClass="table table-hover" runat="server" Width="474px">
            </asp:Table>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnEliminar" CssClass="btn btn-info" runat="server" Text="Eliminar" />
            <br />
            <br />
        </ContentTemplate>
</asp:Content>
