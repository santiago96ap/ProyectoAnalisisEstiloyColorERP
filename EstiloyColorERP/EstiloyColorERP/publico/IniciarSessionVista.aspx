<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="IniciarSessionVista.aspx.cs" Inherits="EstiloyColorERP.publico.IniciarSessionView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <contenttemplate>
    <br />
    <br />
        <section id="formulario">
            <div id="divi">
                <asp:Label ID="lblTitulo" CssClass="agileits-title" runat="server" Text="Iniciar Sesión"></asp:Label>
                <br />
                <br />
                <asp:Label ID="lblCorreo" CssClass="col-sm-2 control-label" runat="server" Text="Correo"></asp:Label>
                <asp:TextBox ID="tbCorreo" CssClass="form-control1" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="lblContrasenna" CssClass="col-sm-2 control-label" runat="server" Text="Contraseña"></asp:Label>
                <asp:TextBox ID="tbContrasenna" CssClass="form-control1" runat="server" TextMode="Password"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="btnIniciarSession" runat="server"  CssClass="btn btn-info" Text="Iniciar Sessión" OnClick="btnIniciarSession_Click" />
                <br />
                <br />
                <br />
            </div>
        </section>
    </contenttemplate>
</asp:Content>
