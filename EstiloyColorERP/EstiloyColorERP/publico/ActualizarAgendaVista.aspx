<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ActualizarAgendaVista.aspx.cs" Inherits="EstiloyColorERP.ActualizarAgendaView" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
         <contenttemplate>
            <br />
            <br />
        <section id="formulario1">
           <div id="divi1">
                
                <asp:Label ID="Label3" CssClass="agileits-title" runat="server" Text="Actualizar Agenda"></asp:Label>
                <br />
                <br />
                <asp:Label ID="Label2" CssClass="col-sm-2 control-label" runat="server" Text="Fecha Inicio"></asp:Label>
                <asp:TextBox ID="TbFechaInicio"  type="date" CssClass="form-control1" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="Button1" runat="server"  CssClass="btn btn-info" Text="Buscar" OnClick="Button1_Click" />
                <br />
                <br />
                    <asp:GridView ID="gvGastos" CssClass="table table-hover" runat="server" RowHeaderColumn="Agenda" DataKeyNames="Fecha y Hora" OnRowDeleting="DeleteRowButton_Click">
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
                <asp:Label ID="lblID" CssClass="col-sm-2 control-label" runat="server" Text="Fecha"></asp:Label>
                <asp:TextBox ID="tbFecha" type="date" CssClass="form-control1" runat="server" ></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="lblNombre" CssClass="col-sm-2 control-label" runat="server" Text="Hora"></asp:Label>
                <asp:TextBox ID="tbHora" type="time" CssClass="form-control1" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="LblDescripcion" CssClass="col-sm-2 control-label" runat="server" Text="Actividad"></asp:Label>
                <asp:TextBox ID="tbActividad" type="text" CssClass="form-control1" runat="server"></asp:TextBox>
                <br />
                <br />
                 <asp:Label ID="Label4" CssClass="col-sm-2 control-label" runat="server" Text="Dirección"></asp:Label>
                <asp:TextBox ID="tbDireccion" type="text" CssClass="form-control1"  runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label5" CssClass="col-sm-2 control-label" runat="server" Text="Cliente"></asp:Label>
                 <asp:TextBox ID="tbCliente" type="number" CssClass="form-control1" min="0" Text="1" runat="server"></asp:TextBox>
                <br />
                <br /> 
                <asp:Button ID="btnActualizar" runat="server"  CssClass="btn btn-info" Text="Actualizar" OnClick="btnActualizar_Click1" />
                <br />
                <br />
                </div>
            </section>
    </contenttemplate>
   

</asp:Content>
