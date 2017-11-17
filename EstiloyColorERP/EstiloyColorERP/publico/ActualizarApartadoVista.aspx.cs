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
    public partial class ActualizarApartadoView : System.Web.UI.Page
    {
        private ApartadoBusiness apartadoBusiness;
        private LinkedList<Apartado> apartados;
        protected void Page_Load(object sender, EventArgs e)
        {

        }//page_load

        /// <summary>
        /// Este métdodo es para cargar la información necesaria del apartado de un cliente 
        /// </summary>

        protected void cargarInformacion()
        {
            this.apartadoBusiness = new ApartadoBusiness();
            this.apartados = this.apartadoBusiness.obtenerApartados();
            DataTable table = new DataTable("Apartados");

            table.Columns.Add(new DataColumn("id", typeof(int)));
            table.Columns.Add(new DataColumn("teléfono Cliente", typeof(string)));
            table.Columns.Add(new DataColumn("Saldo final", typeof(string)));
            table.Columns.Add(new DataColumn("Fecha de inicio", typeof(string)));
            table.Columns.Add(new DataColumn("Vencimiento", typeof(string)));
            table.Columns.Add(new DataColumn("Estado", typeof(string)));
            table.Columns.Add(new DataColumn("Número de factura asociado", typeof(int)));


            foreach (Apartado aActual in this.apartados)

            {
                DataRow row = table.NewRow();

                if (aActual.IdCliente.Equals(tbCliente.Text))
                {
                    row["id"] = aActual.Id;
                    row["teléfono Cliente"] = aActual.IdCliente;
                    row["Saldo final"] = aActual.Monto;
                    row["Fecha de inicio"] = aActual.FechaInicio;
                    row["Vencimiento"] = aActual.FechaFinal;
                    row["Estado"] = aActual.Estado;
                    row["Número de factura asociado"] = aActual.NumFactura;
                }//if
                    

                table.Rows.Add(row);
            }//foreach

            this.gvCategorias.DataSource = table;
            this.gvCategorias.DataBind();
        }//cargarInformacion

        /// <summary>
        /// Este método realizará la acción de seleccionar la fila del GridView 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void DeleteRowButton_Click(object sender, GridViewDeleteEventArgs e)
        {
            int ID = int.Parse(this.gvCategorias.DataKeys[e.RowIndex].Value.ToString());//(id) del apartado por el cual se cargarán y modificarán los datos
            this.tbID.Enabled = false;
            this.tbID.Text = ID.ToString();

            this.apartadoBusiness = new ApartadoBusiness();
            this.apartados = this.apartadoBusiness.obtenerApartados();

            foreach (Apartado cActual in this.apartados) //buscar los datos de la apartado seleccionado y mostrarlos en los campos de texto
            {
                if (cActual.Id == ID)//se buscan los datos
                {
                    this.tbSaldo.Text = cActual.Monto.ToString();
                    this.tbID.Text = cActual.Id.ToString();
                }//If
            }//foreach

        }//btnBuscar_Click

        protected void gvCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Este método  realizará la actualización de los datos que estpan en el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnActualizar_Click1(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(this.tbCliente.Text))
            {//si existe un tb en blanco se indica al usuario y no se aplica ningún cambio
                ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.error('Error en los datos ingresados')", true);
            }
            else
            {
                this.apartadoBusiness = new ApartadoBusiness();

                Apartado apartadoNuevo = new Apartado(int.Parse(tbID.Text), float.Parse(tbAbono.Text));

                bool respuesta = this.apartadoBusiness.actualizarApartado(apartadoNuevo);

                if (respuesta)// Si se actualiza la categoria se recargan los datos y se dejan los tb en blanco
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.success('Se actualizó exitosamente')", true);
                    //dejar los campos de texto en blanco

                    this.tbAbono.Text = " ";
                    this.tbSaldo.Text = " ";
                    this.tbID.Text = " ";

                    cargarInformacion();//recargar el gridview
                }//if
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.error('Se ha producido un error al procesar la solicitud')", true);
                }//else

            }//if

        }

        /// <summary>
        /// Realiza acción de cargar la info en el gridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            cargarInformacion();
        }
    }//class
}//namespace