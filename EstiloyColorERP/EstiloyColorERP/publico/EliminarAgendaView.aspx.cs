using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DOMAIN;
using BUSINESS;

namespace EstiloyColorERP
{
    public partial class EliminarAgendaView : System.Web.UI.Page
    {
        private AgendaBusiness agendabusiness;
        private LinkedList<Agenda> actividades;
        protected void Page_Load(object sender, EventArgs e)
        {
            //cargar clientes en dropdown
            this.agendabusiness = new AgendaBusiness();
            this.actividades = this.agendabusiness.obtenerAgendas();
            cargarTodos();
        }//Page_Load

        protected void DeleteRowButton_Click(object sender, GridViewDeleteEventArgs e)
        {
            this.lblTitulo.Text = this.gvActividades.DataKeys[e.RowIndex].Value.ToString();
        }//btnBuscar_Click

        protected void cargarTodos()
        {
            DataTable table = new DataTable("Actividades");
            table.Columns.Add(new DataColumn("Fecha", typeof(string)));
            table.Columns.Add(new DataColumn("Hora", typeof(string)));
            table.Columns.Add(new DataColumn("Actividad", typeof(string)));
            table.Columns.Add(new DataColumn("Dirección", typeof(string)));
            table.Columns.Add(new DataColumn("Cliente", typeof(string)));
            foreach (Agenda agendaActual in this.actividades)
            {
                DataRow row = table.NewRow();
                row["Fecha"] = "12/12/12";
                row["Hora"] = "2:00";
                row["Actividad"] = "LALALALALA";
                row["Dirección"] = "Juan Viñas";
                row["Cliente"] = "11111111111";
                table.Rows.Add(row);
        }//foreach para recorrer los clientes que estan en la DB
                this.gvActividades.DataSource = table;
                this.gvActividades.DataBind();
        }//cargarTodos
    }//class
}//namespace