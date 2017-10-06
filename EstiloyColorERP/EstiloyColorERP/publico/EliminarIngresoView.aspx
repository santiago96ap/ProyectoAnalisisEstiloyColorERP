<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EliminarIngresoView.aspx.cs" Inherits="EstiloyColorERP.publico.EliminarIngresoView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="codes about">
        <div class="container">
            <div class="table-responsive">
                <table class="table table-hover">
                    <thead>
                        <tr>
                            <th>Fecha</th>
                            <th>Hora</th>
                            <th>Concepto</th>
                            <th>total</th>
                            <th>Usuario</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>10/10/2017</td>
                            <td>10:00</td>
                            <td>ingreso</td>
                            <td>1000</td>
                            <td>adriana</td>
                        </tr>
                        <tr>
                            <td>10/10/2017</td>
                            <td>10:00</td>
                            <td>ingreso</td>
                            <td>1000</td>
                            <td>adriana</td>
                        </tr>
                        <tr>
                            <td>10/10/2017</td>
                            <td>10:00</td>
                            <td>ingreso</td>
                            <td>1000</td>
                            <td>adriana</td>
                        </tr>
                    </tbody>
                </table>
            </div>
            <br />
             <button type="button" class="btn btn-info">Eliminar</button>

    </div>
</asp:Content>
