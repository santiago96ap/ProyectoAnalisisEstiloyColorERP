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
    public partial class ActualizarCategoriaVista : System.Web.UI.Page
    {
        private CategoriaBusiness categoriaBusiness;
        private LinkedList<Categoria> categorias;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarInformacion();
            }//if para ver si es la primera vez que se carga el modulo

        }//Page_Load


        /// <summary>
        /// Este método cargará la información pertinente en el GridView
        /// </summary>
        protected void cargarInformacion()
        {
            this.categoriaBusiness = new CategoriaBusiness();
            this.categorias = this.categoriaBusiness.obtenerCategorias();
            DataTable table = new DataTable("Categorias");

            table.Columns.Add(new DataColumn("id", typeof(int)));
            table.Columns.Add(new DataColumn("Nombre", typeof(string)));


            foreach (Categoria cActual in this.categorias)

            {
                DataRow row = table.NewRow();

                row["id"] = cActual.Codigo;
                row["Nombre"] = cActual.Nombre;

                table.Rows.Add(row);
            }//foreach

            this.gvCategorias.DataSource = table;
            this.gvCategorias.DataBind();
        }//cargarInformacion


        /// <summary>
        /// Este método actualizará los datos que se encuentrán el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(this.tbNombre.Text))
            {//si existe un tb en blanco se indica al usuario y no se aplica ningún cambio
                ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.error('Error en los datos ingresados')", true);
            }
            else
            {
                this.categoriaBusiness = new CategoriaBusiness();

                Categoria categoriaNuevo = new Categoria(int.Parse(tbID.Text),tbNombre.Text.ToString());

                bool respuesta = this.categoriaBusiness.actualizarCategoria(categoriaNuevo);

                if (respuesta)// Si se actualiza la categoria se recargan los datos y se dejan los tb en blanco
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.success('Se actualizó exitosamente')", true);
                    //dejar los campos de texto en blanco

                    this.tbNombre.Text = " ";
                    this.tbID.Text = " ";
                    cargarInformacion();//recargar el gridview
                }//if
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.error('Se ha producido un error al procesar la solicitud')", true);
                }//else

            }//if

        }//btnActualizar_Click


        /// <summary>
        /// Este método realiza la acción de seleccionar la información de una fila de GridView y lo muentra en el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void DeleteRowButton_Click(object sender, GridViewDeleteEventArgs e)
        {
            int ID = int.Parse(this.gvCategorias.DataKeys[e.RowIndex].Value.ToString());//(id) de la  categoria por el cual se cargarán y modificarán los datos
            this.tbID.Enabled = false;
            this.tbID.Text = ID.ToString();

            this.categoriaBusiness = new CategoriaBusiness();
            this.categorias = this.categoriaBusiness.obtenerCategorias();

            foreach (Categoria cActual in this.categorias) //buscar los datos de la categoría seleccionado y mostrarlos en los campos de texto
            {
                if (cActual.Codigo==ID)//se buscan los datos
                {
                    this.tbNombre.Text = cActual.Nombre;
                    this.tbID.Text = cActual.Codigo.ToString();
                }//If
            }//foreach

        }//btnBuscar_Click
    }//class
}//nameSpace