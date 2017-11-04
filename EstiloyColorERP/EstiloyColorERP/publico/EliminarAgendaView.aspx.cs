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
            this.agendabusiness = new AgendaBusiness();
            cargarTodos();
        }//Page_Load

        protected void DeleteRowButton_Click(object sender, GridViewDeleteEventArgs e)
        {
            String [] llave = this.gvActividades.DataKeys[e.RowIndex].Value.ToString().Split(' ');
            String fecha = llave[0];
            String hora = llave[1];
            Agenda agenda = new Agenda(fecha,hora,"","","");
            this.agendabusiness.eliminarAgenda(agenda);
            cargarTodos();
        }//btnBuscar_Click

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