<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EliminarVentaVista.aspx.cs" Inherits="EstiloyColorERP.EliminarVentaView" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <ContentTemplate>
        <div class='modal fade' id='myModal' runat="server" tabindex='-1' role='dialog' aria-labelledby='myModalLabel'>
            <div class='modal-dialog' role='document'>
                <div class='modal-content'>
                    <div class='modal-header'>
                        <h4 class='modal-title' id='myModalLabel'>¿Está seguro de que desea eliminar la actividad?</h4>
                    </div>
                    <div class='modal-footer'>
                        <asp:Button id='btnCancelar' CssClass='btn btn-danger' runat="server" Text="Cancelar" OnClick='btnCancelar_Click'></asp:Button>
                        <asp:Button id='btnConfirmar' CssClass='btn btn-success' runat="server" Text="Confirmar" OnClick='btnConfirmar_Click'></asp:Button>
                    </div>
                </div>
            </div>
        </div>
        <section id="formulario1">
            <br />
            <br />
            <asp:Label ID="lblITitulo" CssClass="agileits-title" runat="server" Text="Eliminar Venta"></asp:Label>
            <br />
            <br />
            <br />
             <div id="divi10">
                <asp:TextBox ID="tbDatosNum" CssClass="form-control1" runat="server" type="number" min="1" Text="1" Visible="false"></asp:TextBox>
                 <asp:TextBox ID="tbDatos" CssClass="form-control1" runat="server"></asp:TextBox>
                <asp:RadioButton ID="rbVendedor" runat="server" Text="Vendedor" GroupName="Opcion" Checked="true" AutoPostBack="True" OnCheckedChanged="rbVendedor_CheckedChanged"/>
                <asp:RadioButton ID="rbCliente" runat="server" Text="Telefono de cliente" GroupName="Opcion" AutoPostBack="True" OnCheckedChanged="rbCliente_CheckedChanged"/>
                <asp:RadioButton ID="rbFactura" runat="server" Text="Factura" GroupName="Opcion" AutoPostBack="True" OnCheckedChanged="rbFactura_CheckedChanged"/>
                <br />
                <br />
                <asp:TextBox ID="tbFechaInicio" type="date" CssClass="form-control1" runat="server"></asp:TextBox>
                <asp:TextBox ID="tbFechaFinal" type="date" CssClass="form-control1" runat="server"></asp:TextBox>
                <asp:Button ID="btnBuscar" CssClass="btn btn-info" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
                 <br />
                 <br />
                <asp:GridView ID="gvVentas" CssClass="table table-hover" runat="server" DataKeyNames="Id" OnRowDeleting="DeleteRowButton_Click">
                    <Columns>
                        <asp:CommandField HeaderText="Acción" DeleteText="Eliminar" ShowDeleteButton="True"/>
                    </Columns>
                    <HeaderStyle BackColor="#10C7BF" />
                </asp:GridView>
                <br />
                <br />
                <br />
            </div>
        </section>
    </ContentTemplate>                
</asp:Content>
