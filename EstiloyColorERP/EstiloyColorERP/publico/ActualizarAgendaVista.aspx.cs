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
        private ClienteBusiness clienteBusiness = new ClienteBusiness();
        private LinkedList<Agenda> actividades;
        private LinkedList<Cliente> clientes;
        private static String horaActividad;//Este es String es para seleccionar la hora de Actividad de la tabla
        private static String fechaActividad;//Este es String es para seleccionar la fecha de Actividad de la tabla
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.tbFecha.Enabled = false;
                this.tbHora.Enabled = false;
            }//!IsPostBack

        }//Page_Load


        /// <summary>
        /// El siguiente metodo carga los datos que se traen de la base de datos en un GridView
        /// </summary>
        protected void cargarDatos()
        {

            this.actividades = this.agendaBusiness.obtenerAgendasFecha(TbFechaInicio.Text);
            DataTable table = new DataTable("Agenda");
            table.Columns.Add(new DataColumn("Fecha y Hora", typeof(string)));
            table.Columns.Add(new DataColumn("Actividad", typeof(string)));
            table.Columns.Add(new DataColumn("Dirección", typeof(string)));
            table.Columns.Add(new DataColumn("Cliente", typeof(string)));
            foreach (var item in actividades)
            {
                DataRow row = table.NewRow();
                row["Fecha y Hora"] = item.Fecha + ","+ item.Hora;
                row["Actividad"] = item.Actividad;
                row["Dirección"] = item.Direccion;
                row["Cliente"] = item.Cliente;
                table.Rows.Add(row);
            }//foreach
            gvGastos.DataSource = table;
            gvGastos.DataBind();


            this.tbHora.Text = "";
            this.tbActividad.Text = "";
            this.tbDireccion.Text = "";
            this.tbCliente.Text = "";
        }//cargarDatos

        /// <summary>
        /// El siguiente método realiza la acción de seleccionar cuando se escoge una fila del GridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void DeleteRowButton_Click(object sender, GridViewDeleteEventArgs e)
        {

            String [] fechaHora = this.gvGastos.DataKeys[e.RowIndex].Value.ToString().Split(',');//id de la actividad por el cual se cargarán y modificarán los datos


            fechaActividad = fechaHora[0].ToString();
            horaActividad = fechaHora[1].ToString();

            this.agendaBusiness = new AgendaBusiness();
            this.actividades = null;
            this.actividades = this.agendaBusiness.obtenerAgendasFecha(TbFechaInicio.Text);

            foreach (Agenda gActual in this.actividades) //buscar los datos seleccionados y mostrarlos en los campos de texto
            {
                if (gActual.Fecha .Equals(fechaActividad) && gActual.Hora.Equals(horaActividad))//se buscan los datos
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

        /// <summary>
        /// Este método es para actualizar los datos que tienen en la vista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        protected void btnActualizar_Click1(object sender, EventArgs e)
        {
            this.clientes = this.clienteBusiness.obtenerClientes();
            bool flag = false;
            if (String.IsNullOrWhiteSpace(this.tbActividad.Text) || String.IsNullOrWhiteSpace(this.tbFecha.Text) || String.IsNullOrWhiteSpace(this.tbCliente.Text) || String.IsNullOrWhiteSpace(this.tbHora.Text))
            {//si existe un tb en blanco se indica la agenda y no se aplica ningún cambio
                ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.error('Error, campos en blanco')", true);
            }
            else
            {
                foreach (Cliente clienteActual in this.clientes)
                {
                    if (clienteActual.Telefono.Equals(this.tbCliente.Text))
                    {
                        flag = true;
                    }//if para validar que el cliente ingresado exista
                }//For para recorrer los clientes que estan en el sistema
                if (flag)
                {
                    bool respuesta = this.agendaBusiness.actualizarAgenda(
                    new Agenda(fechaActividad, horaActividad, tbFecha.Text, tbHora.Text, tbActividad.Text, tbDireccion.Text, tbCliente.Text));

                    if (respuesta)// Si se actualiza el agenda se recargan los datos y se dejan los tb en blanco
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
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.error('El cliente ingresado no existe')", true);
                }//if-else para identificar si se encontro el cliente
            }//else - no hay datos en blanco

        }// btnActualizar_Click

        /// <summary>
        /// En este metodo lo que hará es cuando se selecciona una fecha para poder mandar el dato para poder cargar el GridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button1_Click(object sender, EventArgs e)
        {
            cargarDatos();
        }//Button1_Click

    }//class
}//namespace