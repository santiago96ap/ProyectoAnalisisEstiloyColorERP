﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ObtenerIngresoVista.aspx.cs" Inherits="EstiloyColorERP.publico.ObtenerIngresosView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

           <ContentTemplate>
            <section id="formulario1">
                <br />
                <br />
                <asp:Label ID="lblTitulo" CssClass="agileits-title" runat="server" Text="Obtener Ingresos"></asp:Label>
                <br />
                <br />
                <br />
                <div id="divi10">
                    <asp:TextBox ID="tbFechaInicio" type="date" CssClass="form-control1" runat="server"></asp:TextBox>
                    <asp:TextBox ID="tbFechaFinal" type="date" CssClass="form-control1" runat="server"></asp:TextBox>
                    <asp:Button ID="btnBuscar" CssClass="btn btn-info" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
                    <br />
                    <br />
                    <asp:GridView ID="gvIngresos" CssClass="table table-hover" runat="server" RowHeaderColumn="Ingresos"></asp:GridView>                 
                    <br />
                    <br />
                    <asp:ImageButton ID="btnExportarExcel" runat="server" ImageUrl="images/icono-EXCEL.png" OnClick="btnExportarExcel_Click"/>
                    <asp:ImageButton ID="btnExportarPdf" runat="server" ImageUrl="images/icono-PDF.png" OnClick="btnExportarPdf_Click"/>
                </div>
            </section>
        </ContentTemplate>
    

</asp:Content>
