<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ObtenerIngresoView.aspx.cs" Inherits="EstiloyColorERP.publico.ObtenerIngresoView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="codes about">
        <div class="container">
            <div id="forms" class="grid_3 grid_4">
                <h3 class="w3ls-hdg">Obtener Ingreso</h3>
                <div class="tab-content">
                    <div class="tab-pane active" id="horizontal-form">
                        <form class="form-horizontal">
                            <div class="form-group">
                                <label for="focusedinput" class="col-sm-2 control-label">Fecha Inicio:</label>
                                <div class="col-sm-8">
                                    <input type="date" class="form-control1" id="txtFechaI" placeholder="fecha">
                                </div>
                                <br />
                            </div>
                            <br />
                            <div class="form-group">
                                <label for="focusedinput" class="col-sm-2 control-label">Fecha Final:</label>
                                <div class="col-sm-8">
                                    <input type="date" class="form-control1" id="txtFechaF" placeholder="fecha">
                                </div>
                                <br />
                            </div>
                            <br />
                            
                            

                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

                            <button type="button" class="btn btn-info">Buscar</button>
                      
                        </form>
                    </div>
                </div>
            </div>
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

        </div>
    </div>
</asp:Content>
