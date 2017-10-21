<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InsertarIngresoView.aspx.cs" Inherits="EstiloyColorERP.publico.InsertarIngresoView" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <contenttemplate>
    &nbsp;
    
    <br />
    <br />
        <section id="formulario">
            
            <div id="divi">
                <asp:Label ID="lblTitulo" CssClass="agileits-title" runat="server" Text="Registrar Ingreso"></asp:Label>
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
                <asp:Label ID="LblConcepto" CssClass="col-sm-2 control-label" runat="server" Text="Concepto"></asp:Label>
                <asp:TextBox ID="tbConcepto" CssClass="form-control1" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="lblTotal" CssClass="col-sm-2 control-label" runat="server" Text="Total"></asp:Label>
                <asp:TextBox ID="tbTotal" CssClass="form-control1"  runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="btnInsertar" runat="server"  CssClass="btn btn-info" Text="Insertar" />
                <br />
                <br />
                </div>
            </section>
    </contenttemplate>



</asp:Content>
