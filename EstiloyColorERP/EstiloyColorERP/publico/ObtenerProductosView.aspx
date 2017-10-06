<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ObtenerProductosView.aspx.cs" Inherits="EstiloyColorERP.publico.ObtenerProductosView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="codes about">
        <div class="container">

            <div class="table-responsive">
                <div class="form-group">
                    <label for="selector1" class="col-sm-2 control-label">Categoría</label>
                    <div class="col-sm-8">
                        <select name="selector1" id="selector2" class="form-control1">
                            <option>1</option>
                            <option>2</option>
                        </select>
                    </div>
                    <br />
                </div>
                            <br />
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
         

        </div>
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <button type="button" class="btn btn-info">Buscar</button>
    </div>
</asp:Content>
