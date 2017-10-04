<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ObtenerAgendaView.aspx.cs" Inherits="EstiloyColorERP.ObtenerAgendaView" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <ContentTemplate>
            <br />
            <br />
            <asp:Label ID="lblTitulo" runat="server" Text="Agenda"></asp:Label>
            <br />
            <br />
            &nbsp;<asp:Calendar ID="calendario" runat="server"></asp:Calendar>
            &nbsp;
        </ContentTemplate>
</asp:Content>
