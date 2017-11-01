<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ObtenerIngresosView.aspx.cs" Inherits="EstiloyColorERP.publico.ObtenerIngresosView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

      <contenttemplate>
            <br />
            <br />
        <section id="formulario1">
           <div id="divi1">
                <asp:Label ID="Label3" CssClass="agileits-title" runat="server" Text="Obtener Ingresos"></asp:Label>
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
                <asp:Button ID="Button1" runat="server"  CssClass="btn btn-info" Text="Buscar" OnClick="Button1_Click"  />
                <br />
                <br />
                <asp:GridView ID="GridView1" CssClass="table table-hover" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged1" > </asp:GridView>
              </div>
             <br />
            <br />
         </section>
    </contenttemplate>
    

</asp:Content>
