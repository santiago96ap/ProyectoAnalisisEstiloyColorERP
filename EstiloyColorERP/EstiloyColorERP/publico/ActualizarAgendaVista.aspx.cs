using BUSINESS;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EstiloyColorERP
{
    public partial class ActualizarAgendaView : System.Web.UI.Page
    {
        private AgendaBusiness agendaBusiness = new AgendaBusiness();
        private LinkedList<Agenda> actividades;


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
            }//!IsPostBack

        }//Page_Load

        protected void cargarDatos()
        {

            this.actividades = this.agendaBusiness.obtenerAgendasFecha(TbFechaInicio.Text);
            DataTable table = new DataTable("Agenda");
            table.Columns.Add(new DataColumn("Fecha y Hora", typeof(string)));
            table.Columns.Add(new DataColumn("Hora", typeof(string)));
            table.Columns.Add(new DataColumn("Actividad", typeof(string)));
            table.Columns.Add(new DataColumn("Dirección", typeof(float)));
            table.Columns.Add(new DataColumn("Cliente", typeof(string)));
            foreach (var item in actividades)
            {
                DataRow row = table.NewRow();
                row["Fecha"] = item.Fecha + ","+ item.Hora;
                row["Actividad"] = item.Actividad;
                row["Dirección"] = item.Direccion;
                row["Cliente"] = item.Cliente;
                table.Rows.Add(row);
            }//foreach
            gvGastos.DataSource = table;
            gvGastos.DataBind();

            this.tbFecha.Text = "";
            this.tbHora.Text = "";
            this.tbActividad.Text = "";
            this.tbDireccion.Text = "";
            this.tbCliente.Text = "";
        }//cargarDatos

        protected void DeleteRowButton_Click(object sender, GridViewDeleteEventArgs e)
        {
            String fechaActividad = this.gvGastos.DataKeys[e.RowIndex].Value.ToString();//email (id) del proveedor por el cual se cargarán y modificarán los datos

            this.agendaBusiness = new AgendaBusiness();
            this.actividades = null;
            this.actividades = this.agendaBusiness.obtenerAgendasFecha(TbFechaInicio.Text);

            foreach (Agenda gActual in this.actividades) //buscar los datos del proveedor seleccionado y mostrarlos en los campos de texto
            {
                if (gActual.Fecha == fechaActividad)//se buscan los datos
                {
                    //se desgrana la fecha para luego darle formato
                    String[] fecha = gActual.Fecha.ToString().Split(' ');//se obtiene la fecha
                    String[] datos = fecha[0].ToString().Split('/');//se obtneien las partes de la fecha día, mes, año

                    String fechaLista = datos[2] + '-' + datos[1] + '-' + datos[0];// la fecha se debe acomodar a un formato nuevo para mostrarse

                    //se llenan los campos para la posterior edición
                    this.tbFecha.Text = fechaLista.ToString();
                    this.tbHora.Text = gActual.Hora;
                    this.tbDireccion.Text = gActual.Direccion;
                    this.tbActividad.Text = gActual.Actividad;
                    this.tbCliente.Text = gActual.Cliente;

                }
            }//foreach

        }//btnAccion

        protected void btnActualizar_Click1(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(this.tbActividad.Text) || String.IsNullOrWhiteSpace(this.tbFecha.Text) || String.IsNullOrWhiteSpace(this.tbCliente.Text) || String.IsNullOrWhiteSpace(this.tbHora.Text))
            {//si existe un tb en blanco se indica al usuario y no se aplica ningún cambio
                ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.error('Error en los datos ingresados')", true);
            }
            else
            {
                
                bool respuesta = this.agendaBusiness.actualizarAgenda(new Agenda());

                if (respuesta)// Si se actualiza el usuario se recargan los datos y se dejan los tb en blanco
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.success('Se actualizó exitosamente')", true);
                    //dejar los campos de texto en blanco
                    this.tbFecha.Text = "";
                    this.tbHora.Text = "";
                    this.tbDireccion.Text = "";
                    this.tbActividad.Text = "";
                    this.tbCliente.Text = "";
                    cargarDatos();
                }//if
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.error('Se ha producido un error al procesar la solicitud')", true);
                }//else

            }//else - no hay datos en blanco

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            cargarDatos();
        }

    }//class
}//namespace