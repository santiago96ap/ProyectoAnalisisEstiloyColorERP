using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DOMAIN;
using BUSINESS;
using System.Data;

namespace EstiloyColorERP
{
    public partial class EliminarVentaView : System.Web.UI.Page
    {
        private VentaBusiness ventabusiness;
        private LinkedList<Venta> ventas;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.ventabusiness = new VentaBusiness();
        }//Page_Load

        protected void DeleteRowButton_Click(object sender, GridViewDeleteEventArgs e)
        {
            this.myModal.Attributes["class"] = "modal fade in";
            this.myModal.Attributes["style"] = "display: block;";
            Session["id"] = this.gvVentas.DataKeys[e.RowIndex].Value.ToString();
        }//btnBuscar_Click

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            this.myModal.Attributes["class"] = "modal fade";
            this.myModal.Attributes["style"] = "display: none;";
            ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.error('Se canceló la eliminación')", true);
        }//CancelarButton_Click

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            this.myModal.Attributes["class"] = "modal fade";
            this.myModal.Attributes["style"] = "display: none;";
            Venta venta = new Venta();
            venta.Id = int.Parse(Session["id"].ToString());
            if (this.ventabusiness.eliminarVenta(venta))
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.success('La venta se eliminó exitosamente')", true);
            }
            else {
                ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.error('Se ha producido un error al procesar la solicitud')", true);
            }//saber si se elimino correctamente
            reiniciarModulo();
        }//ConfirmarButton_Click

        protected void cargarTodos(String rol)
        {
            this.ventas = this.ventabusiness.obtenerVentasEliminar(tbFechaInicio.Text, tbFechaFinal.Text);
            DataTable table = new DataTable("Ventas");
            table.Columns.Add(new DataColumn("Id", typeof(string)));
            table.Columns.Add(new DataColumn("Fecha", typeof(string)));
            table.Columns.Add(new DataColumn("Hora", typeof(string)));
            table.Columns.Add(new DataColumn("Teléfono Cliente", typeof(string)));
            table.Columns.Add(new DataColumn("Servicio", typeof(string)));
            table.Columns.Add(new DataColumn("Pago", typeof(string)));
            table.Columns.Add(new DataColumn("Usuario", typeof(string)));
            table.Columns.Add(new DataColumn("SubTotal", typeof(string)));
            table.Columns.Add(new DataColumn("Total", typeof(string)));
            foreach (Venta ventaActual in this.ventas)
            {
                if (this.rbCliente.Checked)
                {
                    if (ventaActual.Cliente.Equals(this.tbDatos.Text))
                    {
                        DataRow row = table.NewRow();
                        row["Id"] = ventaActual.Id;
                        row["Fecha"] = ventaActual.Fecha;
                        row["Hora"] = ventaActual.Hora;
                        row["Teléfono Cliente"] = ventaActual.Cliente;
                        row["Servicio"] = ventaActual.TipoServicio;
                        row["Pago"] = ventaActual.TipoPago;
                        row["Usuario"] = ventaActual.Vendedor;
                        row["SubTotal"] = ventaActual.SubTotal;
                        row["Total"] = ventaActual.Total;
                        table.Rows.Add(row);
                    }//Validar apartados del cliente indicado
                }
                else if (this.rbFactura.Checked)
                {
                    if (ventaActual.Id == int.Parse(this.tbDatos.Text))
                    {
                        DataRow row = table.NewRow();
                        row["Id"] = ventaActual.Id;
                        row["Fecha"] = ventaActual.Fecha;
                        row["Hora"] = ventaActual.Hora;
                        row["Teléfono Cliente"] = ventaActual.Cliente;
                        row["Servicio"] = ventaActual.TipoServicio;
                        row["Pago"] = ventaActual.TipoPago;
                        row["Usuario"] = ventaActual.Vendedor;
                        row["SubTotal"] = ventaActual.SubTotal;
                        row["Total"] = ventaActual.Total;
                        table.Rows.Add(row);
                    }//Validar apartados del cliente indicado
                }
                else if (this.rbVendedor.Checked)
                {
                    if (ventaActual.Vendedor.Equals(this.tbDatos.Text))
                    {
                        DataRow row = table.NewRow();
                        row["Id"] = ventaActual.Id;
                        row["Fecha"] = ventaActual.Fecha;
                        row["Hora"] = ventaActual.Hora;
                        row["Teléfono Cliente"] = ventaActual.Cliente;
                        row["Servicio"] = ventaActual.TipoServicio;
                        row["Pago"] = ventaActual.TipoPago;
                        row["Usuario"] = ventaActual.Vendedor;
                        row["SubTotal"] = ventaActual.SubTotal;
                        row["Total"] = ventaActual.Total;
                        table.Rows.Add(row);
                    }//Validar apartados del cliente indicado
                }
        }//foreach para recorrer los clientes que estan en la DB
            this.gvVentas.DataSource = table;
            this.gvVentas.DataBind();
        }//cargarTodos

        protected void reiniciarModulo()
        {
            this.tbDatos.Text = "";
            this.tbFechaInicio.Text = "";
            this.tbFechaFinal.Text = "";
            this.gvVentas.DataSource = null;
            this.gvVentas.DataBind();
        }//reiniciarModulo

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            cargarTodos(this.tbDatos.Text);
        }//btnBuscar_Click
    }//class
}//namespace