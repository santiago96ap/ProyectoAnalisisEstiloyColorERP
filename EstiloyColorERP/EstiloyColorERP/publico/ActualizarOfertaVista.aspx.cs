﻿using BUSINESS;
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
        protected void Page_Load(object sender, EventArgs e){}//pageload

        protected void gvGastos_SelectedIndexChanged(object sender, EventArgs e){}


        /// <summary>
        /// Este método cargará la información en el GridView
        /// </summary>
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
 
            foreach (Oferta ofertaActual in ofertas)
            {
                if (ofertaActual.IdProducto == int.Parse(this.TbProducto.Text))
                {
                    DataRow row = table.NewRow();
                    row["ID"] = ofertaActual.Id;
                    row["Fecha Inicio"] = ofertaActual.FechaInicio;
                    row["Fecha final"] = ofertaActual.FechaFinal;
                    row["Descuento"] = ofertaActual.Descuento;
                    row["ID Producto"] = ofertaActual.IdProducto;
                    row["Nuevo Precio"] = ofertaActual.PrecioDescuento;
                    table.Rows.Add(row);
                }
            }//foreach
            gvOfertas.DataSource = table;
            gvOfertas.DataBind();

            this.tbID.Text = "";
            this.tbID.Enabled = false;//no se puede modificar el ID del ingreso
            this.tbFechaI.Text = "";
            this.tbFechaF.Text = "";
            this.tbDescuento.Text = "";
            this.tbIDProducto.Text = "";
            this.tbPrecio.Text = "";
            this.tbFechaI.Enabled = false;
            this.tbFechaF.Enabled = false;
            this.tbDescuento.Enabled = false;
            this.tbIDProducto.Enabled = false;
            this.tbPrecio.Enabled = false;

        }//cargarDatos

        /// <summary>
        /// Este método actualizará la información de lo que se encuentra en el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(this.tbID.Text) || String.IsNullOrWhiteSpace(this.tbFechaI.Text) || String.IsNullOrWhiteSpace(this.tbIDProducto.Text) || String.IsNullOrWhiteSpace(this.tbFechaF.Text))
            {//si existe un tb en blanco se indica al usuario y no se aplica ningún cambio
                ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.error('Error, campos en blanco')", true);
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
                    this.tbDescuento.Text = "";
                    this.tbPrecio.Text = "";
                    this.TbProducto.Text = "";
                    this.gvOfertas.DataBind();
                    this.tbFechaI.Enabled = false;
                    this.tbFechaF.Enabled = false;
                    this.tbDescuento.Enabled = false;
                    this.tbIDProducto.Enabled = false;
                    this.tbPrecio.Enabled = false;
                }//if
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.error('Se ha producido un error al procesar la solicitud')", true);
                }//else

            }//else - no hay datos en blanco

        }//btnActualizar_Click


        /// <summary>
        /// Este método llama al metdod cargarDatos()
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button1_Click(object sender, EventArgs e)
        {
            bool flag = false;
            ProductoBusiness productoBusiness = new ProductoBusiness();
            LinkedList<Producto> productos = productoBusiness.obtenerTodosProductos();
            foreach(Producto productoActual in productos)
            {
                if (productoActual.IdProct == int.Parse(this.TbProducto.Text))
                {
                    flag = true;
                }//saber si existe el producto
            }//recorrer los productos para validar
            if (flag)
            {
                cargarDatos();
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.error('El producto ingresado no se encuentra en el sistema')", true);
            }//si se encontro el producto
        }//Button1_Click

        /// <summary>
        /// Este método realiza la acción de seleciionar una fila del GridView para mostrarlo en el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void DeleteRowButton_Click(object sender, GridViewDeleteEventArgs e)
        {
            int idIngreso = int.Parse(this.gvOfertas.DataKeys[e.RowIndex].Value.ToString());//email (id) del proveedor por el cual se cargarán y modificarán los datos

            this.ofertaBusiness = new OfertaBusiness();
            this.ofertas = null;
            this.ofertas = this.ofertaBusiness.obtenerOfertas();

            foreach (Oferta gActual in this.ofertas) //buscar los datos seleccionados y mostrarlos en los campos de texto
            {
                if (gActual.Id == idIngreso)//se buscan los datos
                {
                    //se desgrana la fecha para luego darle formato
                    String[] fechaI = gActual.FechaInicio.ToString().Split(' ');//se obtiene la fecha
                    String[] datos = fechaI[0].ToString().Split('/');//se obtneien las partes de la fecha día, mes, año

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



                    //se desgrana la fecha para luego darle formato
                    String[] fechaF = gActual.FechaFinal.ToString().Split(' ');//se obtiene la fecha
                    String[] datoF= fechaF[0].ToString().Split('/');//se obtneien las partes de la fecha día, mes, año

                    String fechaListaF = "";
                    if (int.Parse(datos[0]) < 10 && int.Parse(datos[1]) < 10)
                    {
                        fechaListaF = datos[2] + '-' + '0' + datos[1] + '-' + '0' + datos[0];// la fecha se debe acomodar a un formato nuevo para mostrarse
                    }
                    else if (int.Parse(datos[0]) < 10)
                    {
                        fechaListaF = datos[2] + '-' + datos[1] + '-' + '0' + datos[0];// la fecha se debe acomodar a un formato nuevo para mostrarse
                    }
                    else if (int.Parse(datos[1]) < 10)
                    {
                        fechaListaF = datos[2] + '-' + '0' + datos[1] + '-' + datos[0];// la fecha se debe acomodar a un formato nuevo para mostrarse
                    }
                    else
                    {
                        fechaListaF = datos[2] + '-' + datos[1] + '-' + datos[0];// la fecha se debe acomodar a un formato nuevo para mostrarse
                    }//if-else


                    //se llenan los campos para la posterior edición
                    this.tbID.Text = idIngreso + "";
                    this.tbID.Enabled = false;//no se puede modificar el ID
                    this.tbFechaI.Text = fechaLista.ToString();
                    this.tbFechaF.Text = fechaListaF.ToString();
                    this.tbIDProducto.Text = gActual.IdProducto.ToString();
                    this.tbDescuento.Text = gActual.Descuento.ToString();
                    this.tbPrecio.Text = gActual.PrecioDescuento.ToString();
                    this.tbFechaI.Enabled = true;
                    this.tbFechaF.Enabled = true;
                    this.tbDescuento.Enabled = true;
                    this.tbIDProducto.Enabled = true;
                    this.btnActualizar.Enabled = true;

                }
            }//foreach

        }//btnAccion

    }//class

}//namespace