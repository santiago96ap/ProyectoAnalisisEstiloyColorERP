<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InsertarVentaVista.aspx.cs" Inherits="EstiloyColorERP.InsertarVentaView" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <ContentTemplate>
            <br />
            <br />
            <br />
            <section id="formulario">
                 <asp:Label ID="titulo" CssClass="agileits-title" runat="server" Text="Insertar Venta"></asp:Label>
                 <br />
                 <br />
                 <br />
                <div id="divi">
                     <asp:Label ID="lblFecha" CssClass="col-sm-2 control-label" runat="server" Text="Fecha"></asp:Label>
                     <asp:TextBox ID="tbFecha" type="date" CssClass="form-control1" runat="server"></asp:TextBox>
                   </div>
                   <div id="divi1">
                        <asp:Label ID="lblHora" CssClass="col-sm-2 control-label" runat="server" Text="Hora"></asp:Label>
                        <asp:TextBox ID="tbHora" type="time" CssClass="form-control1" runat="server"></asp:TextBox>
                    </div>
           </section>
            <br />
            <section id="formulario1">
                <div id="divi7">
                     <br />
                     <br />
                    <asp:Label ID="lblArticulos"  CssClass="col-sm-2 control-label" runat="server" Text="Articulo"></asp:Label>
                    <asp:TextBox ID="TbCodigoProducto" type="number" CssClass="form-control1" runat="server"></asp:TextBox>
                        <br />
                         <br />
                    <asp:Button ID="btnAgregar" CssClass="btn btn-info" runat="server" Text="Agregar" OnClick="btnAgregar_Click" Width="193px" />
                    <br />
                    <br />

                   <asp:GridView ID="gvProductos" CssClass="table table-hover" runat="server" RowHeaderColumn="Proveedores" DataKeyNames="Código" OnRowDeleting="DeleteRowButton_Click" Width="441px">
                    <Columns>
                        <asp:CommandField HeaderText="Acción" ShowDeleteButton="True" DeleteText="Eliminar"/>                
                    </Columns>         
                    </asp:GridView>

                </div>
             </section>
            <br />
           
            <section id="formulario2">
                <div id="divi5">
                    <asp:Label ID="lblTelefono" CssClass="col-sm-2 control-label" runat="server" Text="Cliente"></asp:Label>
                    <asp:TextBox ID="tbTelefono" CssClass="form-control1" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="lblTipoPago"  CssClass="col-sm-2 control-label" runat="server" Text="Pago"></asp:Label>
                    <asp:dropdownlist ID="ddTipoPago" CssClass="form-control1" runat="server" ></asp:dropdownlist>
                    <br />
                    <br />
                    <asp:Label ID="lblSubTotal" CssClass="col-sm-2 control-label" runat="server" Text="Sub-total"></asp:Label>
                    <asp:TextBox ID="tbSubtotal" CssClass="form-control1" runat="server" Enabled="False"></asp:TextBox>
                </div>
                <div id="divi6">
                    <asp:Label ID="lblTipoServicio"  CssClass="col-sm-2 control-label" runat="server" Text="Servicio"></asp:Label>
                    <asp:dropdownlist ID="ddTipoServicio" CssClass="form-control1" runat="server" ></asp:dropdownlist>
                    <br />
                    <br />
                     <asp:Label ID="lblTotal" CssClass="col-sm-2 control-label" runat="server" Text="Total"></asp:Label>
                    <asp:TextBox ID="tbTotal" CssClass="form-control1" runat="server" Enabled="False"></asp:TextBox>
                </div>
                    <br />
                    <br />
                    <asp:Button ID="btnInsertar" CssClass="btn btn-info" runat="server" Text="Insertar" OnClick="btnInsertar_Click" />
                    <br />
                    <br />
           </section>
                    <br />
                   
        </ContentTemplate>
</asp:Content>
