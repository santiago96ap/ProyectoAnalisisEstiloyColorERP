<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VentaView.aspx.cs" Inherits="EstiloyColorERP.VentaView" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <ContentTemplate>
            <br />
          <asp:Label ID="titulo" CssClass="col-sm-2 control-label" runat="server" Text="Insertar Venta"></asp:Label>
            <br />
            <br />
            <section id="formulario">
                <div id="divi">
                     <asp:Label ID="lblFecha" CssClass="col-sm-2 control-label" runat="server" Text="Fecha"></asp:Label>
                     <asp:TextBox ID="tbFecha"  CssClass="form-control1" runat="server"></asp:TextBox>
                   </div>
                   <div id="divi1">
                        <asp:Label ID="lblHora" CssClass="col-sm-2 control-label" runat="server" Text="Hora"></asp:Label>
                        <asp:TextBox ID="tbHora" CssClass="form-control1" runat="server"></asp:TextBox>
                    </div>
           </section>
            <section id="formulario1">
                <div id="divi7">
                    <asp:Label ID="lblArticulos"  CssClass="col-sm-2 control-label" runat="server" Text="Articulos"></asp:Label>
                    <asp:TextBox ID="tbArticulos" CssClass="form-control1" runat="server"></asp:TextBox>
                </div>
                <div id="divi8">
                    <asp:Label ID="lblCategoria"  CssClass="col-sm-2 control-label" runat="server" Text="Categoria"></asp:Label>
                    <asp:ListBox ID="lbCategoria" CssClass="form-control1" runat="server" Height="27px" Width="112px"></asp:ListBox>
                 </div>
                <div id="divi9">
                    <asp:Button ID="btnAgregar" CssClass="btn btn-info" runat="server" Text="Agregar" />
                </div>
                    <br />
             </section>

            <asp:Table ID="tbInsertarProducto"  CssClass="table table-hover" runat="server" Width="640px">
            </asp:Table>

            <section id="formulario2">
                <div id="divi5">
                    <asp:Label ID="lblTelefono" CssClass="col-sm-2 control-label" runat="server" Text="Numero deTelefono"></asp:Label>
                    <asp:TextBox ID="tbTelefono" CssClass="form-control1" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="lblTipoPago"  CssClass="col-sm-2 control-label" runat="server" Text="Tipo de Pago"></asp:Label>
                    <asp:ListBox ID="lbTipoPago"  CssClass="form-control1" runat="server" Height="24px" Width="114px"></asp:ListBox>
                    <br />
                    <br />
                    <asp:Label ID="lblSubTotal" CssClass="col-sm-2 control-label" runat="server" Text="Sub total"></asp:Label>
                    <asp:TextBox ID="tbSubtotal" CssClass="form-control1" runat="server"></asp:TextBox>
                </div>
                <div id="divi6">
                    <asp:Label ID="lblTipoServicio"  CssClass="col-sm-2 control-label" runat="server" Text="Tipo de servicio"></asp:Label>
                    <asp:ListBox ID="lbTipoServicio"  CssClass="form-control1" runat="server" Height="26px" Width="103px"></asp:ListBox>
                    <br />
                    <br />
                    <asp:Label ID="lblVendedor" CssClass="col-sm-2 control-label" runat="server" Text="Vendedor"></asp:Label>
                    <asp:TextBox ID="tbVendedor" CssClass="form-control1" runat="server"></asp:TextBox>
                   <br />
                    <br />
                     <asp:Label ID="lblTotal" CssClass="col-sm-2 control-label" runat="server" Text="Total"></asp:Label>
                    <asp:TextBox ID="tbTotal" CssClass="form-control1" runat="server"></asp:TextBox>
                </div>
           </section>
                    <br />
                    <br />
                    <asp:Button ID="btnInsertar" CssClass="btn btn-info" runat="server" Text="Insertar" />
            <br />
            <br />
        </ContentTemplate>
</asp:Content>
