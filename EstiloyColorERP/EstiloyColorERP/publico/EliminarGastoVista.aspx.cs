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
    public partial class EliminarGastoView : System.Web.UI.Page
    {
        private GastoBusiness gastobusiness;
        private LinkedList<Gasto> gastos;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.gastobusiness = new GastoBusiness();
        }//Page_Load

        protected void DeleteRowButton_Click(object sender, GridViewDeleteEventArgs e)
        {
            this.myModal.Attributes["class"] = "modal fade in";
            this.myModal.Attributes["style"] = "display: block;";
            Session["id"] = this.gvGastos.DataKeys[e.RowIndex].Value.ToString();
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
            Gasto gasto = new Gasto();
            gasto.Id = int.Parse(Session["id"].ToString());
            if (this.gastobusiness.eliminarGasto(gasto))
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.success('El gasto se eliminó exitosamente')", true);
            }
            else {
                ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.error('Se ha producido un error al procesar la solicitud')", true);
            }//saber si se elimino correctamente
            reiniciarModulo();
        }//ConfirmarButton_Click

        protected void cargarTodos()
        {
            this.gastos = this.gastobusiness.obtenerGastos(tbFechaInicio.Text, tbFechaFinal.Text);
            DataTable table = new DataTable("Gastos");
            table.Columns.Add(new DataColumn("Id", typeof(string)));
            table.Columns.Add(new DataColumn("Fecha", typeof(string)));
            table.Columns.Add(new DataColumn("Hora", typeof(string)));
            table.Columns.Add(new DataColumn("Concepto", typeof(string)));
            table.Columns.Add(new DataColumn("Total", typeof(string)));
            table.Columns.Add(new DataColumn("Usuario", typeof(string)));
            table.Columns.Add(new DataColumn("Servicio", typeof(string)));
            foreach (Gasto gastoActual in this.gastos)
            {
                DataRow row = table.NewRow();
                row["Id"] = gastoActual.Id;
                row["Fecha"] = gastoActual.Fecha;
                row["Hora"] = gastoActual.Hora;
                row["Concepto"] = gastoActual.Concepto;
                row["Total"] = gastoActual.Total;
                row["Usuario"] = gastoActual.Vendedor;
                row["Servicio"] = gastoActual.Servicio;
                table.Rows.Add(row);
            }//foreach para recorrer los clientes que estan en la DB
            this.gvGastos.DataSource = table;
            this.gvGastos.DataBind();
        }//cargarTodos

        protected void reiniciarModulo()
        {
            this.tbFechaInicio.Text = "";
            this.tbFechaFinal.Text = "";
            this.gvGastos.DataSource = null;
            this.gvGastos.DataBind();
        }//reiniciarModulo

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            cargarTodos();
        }//btnBuscar_Click
    }//class
}//namespace