using BUSINESS;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EstiloyColorERP.publico
{
    public partial class ActualizarProductVista : System.Web.UI.Page
    {
        private ProductoBusiness pb = new ProductoBusiness();
        private Producto p;
        protected void Page_Load(object sender, EventArgs e){}//Page_Load
        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            bool flag = false;
            LinkedList<Producto> productos = pb.obtenerTodosProductos();
            foreach (Producto productoActual in productos)
            {
                if(productoActual.IdProct == int.Parse(this.tbBuscar.Text))
                {
                    flag = true;
                }
            }
            if (flag)
            {
                this.p = this.pb.obtenerProductoPorID(int.Parse(tbBuscar.Text));
                this.tbCodigo.Text = p.IdProct.ToString();
                this.tbNombreP.Text = p.Nombre;
                this.tbDescrpciom.Text = p.Descripcion;
                this.tbCosto.Text = p.Costo.ToString();
                this.tbPrecio.Text = p.Precio.ToString();
                this.tbCant.Text = p.Cantidad.ToString();
                this.tbCodigo.Enabled = false;
                this.tbNombreP.Enabled = true;
                this.tbDescrpciom.Enabled = true;
                this.tbCosto.Enabled = true;
                this.tbPrecio.Enabled = true;
                this.tbCant.Enabled = true;
                this.btnActualizar.Enabled = true;
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.error('El producto ingresado no esta registrado en el sistema')", true);
            }////ver si el producto existe
            
        }// btnBuscar_Click

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            this.pb = new ProductoBusiness();
            this.p = this.pb.obtenerProductoPorID(int.Parse(tbBuscar.Text));
            if (String.IsNullOrWhiteSpace(this.tbNombreP.Text) || String.IsNullOrWhiteSpace(this.tbDescrpciom.Text) || String.IsNullOrWhiteSpace(this.tbCosto.Text) || String.IsNullOrWhiteSpace(this.tbPrecio.Text) || String.IsNullOrWhiteSpace(this.tbCant.Text))
            {//si existe un tb en blanco se indica al usuario y no se aplica ningún cambio
                ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.error('Error, campos en blanco')", true);
            }
            else
            {
                if (this.pb.actualizarProducto(new Producto(int.Parse(tbCodigo.Text), tbNombreP.Text, tbDescrpciom.Text, float.Parse(tbCosto.Text), float.Parse(tbPrecio.Text), int.Parse(tbCant.Text), p.IdProveedor, p.IdCategoria)) == true)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.success('Se actualizó exitosamente')", true);
                    this.tbCodigo.Text = "";
                    this.tbNombreP.Text = "";
                    this.tbDescrpciom.Text = "";
                    this.tbCosto.Text = "";
                    this.tbPrecio.Text = "";
                    this.tbCant.Text = "";
                    this.tbNombreP.Enabled = false;
                    this.tbDescrpciom.Enabled = false;
                    this.tbCosto.Enabled = false;
                    this.tbPrecio.Enabled = false;
                    this.tbCant.Enabled = false;
                    this.btnActualizar.Enabled = false;
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.success('¡Ha sucedido un error!')", true);

                }//else-if
            }//validar campos
        }//btnActualizar_Click
    }//class
}//namespace