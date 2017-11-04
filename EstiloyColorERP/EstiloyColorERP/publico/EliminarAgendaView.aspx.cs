using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DOMAIN;
using BUSINESS;
using System.Web.Services;

namespace EstiloyColorERP
{
    public partial class EliminarAgendaView : System.Web.UI.Page
    {
        private AgendaBusiness agendabusiness;
        private LinkedList<Agenda> actividades;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.agendabusiness = new AgendaBusiness();
            cargarTodos();
        }//Page_Load

        protected void DeleteRowButton_Click(object sender, GridViewDeleteEventArgs e)
        {
            this.myModal.Attributes["class"] = "modal fade in";
            this.myModal.Attributes["style"] = "display: block;";
            String[] llave = this.gvActividades.DataKeys[e.RowIndex].Value.ToString().Split(' ');
            Session["fecha"] = llave[0];
            Session["hora"] = llave[1];
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
            Agenda agenda = new Agenda(Session["fecha"].ToString(), Session["hora"].ToString(), "", "", "");
            if (this.agendabusiness.eliminarAgenda(agenda))
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.success('La actividad se eliminó exitosamente')", true);
            }
            else {
                ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.error('Se ha producido un error al procesar la solicitud')", true);
            }//saber si se elimino correctamente
            cargarTodos();
        }//ConfirmarButton_Click

        protected void cargarTodos()
        {
            this.actividades = this.agendabusiness.obtenerAgendas();
            DataTable table = new DataTable("Actividades");
            table.Columns.Add(new DataColumn("Fecha y Hora", typeof(string)));
            table.Columns.Add(new DataColumn("Actividad", typeof(string)));
            table.Columns.Add(new DataColumn("Dirección", typeof(string)));
            table.Columns.Add(new DataColumn("Cliente", typeof(string)));
            foreach (Agenda agendaActual in this.actividades)
            {
                DataRow row = table.NewRow();
                row["Fecha y Hora"] = agendaActual.Fecha + " " + agendaActual.Hora;
                row["Actividad"] = agendaActual.Actividad;
                row["Dirección"] = agendaActual.Direccion;
                row["Cliente"] = agendaActual.Cliente;
                table.Rows.Add(row);
            }//foreach para recorrer los clientes que estan en la DB
            this.gvActividades.DataSource = table;
            this.gvActividades.DataBind();
        }//cargarTodos
    }//class
}//namespace