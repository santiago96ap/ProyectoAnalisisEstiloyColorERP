<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ObtenerGastoView.aspx.cs" Inherits="EstiloyColorERP.publico.ObtenerGastoView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="codes about">
        <div class="container">

            <div id="forms" class="grid_3 grid_4">
                <h3 class="w3ls-hdg">Obtener Gastos</h3>
                <div class="tab-content">
                    <div class="tab-pane active" id="horizontal-form">
                        <form class="form-horizontal">
                            <div class="form-group">
                                <label for="focusedinput" class="col-sm-2 control-label">Fecha:</label>
                                <div class="col-sm-8">
                                    <input type="date" class="form-control1" id="txtFecha" placeholder="fecha">
                                </div>
                                <br />
                            </div>
                            <br />
                            <div class="form-group">
                                <label for="focusedinput" class="col-sm-2 control-label">Hora:</label>
                                <div class="col-sm-8">
                                    <input type="time" class="form-control1" id="txtHora" placeholder="hora">
                                </div>
                                <br />
                            </div>
                            <br />
                            <div class="form-group">
                                <label for="focusedinput" class="col-sm-2 control-label">Concepto:</label>
                                <div class="col-sm-8">
                                    <input type="text" class="form-control1" id="txtConcepto" placeholder="Concepto...">
                                </div>
                                <br />
                            </div>
                            <br />
                            <div class="form-group">
                                <label for="focusedinput" class="col-sm-2 control-label">Monto:</label>
                                <div class="col-sm-8">
                                    <input type="number" class="form-control1" id="txtMonto" placeholder="Monto...">
                                </div>
                                <br />
                            </div>
                            <br />

                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

                            <button type="button" class="btn btn-info">Insertar</button>
                      
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
