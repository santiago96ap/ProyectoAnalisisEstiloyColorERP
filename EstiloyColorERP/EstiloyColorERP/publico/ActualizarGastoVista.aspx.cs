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
    public partial class ActualizarGastoVista: System.Web.UI.Page
    {
        private GastoBusiness gastosBusiness = new GastoBusiness();
        private LinkedList<Gasto> gastos;

        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.ddTipoServicio.Items.Add(new ListItem("Gasto", "gasto"));
                this.ddTipoServicio.Items.Add(new ListItem("Compra", "compra"));
            }

        }//Page_Load

        protected void cargarDatos()
        {
            
            this.gastos = this.gastosBusiness.obtenerGastos(TbFechaInicio.Text, TbFechaFinal.Text);
            DataTable table = new DataTable("Tabla1");
            table.Columns.Add(new DataColumn("ID", typeof(int)));
            table.Columns.Add(new DataColumn("Fecha", typeof(string)));
            table.Columns.Add(new DataColumn("Hora", typeof(string)));
            table.Columns.Add(new DataColumn("Concepto", typeof(string)));
            table.Columns.Add(new DataColumn("Monto", typeof(float)));
            table.Columns.Add(new DataColumn("Usuario", typeof(string)));
            table.Columns.Add(new DataColumn("Servicio", typeof(string)));
            foreach (var item in gastos)
            {
                DataRow row = table.NewRow();
                row["ID"] = item.Id;
                row["Fecha"] = item.Fecha;
                row["Hora"] = item.Hora;
                row["Concepto"] = item.Concepto;
                row["Monto"] = item.Total;
                row["Usuario"] = item.Vendedor;
                row["Servicio"] = item.Servicio;
                table.Rows.Add(row);
            }//foreach
            gvGastos.DataSource = table;
            gvGastos.DataBind();

            this.tbID.Text = "";
            this.tbID.Enabled = false;//no se puede modificar el ID del ingreso
            this.tbFecha.Text = "";
            this.tbHora.Text = "";
            this.tbConcepto.Text = "";
            this.tbTotal.Text = "";
        }//cargarDatos

        protected void DeleteRowButton_Click(object sender, GridViewDeleteEventArgs e)
        {
            int idIngreso = int.Parse(this.gvGastos.DataKeys[e.RowIndex].Value.ToString());//email (id) del proveedor por el cual se cargarán y modificarán los datos
         
            this.gastosBusiness = new GastoBusiness();
            this.gastos = null;
            this.gastos = this.gastosBusiness.obtenerGastos(TbFechaInicio.Text, TbFechaFinal.Text);

            foreach (Gasto gActual in this.gastos) //buscar los datos del proveedor seleccionado y mostrarlos en los campos de texto
            {
                if (gActual.Id == idIngreso)//se buscan los datos
                {
                    //se desgrana la fecha para luego darle formato
                    String[] fecha = gActual.Fecha.ToString().Split(' ');//se obtiene la fecha
                    String[] datos = fecha[0].ToString().Split('/');//se obtneien las partes de la fecha día, mes, año

                    String fechaLista = datos[2] + '-' + datos[1] + '-' + datos[0];// la fecha se debe acomodar a un formato nuevo para mostrarse

                    //se llenan los campos para la posterior edición
                    this.tbID.Text = idIngreso + "";
                    this.tbID.Enabled = false;//no se puede modificar el ID del ingreso
                    this.tbFecha.Text = fechaLista.ToString();
                    this.tbHora.Text = gActual.Hora;
                    this.tbConcepto.Text = gActual.Concepto;
                    this.tbTotal.Text = gActual.Total + "";
                   

                }
            }//foreach

        }//btnAccion

        protected void btnActualizar_Click1(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(this.tbID.Text) || String.IsNullOrWhiteSpace(this.tbFecha.Text) || String.IsNullOrWhiteSpace(this.tbConcepto.Text) || String.IsNullOrWhiteSpace(this.tbTotal.Text))
            {//si existe un tb en blanco se indica al usuario y no se aplica ningún cambio
                ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.error('Error en los datos ingresados')", true);
            }
            else
            {
             


                bool respuesta = this.gastosBusiness.editarGasto(new Gasto(int.Parse(tbID.Text.ToString()), tbFecha.Text, tbHora.Text, tbConcepto.Text, float.Parse(tbTotal.Text.ToString()), Session["usuario"].ToString(), ddTipoServicio.SelectedItem.Value));

                if (respuesta)// Si se actualiza el usuario se recargan los datos y se dejan los tb en blanco
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.success('El gasto se actualizó exitosamente')", true);
                    //dejar los campos de texto en blanco
                    this.tbID.Text = "";
                    this.tbID.Enabled = false;//no se puede modificar el ID del ingreso
                    this.tbFecha.Text = "";
                    this.tbHora.Text = "";
                    this.tbConcepto.Text = "";
                    this.tbTotal.Text = "";
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