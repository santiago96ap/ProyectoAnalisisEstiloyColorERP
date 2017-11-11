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
    public partial class ActualizarOferta : System.Web.UI.Page
    {
        private OfertaBusiness ofertaBusiness;
        private LinkedList<Oferta> ofertas;
        protected void Page_Load(object sender, EventArgs e)
        {
        }//pageload

        protected void gvGastos_SelectedIndexChanged(object sender, EventArgs e){}

        protected void cargarDatos()
        {
            ofertaBusiness = new OfertaBusiness();

            this.ofertas = this.ofertaBusiness.obtenerOfertas();
            DataTable table = new DataTable("Ofertas");
            table.Columns.Add(new DataColumn("ID", typeof(int)));
            table.Columns.Add(new DataColumn("Fecha Inicio", typeof(string)));
            table.Columns.Add(new DataColumn("Fecha final", typeof(string)));
            table.Columns.Add(new DataColumn("Descuento", typeof(string)));
            table.Columns.Add(new DataColumn("ID Producto", typeof(int)));
            table.Columns.Add(new DataColumn("Nuevo Precio", typeof(float)));
 
            foreach (var item in ofertas)
            {
                DataRow row = table.NewRow();
                row["ID"] = item.Id;
                row["Fecha Inicio"] = item.FechaInicio;
                row["Fecha final"] = item.FechaFinal;
                row["Descuento"] = item.Descuento;
                row["ID Producto"] = item.IdProducto;
                row["Nuevo Precio"] = item.PrecioDescuento;
                table.Rows.Add(row);
            }//foreach
            gvOfertas.DataSource = table;
            gvOfertas.DataBind();

            this.tbID.Text = "";
            this.tbID.Enabled = false;//no se puede modificar el ID del ingreso
            this.tbFechaI.Text = "";
            this.tbFechaF.Text = "";
            this.tbIDProducto.Text = "";
            this.tbPrecio.Text = "";
            this.TbProducto.Text = "";
        }//cargarDatos

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(this.tbID.Text) || String.IsNullOrWhiteSpace(this.tbFechaI.Text) || String.IsNullOrWhiteSpace(this.tbIDProducto.Text) || String.IsNullOrWhiteSpace(this.tbFechaF.Text))
            {//si existe un tb en blanco se indica al usuario y no se aplica ningún cambio
                ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.error('Error en los datos ingresados')", true);
            }
            else
            {
                this.ofertaBusiness = new OfertaBusiness();

                Oferta oNuevo = new Oferta(int.Parse(tbID.Text.ToString()), tbFechaI.Text.ToString(), tbFechaF.Text, float.Parse(tbDescuento.Text), int.Parse(tbIDProducto.Text), float.Parse(tbPrecio.Text));

                bool respuesta = this.ofertaBusiness.editarOferta(oNuevo);

                if (respuesta)// Si se actualiza el usuario se recargan los datos y se dejan los tb en blanco
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.success('El gasto se actualizó exitosamente')", true);
                    //dejar los campos de texto en blanco
                    this.tbID.Text = "";
                    this.tbID.Enabled = false;//no se puede modificar el ID del ingreso
                    this.tbFechaI.Text = "";
                    this.tbFechaF.Text = "";
                    this.tbIDProducto.Text = "";
                    this.tbPrecio.Text = "";
                    this.TbProducto.Text = "";
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
        protected void DeleteRowButton_Click(object sender, GridViewDeleteEventArgs e)
        {
            int idIngreso = int.Parse(this.gvOfertas.DataKeys[e.RowIndex].Value.ToString());//email (id) del proveedor por el cual se cargarán y modificarán los datos

            this.ofertaBusiness = new OfertaBusiness();
            this.ofertas = null;
            this.ofertas = this.ofertaBusiness.obtenerOfertas();

            foreach (Oferta gActual in this.ofertas) //buscar los datos del proveedor seleccionado y mostrarlos en los campos de texto
            {
                if (gActual.Id == idIngreso)//se buscan los datos
                {
                    //se desgrana la fecha para luego darle formato
                    String[] fechaI = gActual.FechaInicio.ToString().Split(' ');//se obtiene la fecha
                    String[] datos = fechaI[0].ToString().Split('/');//se obtneien las partes de la fecha día, mes, año

                    String fechaLista = datos[2] + '-' + datos[1] + '-' + datos[0];// la fecha se debe acomodar a un formato nuevo para mostrarse



                    //se desgrana la fecha para luego darle formato
                    String[] fechaF = gActual.FechaInicio.ToString().Split(' ');//se obtiene la fecha
                    String[] datoF= fechaF[0].ToString().Split('/');//se obtneien las partes de la fecha día, mes, año

                    String fechaListaF = datoF[2] + '-' + datoF[1] + '-' + datoF[0];// la fecha se debe acomodar a un formato nuevo para mostrarse


                    //se llenan los campos para la posterior edición
                    this.tbID.Text = idIngreso + "";
                    this.tbID.Enabled = false;//no se puede modificar el ID del ingreso
                    this.tbFechaI.Text = fechaLista.ToString();
                    this.tbFechaF.Text = fechaListaF.ToString();
                    this.tbIDProducto.Text = gActual.IdProducto.ToString();
                    this.tbDescuento.Text = gActual.Descuento.ToString();
                    this.tbPrecio.Text = gActual.PrecioDescuento.ToString();


                }
            }//foreach

        }//btnAccion

    }//class

}//namespace