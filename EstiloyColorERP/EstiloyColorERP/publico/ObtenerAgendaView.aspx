<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ObtenerAgendaView.aspx.cs" Inherits="EstiloyColorERP.ObtenerAgendaView" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <ContentTemplate>
            <br />
            <asp:Label ID="lblTitulo" CssClass="col-sm-2 control-label" runat="server" Text="Obtener Actividades"></asp:Label>
            <br />
            <br />
            &nbsp;<asp:Calendar ID="calendario" runat="server" Height="250px" Width="631px"></asp:Calendar>
            &nbsp;
        </ContentTemplate>
</asp:Content>
