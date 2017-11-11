<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InsertarApartadoVista.aspx.cs" Inherits="EstiloyColorERP.publico.InsertarApartadoView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <ContentTemplate>
        <section id="formulario">
            <br />     
            <asp:Label ID="titulo" CssClass="agileits-title" runat="server" Text="Insertar Apartado"></asp:Label>
                 <br />
                 <br />
            <div id="divi3">
                <asp:Label ID="lblCliente"  CssClass="col-sm-2 control-label" runat="server" Text="Cliente"></asp:Label>
                <asp:TextBox ID="tbCliente" CssClass="form-control1" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="lblFActura"  CssClass="col-sm-2 control-label" runat="server" Text="Factura"></asp:Label>
                <asp:TextBox ID="tbFactura" CssClass="form-control1" runat="server"></asp:TextBox>
            </div>            
           </section>                    
            <section id="formulario1">
                <div id="divi7">
                     <br />
                    <br />
                     <br />
                    <asp:Label ID="lblIndicador"  CssClass="col-sm-2 control-label" runat="server" Text="Articulo"></asp:Label>
                    <asp:TextBox ID="tbDatos" CssClass="form-control1" runat="server"></asp:TextBox>
                    <br />
                     <br />
                    <asp:Label ID="lblCantidad"  CssClass="col-sm-2 control-label" runat="server" Text="Cantidad"></asp:Label>
                    <asp:TextBox ID="tbCantidad" type="number" CssClass="form-control1" runat="server" min="1" Text="1"></asp:TextBox>
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
                    <asp:Label ID="lblFechaInicio"  CssClass="col-sm-2 control-label" runat="server" Text="Pago"></asp:Label>
                    <asp:TextBox ID="tbFechaInicio" type="date" CssClass="form-control1" runat="server" Enabled="false"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="lblTotal" CssClass="col-sm-2 control-label" runat="server" Text="Total"></asp:Label>
                    <asp:TextBox ID="tbTotal" CssClass="form-control1" type="number" runat="server" min="1" Enabled="false"></asp:TextBox>
                </div>
                <div id="divi6">
                    <asp:Label ID="lblFechaFin"  CssClass="col-sm-2 control-label" runat="server" Text="Fecha fin"></asp:Label>
                    <asp:TextBox ID="tbFechaFin" type="date" CssClass="form-control1" runat="server"></asp:TextBox>
                    <br />
                    <br />
                     <asp:Label ID="lblAbono" CssClass="col-sm-2 control-label" runat="server" Text="Abono"></asp:Label>
                     <asp:TextBox ID="tbAbono" CssClass="form-control1" runat="server" type="number" min="1"></asp:TextBox>
                </div>
                    <br />
                    <br />
                    <asp:Button ID="btnInsertar" CssClass="btn btn-info" runat="server" Text="Insertar" OnClick="btnInsertar_Click" />
                    <br />
                    <br />
           </section>
        </ContentTemplate>
</asp:Content>
