<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ActualizarApartadoVista.aspx.cs" Inherits="EstiloyColorERP.ActualizarApartadoView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <ContentTemplate>
            <br />
            <br />
           
            <section id="formulario">
                 <asp:Label ID="lblITitulo" CssClass="agileits-title" runat="server" Text="Agregar Abono"></asp:Label>
                   <br />
                 <br />
                <div id="divi">
                    <asp:Label ID="lblCliente" CssClass="col-sm-2 control-label" runat="server" Text="Cliente:"></asp:Label>
                    <asp:TextBox ID="tbCliente" CssClass="form-control1" runat="server"></asp:TextBox>
                    <br /> 
                    <br />
                    <asp:Button ID="btnBuscar" CssClass="btn btn-info" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
                    <br /> 
                    <br />
                    <asp:GridView ID="gvCategorias" CssClass="table table-hover" runat="server" RowHeaderColumn="Apartados" DataKeyNames="ID" OnRowDeleting="DeleteRowButton_Click" Height="16px" Width="1091px" OnSelectedIndexChanged="gvCategorias_SelectedIndexChanged">
                        <AlternatingRowStyle BackColor="#EFEFEF" />
                        <Columns>
                            <asp:CommandField HeaderText="Acción" ShowDeleteButton="True" DeleteText="Seleccionar"/>                
                        </Columns>            
                        <HeaderStyle BackColor="#10C7BF"/>            
                    </asp:GridView>
                    <br /> 
                    <br />
                    <asp:Label ID="Label1" CssClass="col-sm-2 control-label" runat="server" Text="ID:"></asp:Label>
                    <asp:TextBox ID="tbID" CssClass="form-control1" runat="server"></asp:TextBox>
                    <br /> 
                    <br />
                    <asp:Label ID="lblAbono" CssClass="col-sm-2 control-label" runat="server" Text="Abono:"></asp:Label>
                    <asp:TextBox ID="tbAbono" CssClass="form-control1" runat="server"></asp:TextBox>
                </div>
                <div id="divi1">
                    <asp:Label ID="lblSaldo" CssClass="col-sm-2 control-label" runat="server" Text="Saldo:"></asp:Label>
                    <asp:TextBox ID="tbSaldo" CssClass="form-control1" runat="server"></asp:TextBox>
                </div>
                   <br />
                  <br />
                  <br />
                    <br />
                <asp:Button ID="btnActualizar" CssClass="btn btn-info" runat="server" Text="Abonar" OnClick="btnActualizar_Click1" />
            </section>
            <br />
            <br />
         
            <br />
            <br />
        </ContentTemplate>
</asp:Content>
