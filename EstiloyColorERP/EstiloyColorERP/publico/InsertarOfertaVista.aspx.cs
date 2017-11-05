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

        }//Page_Load

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(this.TbBuscarCodigo.Text))
            {
                if (this.ofertaBusiness.insertarOfertaProducto(new Oferta(tbFechaI.Text, tbFechaF.Text, float.Parse(tbDescuento.Text), int.Parse(ddProducto.SelectedItem.Value)))== true)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.success('¡Se ha insertado con éxito!')", true);
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.error('¡Ha ocurrido un error!')", true);

                }//if-else
            }
            else
            {
                if (this.ofertaBusiness.insertarOfertaProducto(new Oferta(tbFechaI.Text, tbFechaF.Text, float.Parse(tbDescuento.Text), int.Parse(TbBuscarCodigo.Text))) == true)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.success('¡Se ha insertado con éxito!')", true);
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.error('¡Ha ocurrido un error!')", true);

                }//if-else

            }//else-if NULL Opción
            
       }//btnInsertar_Click


        private void cargarListaProducto()
        {
            this.productos = this.prodtBusiness.obtenerTodosProductos();
            this.productos.Clear();
            foreach (Producto pActual in this.productos)
            {
                this.ddProducto.Items.Add(new ListItem(pActual.IdProct + "-" + pActual.Nombre, pActual.IdProct.ToString()));
            }//llenar el listbox con los productos de la DB

        }//cargarListaProducto

        protected void ddProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
        }//ddProducto_SelectedIndexChanged
    }//class
}//namespace