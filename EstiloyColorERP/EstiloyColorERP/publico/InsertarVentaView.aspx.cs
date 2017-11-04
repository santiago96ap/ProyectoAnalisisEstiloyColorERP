using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DOMAIN;
using BUSINESS;

namespace EstiloyColorERP
{
    public partial class VentaView : System.Web.UI.Page
    {
        private VentaBusiness ventaBuisiness = new VentaBusiness();
        private ProductoBusiness productoBusiness = new ProductoBusiness();
        private LinkedList<Producto> productos;

        protected void Page_Load(object sender, EventArgs e)
        {

        }//load

        protected void btnInsertar_Click(object sender, EventArgs e)
        {

        }//accion insertar venta

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            
        }//accion agregar articulo

    }//class
}//class