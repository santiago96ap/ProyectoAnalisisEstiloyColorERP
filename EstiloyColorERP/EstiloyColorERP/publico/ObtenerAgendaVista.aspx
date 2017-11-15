<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ObtenerAgendaVista.aspx.cs" Inherits="EstiloyColorERP.ObtenerAgendaView" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <ContentTemplate>
            <section id="formulario1">
                <br />
                <br />
                <asp:Label ID="lblTitulo" CssClass="agileits-title" runat="server" Text="Actividades en agenda"></asp:Label>
                <br />
                <br />
                <br />
                <div id="divi10">
                    <asp:TextBox ID="tbFecha" type="date" CssClass="form-control1" runat="server" OnTextChanged="tbFecha_TextChanged" AutoPostBack="true"></asp:TextBox>
                    <br />
                    <br />
                    <asp:GridView ID="gvActividades" CssClass="table table-hover" runat="server" RowHeaderColumn="Actividades"></asp:GridView>
                    <br />
                    <asp:ImageButton ID="btnExportarExcel" runat="server" ImageUrl="images/icono-EXCEL.png" OnClick="btnExportarExcel_Click"/>
                    <asp:ImageButton ID="btnExportarPdf" runat="server" ImageUrl="images/icono-PDF.png" OnClick="btnExportarPdf_Click"/>
                    <br />
                    <br />
                    <br />
                </div>
            </section>           
        </ContentTemplate>
</asp:Content>
