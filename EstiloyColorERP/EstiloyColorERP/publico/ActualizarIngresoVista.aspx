<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ActualizarIngresoVista.aspx.cs" Inherits="EstiloyColorERP.publico.ActualizarIngresoView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <contenttemplate>
            <br />
            <br />
        <section id="formulario1">
           <div id="divi1">
                
                <asp:Label ID="Label3" CssClass="agileits-title" runat="server" Text="Actualizar Ingreso"></asp:Label>
                <br />
                <br />
                <asp:Label ID="Label2" CssClass="col-sm-2 control-label" runat="server" Text="Fecha Inicio"></asp:Label>
                <asp:TextBox ID="TbFechaInicio"  type="date" CssClass="form-control1" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label1" CssClass="col-sm-2 control-label" runat="server" Text="Fecha Final"></asp:Label>
                <asp:TextBox ID="TbFechaFinal"  type="date" CssClass="form-control1" runat="server"></asp:TextBox>
                 <br />
                  <br />
                <asp:Button ID="Button1" runat="server"  CssClass="btn btn-info" Text="Buscar" OnClick="Button1_Click" />
                <br />
                <br />
                    <asp:GridView ID="gvIngresos" CssClass="table table-hover" runat="server" RowHeaderColumn="Ingresos" DataKeyNames="ID" OnRowDeleting="DeleteRowButton_Click">
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
                <asp:Label ID="lblFecha" CssClass="col-sm-2 control-label" runat="server" Text="Fecha"></asp:Label>
                <asp:TextBox ID="tbFecha"  type="date" CssClass="form-control1" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="lblHora" CssClass="col-sm-2 control-label" runat="server" Text="Hora"></asp:Label>
                <asp:TextBox ID="tbHora" type="time" CssClass="form-control1" runat="server"></asp:TextBox>
                <br />
                <br />            
                <asp:Label ID="LblConcepto" CssClass="col-sm-2 control-label" runat="server" Text="Concepto"></asp:Label>
                <asp:TextBox ID="tbConcepto" CssClass="form-control1" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="lblTotal" CssClass="col-sm-2 control-label" runat="server" Text="Total"></asp:Label>
                <asp:TextBox ID="tbTotal" CssClass="form-control1"  runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="btnActualizar" runat="server"  CssClass="btn btn-info" Text="Actualizar" OnClick="btnActualizar_Click" />
                <br />
                <br />
                </div>
            </section>
    </contenttemplate>

</asp:Content>
