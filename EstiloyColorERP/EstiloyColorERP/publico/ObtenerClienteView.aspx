<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ObtenerClienteView.aspx.cs" Inherits="EstiloyColorERP.ObtenerCliente" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <ContentTemplate>
            <section id="formulario1">
                <br />
                <br />
                <asp:Label ID="lblTitulo" CssClass="agileits-icons-title" runat="server" Text="Obtener Cliente"></asp:Label>
                <br />
                <br />
                <br />
                <asp:DropDownList ID="ddlBuscar" CssClass="from-dropdownlist" runat="server"></asp:DropDownList>
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
            </section>
        </ContentTemplate>
</asp:Content>
