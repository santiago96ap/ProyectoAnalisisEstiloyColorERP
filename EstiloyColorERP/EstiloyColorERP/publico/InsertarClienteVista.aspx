﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InsertarClienteVista.aspx.cs" Inherits="EstiloyColorERP.InsertarCliente" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <ContentTemplate>
            <section id="formulario1">
                <br />
                <br />
                <asp:Label ID="lblTitulo" CssClass="agileits-title" runat="server" Text="Insertar Cliente"></asp:Label>
                <br />
                <br />
                <br />
                <div id="divi1">
                    <asp:Label ID="lblNombre" CssClass="col-sm-2 control-label" runat="server" Text="Nombre"></asp:Label>
                    <asp:TextBox ID="tbNombre" CssClass="form-control1" runat="server" required=""></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="lblApellidos" CssClass="col-sm-2 control-label" runat="server" Text="Apellidos"></asp:Label>
                    <asp:TextBox ID="tbApellidos" CssClass="form-control1" runat="server" required=""></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="lblTelefono" CssClass="col-sm-2 control-label" runat="server" Text="Teléfono"></asp:Label>
                    <asp:TextBox ID="tbTelefono" CssClass="form-control1" type="number" runat="server" required=""></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="lblDireccion" CssClass="col-sm-2 control-label" runat="server" Text="Dirección"></asp:Label>
                    <asp:TextBox ID="tbDireccion" CssClass="form-control1" runat="server" required=""></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="lblCorreo" CssClass="col-sm-2 control-label" runat="server" Text="Correo"></asp:Label>
                    <asp:TextBox ID="tbCorreo" CssClass="form-control1" type="email" runat="server" required=""></asp:TextBox>
                </div>
                <br />
                <br />
                <br />
                <asp:Button ID="btnInsertar" CssClass="btn btn-info" runat="server" Text="Insertar" OnClick="btnInsertar_Click"/>
                <br />
                <br />
                <br />
            </section>
        </ContentTemplate>
</asp:Content>
