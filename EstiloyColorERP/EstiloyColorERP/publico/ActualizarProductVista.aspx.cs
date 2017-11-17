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
        protected void Page_Load(object sender, EventArgs e){}//Page_Load
        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            Producto p = this.pb.obtenerProductoPorID(int.Parse(tbBuscar.Text));
            this.tbCodigo.Text = p.IdProct.ToString();
            this.tbNombreP.Text = p.Nombre;
            this.tbDescrpciom.Text = p.Descripcion;
            this.tbCosto.Text = p.Costo.ToString();
            this.tbPrecio.Text = p.Precio.ToString();
            this.tbCant.Text = p.Cantidad.ToString();
        }// btnBuscar_Click

        protected void btnActualizar_Click(object sender, EventArgs e)
        {

        }//btnActualizar_Click
    }//class
}//namespace