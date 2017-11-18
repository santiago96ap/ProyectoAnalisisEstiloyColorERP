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
            this.p = this.pb.obtenerProductoPorID(int.Parse(tbBuscar.Text));
            this.tbCodigo.Text = p.IdProct.ToString();
            this.tbNombreP.Text = p.Nombre;
            this.tbDescrpciom.Text = p.Descripcion;
            this.tbCosto.Text = p.Costo.ToString();
            this.tbPrecio.Text = p.Precio.ToString();
            this.tbCant.Text = p.Cantidad.ToString();
            this.tbCodigo.Enabled = false;
        }// btnBuscar_Click

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            this.pb = new ProductoBusiness();
            this.p = this.pb.obtenerProductoPorID(int.Parse(tbBuscar.Text));
            if (this.pb.actualizarProducto(new Producto(int.Parse(tbCodigo.Text), tbNombreP.Text, tbDescrpciom.Text, float.Parse(tbCosto.Text), float.Parse(tbPrecio.Text), int.Parse(tbCant.Text), p.IdProveedor, p.IdCategoria))==true)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.success('Se actualizó exitosamente')", true);
                this.tbCodigo.Text = "";
                this.tbNombreP.Text = "";
                this.tbDescrpciom.Text = "";
                this.tbCosto.Text = "";
                this.tbPrecio.Text = "";
                this.tbCant.Text = "";
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.success('¡Ha sucedido un error!')", true);

            }//else-if

        }//btnActualizar_Click
    }//class
}//namespace