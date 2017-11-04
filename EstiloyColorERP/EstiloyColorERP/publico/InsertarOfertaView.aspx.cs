using BUSINESS;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EstiloyColorERP
{
    public partial class InsertarOferta : System.Web.UI.Page
    {
        private ProductoBusiness prodtBusiness = new ProductoBusiness();
        private OfertaBusiness ofertaBusiness=new OfertaBusiness();
        private LinkedList<Producto> productos;
        protected void Page_Load(object sender, EventArgs e)
        {
            cargarListaProducto();
            if (this.ddProducto !=null)
            {
                if (!IsPostBack)
                {
                   cargarListaProducto();
                }// if (!IsPostBack)

            }//if (this.ddProducto !=null)

        }//Page_Load

        protected void btnInsertar_Click(object sender, EventArgs e)
        {

        }//btnInsertar_Click


        private void cargarListaProducto()
        {
            this.productos = this.prodtBusiness.obtenerTodosProductos();
            foreach (Producto pActual in this.productos)
            {
                this.ddProducto.Items.Add(new ListItem(pActual.IdProct + "-" + pActual.Nombre, pActual.IdProct.ToString()));
            }//llenar el listbox con los productos de la DB

        }//cargarListaProducto

        protected void ddProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.TbBuscarCodigo.Enabled = false;
        }//ddProducto_SelectedIndexChanged
    }//class
}//namespace