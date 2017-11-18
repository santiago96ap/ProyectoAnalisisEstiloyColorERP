<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ActualizarProductVista.aspx.cs" Inherits="EstiloyColorERP.publico.ActualizarProductVista" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <contenttemplate>
            <section id="formulario1">
                <br />
                <br />
                <asp:Label ID="lblTitulo" CssClass="agileits-title" runat="server" Text="Actualizar Producto"></asp:Label>
                <br />
                <br />
                <br />
                <section id="formulario">
                    <div id="divi">
                        <asp:Label ID="Label1" CssClass="col-sm-2 control-label" runat="server" Text="Código"></asp:Label>
                        <asp:TextBox ID="tbBuscar" CssClass="form-control1" runat="server" type="number" min="1"></asp:TextBox>
                        <br />
                        <br /> 
                        <asp:Button ID="btnBuscar" CssClass="btn btn-info" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
                        <br />
                        <br />
                    </div>
                    <div id="divi1">
                        <asp:Label ID="lblID" CssClass="col-sm-2 control-label" runat="server" Text="Código"></asp:Label>
                        <asp:TextBox ID="tbCodigo" type="number" CssClass="form-control1" runat="server" Enabled="false"></asp:TextBox>
                        <br />
                        <br />
                        <asp:Label ID="lblNombre" CssClass="col-sm-2 control-label" runat="server" Text="Nombre"></asp:Label>
                        <asp:TextBox ID="tbNombreP" type="text" CssClass="form-control1" runat="server" Enabled="false"></asp:TextBox>
                        <br />
                        <br />
                        <asp:Label ID="LblDescripcion" CssClass="col-sm-2 control-label" runat="server" Text="Descripción"></asp:Label>
                        <asp:TextBox ID="tbDescrpciom" type="text" CssClass="form-control1" runat="server" Enabled="false"></asp:TextBox>
                        <br />
                        <br />
                         <asp:Label ID="Label4" CssClass="col-sm-2 control-label" runat="server" Text="Costo"></asp:Label>
                        <asp:TextBox ID="tbCosto" type="number" min="1" CssClass="form-control1"  runat="server" Enabled="false"></asp:TextBox>
                        <br />
                        <br />
                        <asp:Label ID="lblPrecio" CssClass="col-sm-2 control-label" runat="server" Text="Precio"></asp:Label>
                        <asp:TextBox ID="tbPrecio" type="number" min="1" CssClass="form-control1"  runat="server" Enabled="false"></asp:TextBox>
                        <br />
                        <br />
                        <asp:Label ID="Label2" CssClass="col-sm-2 control-label" runat="server" Text="Cantidad"></asp:Label>
                        <asp:TextBox ID="tbCant" type="number" min="1" CssClass="form-control1"  runat="server" Enabled="false"></asp:TextBox>
                        <br />
                        <br />
                    </div>
                </section>
                <br />
                <br />
                <br />
                <asp:Button ID="btnActualizar" CssClass="btn btn-info" runat="server" Text="Actualizar" OnClick="btnActualizar_Click" Enabled="false"/>
                <br />
                <br />
                <br />
            </section>
        </contenttemplate>
</asp:Content>
