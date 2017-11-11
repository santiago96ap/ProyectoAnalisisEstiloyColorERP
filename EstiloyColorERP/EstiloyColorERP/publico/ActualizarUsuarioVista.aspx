<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ActualizarUsuarioVista.aspx.cs" Inherits="EstiloyColorERP.publico.ActualizarUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <contenttemplate>
            <br />
            <br />
        <section id="formulario1">
           <div id="divi1">
                
                <asp:Label ID="Label3" CssClass="agileits-title" runat="server" Text="Actualizar  Usuario"></asp:Label>
                <br />
                <br />
                <asp:Label ID="Label2" CssClass="col-sm-2 control-label" runat="server" Text="Usuario"></asp:Label>
                <asp:TextBox ID="TbFechaInicio"  type="date" CssClass="form-control1" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="btnBuscar" runat="server"  CssClass="btn btn-info" Text="Buscar" OnClick="btnBuscar_Click"  />
                <br />
                <br />
                    <asp:GridView ID="gvUsuarios" CssClass="table table-hover" runat="server" RowHeaderColumn="Usuarios" DataKeyNames="ID" OnRowDeleting="DeleteRowButton_Click" OnSelectedIndexChanged="gvGastos_SelectedIndexChanged">
                        <Columns>
                            <asp:CommandField HeaderText="Acción" ShowDeleteButton="True" DeleteText="Seleccionar"/>                
                        </Columns>            
                    </asp:GridView>
              </div>
             <br />
            <br />
         </section>
        <br />
            <br />
        <section id="formulario">  
            
            <div id="divi">
                <asp:Label ID="lblID" CssClass="col-sm-2 control-label" runat="server" Text="Usuario"></asp:Label>
                <asp:TextBox ID="tbUsuario" CssClass="form-control1"  runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="lblFecha" CssClass="col-sm-2 control-label" runat="server" Text="Nombre"></asp:Label>
                <asp:TextBox ID="tbNombre"  type="text" CssClass="form-control1" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="lblHora" CssClass="col-sm-2 control-label" runat="server" Text="Apellidos"></asp:Label>
                <asp:TextBox ID="tbApellidos" type="text" CssClass="form-control1" runat="server"></asp:TextBox>
                <br />
                <br />            
                <asp:Label ID="LblConcepto" CssClass="col-sm-2 control-label" runat="server" Text="Contraseña"></asp:Label>
                <asp:TextBox ID="tbPass" type="password" CssClass="form-control1" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="lblTotal" CssClass="col-sm-2 control-label" runat="server" Text="e-mail"></asp:Label>
                <asp:TextBox ID="tbTotal" type="email" CssClass="form-control1"  runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label4" CssClass="col-sm-2 control-label" runat="server" Text="Rol"></asp:Label>
                <asp:dropdownlist ID="ddTipoServicio" CssClass="form-dropdownlist" runat="server"></asp:dropdownlist>
                <br />
                <br /> 
                <asp:Button ID="btnActualizar" runat="server"  CssClass="btn btn-info" Text="Actualizar" OnClick="btnActualizar_Click1" />
                <br />
                <br />
                </div>
            </section>
    </contenttemplate>


</asp:Content>
