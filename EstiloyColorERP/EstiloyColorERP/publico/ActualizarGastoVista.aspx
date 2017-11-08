<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ActualizarGastoVista.aspx.cs" Inherits="EstiloyColorERP.publico.EditarGastoView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <ContentTemplate>
            <br />
            <asp:Label ID="lblTitulo" CssClass="col-sm-2 control-label" runat="server" Text="Actualizar Actividad"></asp:Label>
            <br />
            <br />
            <section id="formulario">
                <div id="divi">
                    <asp:ListBox ID="ListBox1" CssClass="form-control1" runat="server" Height="24px"></asp:ListBox>
                    <br />
                    <br />
                    <asp:Button ID="Button1" CssClass="btn btn-info" runat="server" Text="Buscar" />
                    <br />
                    <br />
                    </div>
                <div id="divi1">
                    <asp:Label ID="lbID" CssClass="col-sm-2 control-label" runat="server" Text="ID"></asp:Label>
                    <asp:TextBox ID="tbID" CssClass="form-control1" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="lblFecha" CssClass="col-sm-2 control-label" runat="server" Text="Fecha"></asp:Label>
                    <asp:TextBox ID="tbFecha" CssClass="form-control1" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="lblHora" CssClass="col-sm-2 control-label" runat="server" Text="Hora"></asp:Label>
                    <asp:TextBox ID="tbHora" CssClass="form-control1" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="lblActividad" CssClass="col-sm-2 control-label" runat="server" Text="Actividad"></asp:Label>
                    <asp:TextBox ID="tbActividad" CssClass="form-control1" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="lblDireccion" CssClass="col-sm-2 control-label" runat="server" Text="Direccion"></asp:Label>
                    <asp:TextBox ID="tbDireccion"  CssClass="form-control1" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="lblCliente" CssClass="col-sm-2 control-label" runat="server" Text="Cliente"></asp:Label>
                    <asp:TextBox ID="tbCliente" CssClass="form-control1" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    id fecha hora concepto total
                </div>
            </section>
            <asp:Button ID="btnActualizar" CssClass="btn btn-info" runat="server" Text="Actualizar" />
        </ContentTemplate>


</asp:Content>
