<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ActualizarProductoView.aspx.cs" Inherits="EstiloyColorERP.publico.ActualizarProductoView" %>

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
            <div id="forms" class="grid_3 grid_4">
                <h3 class="w3ls-hdg"> Actualizar Producto</h3>
                <div class="tab-content">
                    <div class="tab-pane active" id="horizontal-form">
                        <form class="form-horizontal">
                            <div class="form-group">
                                <label for="focusedinput" class="col-sm-2 control-label">ID:</label>
                                <div class="col-sm-8">
                                    <input type="number" class="form-control1" id="txtID" placeholder="ID...">
                                </div>
                                <br />
                            </div>
                            <br />
                            <div class="form-group">
                                <label for="focusedinput" class="col-sm-2 control-label">Nombre:</label>
                                <div class="col-sm-8">
                                    <input type="text" class="form-control1" id="txtNombre" placeholder="Nombre...">
                                </div>
                                <br />
                            </div>
                            <br />
                            <div class="form-group">
                                <label for="focusedinput" class="col-sm-2 control-label">Descripción:</label>
                                <div class="col-sm-8">
                                    <input type="text" class="form-control1" id="txtDescripcion" placeholder="Descripción...">
                                </div>
                                <br />
                            </div>
                            <br />
                            <div class="form-group">
                                <label for="focusedinput" class="col-sm-2 control-label">Costo:</label>
                                <div class="col-sm-8">
                                    <input type="number" class="form-control1" id="txtCosto" placeholder="Costo...">
                                </div>
                                <br />
                            </div>
                            <br />
                            <div class="form-group">
                                <label for="focusedinput" class="col-sm-2 control-label">Precio:</label>
                                <div class="col-sm-8">
                                    <input type="number" class="form-control1" id="txtPrecio" placeholder="Precio...">
                                </div>
                                <br />
                            </div>
                            <br />
                            <div class="form-group">
                                <label for="focusedinput" class="col-sm-2 control-label">Cantidad:</label>
                                <div class="col-sm-8">
                                    <input type="number" class="form-control1" id="txtCantidad" placeholder="Cantidad...">
                                </div>
                                <br />
                            </div>
                            <br />
                            <div class="form-group">
                                <label for="selector1" class="col-sm-2 control-label">Categoría</label>
                                <div class="col-sm-8">
                                    <select name="selector1" id="selector1" class="form-control1">
                                        <option>Categoria 1</option>
                                        <option>Categoria 2</option>
                                    </select>
                                </div>
                                <br />
                            </div>
                            <br />
                            <div class="form-group">
                                <label for="selector1" class="col-sm-2 control-label">Proveedor</label>
                                <div class="col-sm-8">
                                    <select name="selector1" id="selector2" class="form-control1">
                                        <option>Proveedor 1</option>
                                        <option>Proveedor 2</option>
                                    </select>
                                </div>
                                <br />
                            </div>
                            <br />

                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

                            <button type="button" class="btn btn-info">Actualizar</button>

                        </form>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
