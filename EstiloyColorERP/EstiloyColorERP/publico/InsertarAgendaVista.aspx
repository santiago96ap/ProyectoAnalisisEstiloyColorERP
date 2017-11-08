<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InsertarAgendaVista.aspx.cs" Inherits="EstiloyColorERP.AgendaView" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <contenttemplate>
    <br />
    <br />
        <section id="formulario">
            <div id="divi">
                <asp:Label ID="lblTitulo" CssClass="agileits-title" runat="server" Text="Registrar Actividad"></asp:Label>
                <br />
                <br />
                <asp:Label ID="lblID" CssClass="col-sm-2 control-label" runat="server" Text="Fecha"></asp:Label>
                <asp:TextBox ID="tbFecha" type="date" CssClass="form-control1" runat="server" required=""></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="lblNombre" CssClass="col-sm-2 control-label" runat="server" Text="Hora"></asp:Label>
                <asp:TextBox ID="tbHora" type="time" CssClass="form-control1" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="LblDescripcion" CssClass="col-sm-2 control-label" runat="server" Text="Actividad"></asp:Label>
                <asp:TextBox ID="tbActividad" type="text" CssClass="form-control1" runat="server" required=""></asp:TextBox>
                <br />
                <br />
                 <asp:Label ID="Label4" CssClass="col-sm-2 control-label" runat="server" Text="Dirección"></asp:Label>
                <asp:TextBox ID="tbDireccion" type="text" CssClass="form-control1"  runat="server" required=""></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label2" CssClass="col-sm-2 control-label" runat="server" Text="Cliente"></asp:Label>
                <asp:dropdownlist ID="ddClientes" CssClass="form-dropdownlist" runat="server"></asp:dropdownlist>
                <br />
                <br /> 
                <asp:Button ID="btnInsertar" runat="server"  CssClass="btn btn-info" Text="Insertar" OnClick="btnInsertar_Click"  />
                <br />
                <br />
                </div>
            </section>
    </contenttemplate>
</asp:Content>
