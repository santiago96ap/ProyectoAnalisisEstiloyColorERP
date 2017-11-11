<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ActualizarOfertaVista.aspx.cs" Inherits="EstiloyColorERP.ActualizarOferta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <contenttemplate>
            <br />
            <br />
        <section id="formulario1">
           <div id="divi1">
                
                <asp:Label ID="Label3" CssClass="agileits-title" runat="server" Text="Actualizar Oferta"></asp:Label>
                <br />
                <br />
                <asp:Label ID="Label2" CssClass="col-sm-2 control-label" runat="server" Text="Producto"></asp:Label>
                <asp:TextBox ID="TbProducto"  type="text" CssClass="form-control1" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="Button1" runat="server"  CssClass="btn btn-info" Text="Buscar" OnClick="Button1_Click" />
                <br />
                <br />
                    <asp:GridView ID="gvOfertas" CssClass="table table-hover" runat="server" RowHeaderColumn="Ofertas" DataKeyNames="ID" OnRowDeleting="DeleteRowButton_Click" OnSelectedIndexChanged="gvGastos_SelectedIndexChanged">
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
                <asp:Label ID="lblID" CssClass="col-sm-2 control-label" runat="server" Text="ID"></asp:Label>
                <asp:TextBox ID="tbID" CssClass="form-control1"  runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="lblFecha" CssClass="col-sm-2 control-label" runat="server" Text="Fecha Inicio"></asp:Label>
                <asp:TextBox ID="tbFechaI"  type="date" CssClass="form-control1" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label1" CssClass="col-sm-2 control-label" runat="server" Text="Fecha final"></asp:Label>
                <asp:TextBox ID="tbFechaF"  type="date" CssClass="form-control1" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="lblHora" CssClass="col-sm-2 control-label" runat="server" Text="Descuento"></asp:Label>
                <asp:TextBox ID="tbDescuento" type="number" CssClass="form-control1" runat="server"></asp:TextBox>
                <br />
                <br />            
                <asp:Label ID="LblConcepto" CssClass="col-sm-2 control-label" runat="server" Text="Precio"></asp:Label>
                <asp:TextBox ID="tbPrecio" CssClass="form-control1" runat="server"></asp:TextBox>
                <br />
                <br />
                 <asp:Label ID="Label4" CssClass="col-sm-2 control-label" runat="server" Text="Producto"></asp:Label>
                <asp:TextBox ID="tbIDProducto" CssClass="form-control1" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="btnActualizar" runat="server"  CssClass="btn btn-info" Text="Actualizar" OnClick="btnActualizar_Click"/>
                <br />
                <br />
                </div>
            </section>
    </contenttemplate>



</asp:Content>
