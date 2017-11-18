<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InsertarOfertaVista.aspx.cs" Inherits="EstiloyColorERP.InsertarOferta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<contenttemplate>
    <br />
    <br />
        <section id="formulario">
            <div id="divi">
                <asp:Label ID="lblTitulo" CssClass="agileits-title" runat="server" Text="Registrar Oferta"></asp:Label>
                <br />
                <br />
                <asp:Label ID="Label2" CssClass="col-sm-2 control-label" runat="server" Text="Producto"></asp:Label>
                <asp:dropdownlist ID="ddProducto" CssClass="form-dropdownlist" runat="server" OnSelectedIndexChanged="ddProducto_SelectedIndexChanged"></asp:dropdownlist>
                <br />
                <br />                
                <asp:Label ID="lblID" CssClass="col-sm-2 control-label" runat="server" Text="Fecha Inicio"></asp:Label>
                <asp:TextBox ID="tbFechaI" type="date" CssClass="form-control1" runat="server" required=""></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="lblNombre" CssClass="col-sm-2 control-label" runat="server" Text="Fecha Fin"></asp:Label>
                <asp:TextBox ID="tbFechaF" type="date" CssClass="form-control1" runat="server" required=""></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="LblDescripcion" CssClass="col-sm-2 control-label" runat="server" Text="Descuento (porcentaje %)"></asp:Label>
                <asp:TextBox ID="tbDescuento" type="number" CssClass="form-control1" runat="server" required="" min="1" max="100">%</asp:TextBox>
                <br />
                <br />
                <asp:Button ID="btnInsertar" runat="server"  CssClass="btn btn-info" Text="Insertar" OnClick="btnInsertar_Click"  />
                <br />
                <br />
                </div>
            </section>
    </contenttemplate>

</asp:Content>
