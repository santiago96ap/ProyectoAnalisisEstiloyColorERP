using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DOMAIN;
using BUSINESS;
using System.Data;

namespace EstiloyColorERP.publico
{
    public partial class EliminarApartadoView : System.Web.UI.Page
    {
        private ApartadoBusiness apartadobusiness;
        private LinkedList<Apartado> apartados;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.apartadobusiness = new ApartadoBusiness();
        }//Page_Load

        protected void DeleteRowButton_Click(object sender, GridViewDeleteEventArgs e)
        {
            this.myModal.Attributes["class"] = "modal fade in";
            this.myModal.Attributes["style"] = "display: block;";
            Session["id"] = this.gvApartados.DataKeys[e.RowIndex].Value.ToString();
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
            Apartado apartado = new Apartado();
            apartado.Id = int.Parse(Session["id"].ToString());
            if (this.apartadobusiness.eliminarApartado(apartado))
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.success('El apartado se eliminó exitosamente')", true);
            }
            else {
                ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.error('Se ha producido un error al procesar la solicitud')", true);
            }//saber si se elimino correctamente
            reiniciarModulo();
        }//ConfirmarButton_Click

        protected void cargarTodos(String cliente)
        {
            this.apartados = this.apartadobusiness.obtenerApartados();
            DataTable table = new DataTable("Apartados");
            table.Columns.Add(new DataColumn("Id", typeof(string)));
            table.Columns.Add(new DataColumn("Cliente", typeof(string)));
            table.Columns.Add(new DataColumn("Monto", typeof(string)));
            table.Columns.Add(new DataColumn("Abono", typeof(string)));
            table.Columns.Add(new DataColumn("Fecha Inicio", typeof(string)));
            table.Columns.Add(new DataColumn("Fecha Fin", typeof(string)));
            table.Columns.Add(new DataColumn("Estado", typeof(string)));
            table.Columns.Add(new DataColumn("Número de factura", typeof(string)));
            foreach (Apartado apartadoActual in this.apartados)
            {
                if (apartadoActual.IdCliente.Equals(cliente) && apartadoActual.Estado.Equals("activo"))
                {
                    DataRow row = table.NewRow();
                    row["Id"] = apartadoActual.Id;
                    row["Cliente"] = apartadoActual.IdCliente;
                    row["Monto"] = apartadoActual.Monto;
                    row["Abono"] = apartadoActual.Abono;
                    row["Fecha Inicio"] = apartadoActual.FechaInicio;
                    row["Fecha Fin"] = apartadoActual.FechaFinal;
                    row["Estado"] = apartadoActual.Estado;
                    row["Número de factura"] = apartadoActual.NumFactura;
                    table.Rows.Add(row);
                }//Validar apartados del cliente indicado
            }//foreach para recorrer los clientes que estan en la DB
            this.gvApartados.DataSource = table;
            this.gvApartados.DataBind();
        }//cargarTodos

        protected void reiniciarModulo()
        {
            this.tbCliente.Text = "";
            cargarTodos(this.tbCliente.Text);
        }//reiniciarModulo

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            cargarTodos(this.tbCliente.Text);
        }//btnBuscar_Click
    }//class
}//namespace