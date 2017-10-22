<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ObtenerClienteView.aspx.cs" Inherits="EstiloyColorERP.ObtenerCliente" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <ContentTemplate>
            <br />
            <br />
            <asp:Label ID="lblTitulo" CssClass="col-sm-2 control-label" runat="server" Text="Obtener Cliente"></asp:Label>
            <br />
            <br />
            <br />
            <asp:ListBox ID="lbBuscar" CssClass="form-control1" runat="server"></asp:ListBox>
            <asp:TextBox ID="tbBuscar" CssClass="form-control1" runat="server"></asp:TextBox>
            <asp:Button ID="btnBuscar" CssClass="btn btn-info" runat="server" Text="Buscar" />
            <br />
            <br />
            <asp:gridview id="clientes" CssClass="table table-hover" runat="server" AutoGenerateColumns="False">   
                <Columns>  
                    <asp:BoundField DataField="Nombre" HeaderText="Nombre" ItemStyle-Width="100">
                        <ItemStyle Width="100px"></ItemStyle>
                    </asp:BoundField>
                    <asp:BoundField DataField="Apellidos" HeaderText="Apellidos" ItemStyle-Width="100" >      
                        <ItemStyle Width="100px"></ItemStyle>
                    </asp:BoundField>
                    <asp:BoundField DataField="Telefono" HeaderText="Teléfono" ItemStyle-Width="100" >      
                        <ItemStyle Width="100px"></ItemStyle>
                    </asp:BoundField>
                    <asp:BoundField DataField="Direccion" HeaderText="Dirección" ItemStyle-Width="100" >      
                        <ItemStyle Width="100px"></ItemStyle>
                    </asp:BoundField>
                    <asp:BoundField DataField="Correo" HeaderText="Correo" ItemStyle-Width="100" >      
                        <ItemStyle Width="100px"></ItemStyle>
                    </asp:BoundField>
                </Columns>  
                    <HeaderStyle BackColor="#3399ff" ForeColor="White"></HeaderStyle>
                    <RowStyle HorizontalAlign="Center" />
            </asp:gridview>
            <br />
            <br />
            <br />
        </ContentTemplate>
</asp:Content>
