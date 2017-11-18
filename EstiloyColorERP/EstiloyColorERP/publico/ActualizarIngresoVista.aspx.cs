using BUSINESS;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EstiloyColorERP.publico
{
    public partial class ActualizarIngresoView : System.Web.UI.Page
    {
        private IngresoBusiness ib = new IngresoBusiness();
        private LinkedList<Ingreso> ingresos;
        protected void Page_Load(object sender, EventArgs e)
        {

        }//Page_Load

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }//GridView1_SelectedIndexChanged

        /// <summary>
        /// Este método cargará la información en  el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button1_Click(object sender, EventArgs e)
        {
            cargarDatos();

        }//Button1_Click

        /// <summary>
        /// Carga los datos en el GridView
        /// </summary>
        protected void cargarDatos()
        {
            this.ingresos = this.ib.obtenerIngreso(TbFechaInicio.Text, TbFechaFinal.Text);
            DataTable table = new DataTable("Tabla1");
            table.Columns.Add(new DataColumn("ID", typeof(int)));
            table.Columns.Add(new DataColumn("Fecha", typeof(string)));
            table.Columns.Add(new DataColumn("Hora", typeof(string)));
            table.Columns.Add(new DataColumn("Concepto", typeof(string)));
            table.Columns.Add(new DataColumn("Monto", typeof(float)));
            table.Columns.Add(new DataColumn("Usuario", typeof(string)));
            foreach (var item in ingresos)
            {
                DataRow row = table.NewRow();
                row["ID"] = item.Id;
                row["Fecha"] = item.Fecha.Split(' ')[0].ToString();
                row["Hora"] = item.Hora.Split('.')[0].ToString();
                row["Concepto"] = item.Concepto;
                row["Monto"] = item.Total;
                row["Usuario"] = item.Usuario;
                table.Rows.Add(row);
            }//foreach
            gvIngresos.DataSource = table;
            gvIngresos.DataBind();

            this.tbID.Text = "";
            this.tbID.Enabled = false;//no se puede modificar el ID del ingreso
            this.tbFecha.Text = "";
            this.tbHora.Text = "";
            this.tbConcepto.Text = "";
            this.tbTotal.Text = "";
        }//cargarDatos

        /// <summary>
        /// Este método realizará la selección  de una fila para cargarla en el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void DeleteRowButton_Click(object sender, GridViewDeleteEventArgs e)
        {
            int idIngreso = int.Parse(this.gvIngresos.DataKeys[e.RowIndex].Value.ToString());//(id)  el cual se cargarán y modificarán los datos
            
            this.ib = new IngresoBusiness();
            this.ingresos = null;
            this.ingresos = this.ib.obtenerIngreso(TbFechaInicio.Text, TbFechaFinal.Text);

            foreach (Ingreso ingresoActual in this.ingresos) //buscar los datos seleccionados y mostrarlos en los campos de texto
            {
                if (ingresoActual.Id == idIngreso)//se buscan los datos
                {
                    //se desgrana la fecha para luego darle formato
                    String[] fecha = ingresoActual.Fecha.ToString().Split(' ');//se obtiene la fecha
                    String[] datos = fecha[0].ToString().Split('/');//se obtneien las partes de la fecha día, mes, año
                    String fechaLista = "";
                    if (int.Parse(datos[0]) < 10 && int.Parse(datos[1]) < 10)
                    {
                        fechaLista = datos[2] + '-' + '0' + datos[1] + '-' + '0' + datos[0];// la fecha se debe acomodar a un formato nuevo para mostrarse
                    }
                    else if (int.Parse(datos[0]) < 10)
                    {
                        fechaLista = datos[2] + '-' + datos[1] + '-' + '0' + datos[0];// la fecha se debe acomodar a un formato nuevo para mostrarse
                    }
                    else if (int.Parse(datos[1]) < 10)
                    {
                        fechaLista = datos[2] + '-' + '0' + datos[1] + '-' + datos[0];// la fecha se debe acomodar a un formato nuevo para mostrarse
                    }
                    else
                    {
                        fechaLista = datos[2] + '-' + datos[1] + '-' + datos[0];// la fecha se debe acomodar a un formato nuevo para mostrarse
                    }//if-else

                    String[] hora = ingresoActual.Hora.ToString().Split('.');//se obtiene la hora
                    String horaC = hora[0];// Se almacena lo deseado
                    String[] horaCa = horaC.Split(':');
                    String horaLista = horaCa[0] + ":" + horaCa[1];

                    //se llenan los campos para la posterior edición
                    this.tbID.Text = idIngreso + "";
                    this.tbID.Enabled = false;//no se puede modificar el ID
                    this.tbFecha.Text = fechaLista.ToString();
                    this.tbHora.Text = horaLista.ToString();
                    this.tbConcepto.Text = ingresoActual.Concepto;
                    this.tbTotal.Text = ingresoActual.Total+"";
                    this.tbFecha.Enabled = true;
                    this.tbHora.Enabled = true;
                    this.tbConcepto.Enabled = true;
                    this.tbTotal.Enabled = true;
                    this.btnActualizar.Enabled = true;
                }
            }//foreach

        }//btnAccion

        /// <summary>
        /// Este método actualizará la información que se encuentra en el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(this.tbID.Text) || String.IsNullOrWhiteSpace(this.tbFecha.Text) || String.IsNullOrWhiteSpace(this.tbHora.Text) || String.IsNullOrWhiteSpace(this.tbConcepto.Text) || String.IsNullOrWhiteSpace(this.tbTotal.Text))
            {//si existe un tb en blanco se indica al usuario y no se aplica ningún cambio
                ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.error('Error, campos en blanco')", true);
            }
            else
            {
                this.ib = new IngresoBusiness();

                Ingreso ingresoNuevo = new Ingreso(int.Parse(tbID.Text.ToString()),tbFecha.Text.ToString(),tbHora.Text.ToString(),tbConcepto.Text.ToString(),float.Parse(tbTotal.Text.ToString()),"u");

                bool respuesta = this.ib.actualizarIngreso(ingresoNuevo);

                if (respuesta)// Si se actualiza el usuario se recargan los datos y se dejan los tb en blanco
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.success('El ingreso se actualizó exitosamente')", true);
                    //dejar los campos de texto en blanco
                    this.tbID.Text = "";
                    this.tbID.Enabled = false;//no se puede modificar el ID del ingreso
                    this.tbFecha.Text = "";
                    this.tbHora.Text = "";
                    this.tbConcepto.Text = "";
                    this.tbTotal.Text = "";
                    this.tbFecha.Enabled = false;
                    this.tbHora.Enabled = false;
                    this.tbConcepto.Enabled = false;
                    this.tbTotal.Enabled = false;
                    this.btnActualizar.Enabled = false;
                    cargarDatos();                    
                }//if
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.error('Se ha producido un error al procesar la solicitud')", true);
                }//else

            }//else - no hay datos en blanco
        }//controlador de actualizarIngreso
    }//class
}//namespce