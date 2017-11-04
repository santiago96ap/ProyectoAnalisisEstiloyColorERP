using System;
using System.Collections.Generic;
using DOMAIN;
using BUSINESS;

namespace EstiloyColorERP
{
    public partial class InsertarVentaView : System.Web.UI.Page
    {
        private VentaBusiness ventaBuisiness = new VentaBusiness();
        private ProductoBusiness productoBusiness = new ProductoBusiness();
        private LinkedList<Producto> todoProductos;
        private LinkedList<Producto> productos;

        protected void Page_Load(object sender, EventArgs e)
        {

        }//load


        private float sumarPrecios(LinkedList<Producto> p)
        {
            float total = 0;

            foreach (Producto pActual in p)
            {
                total += pActual.Precio;
            }//foreach

            return total;
        }//sumarPrecios

    }//class
}//class