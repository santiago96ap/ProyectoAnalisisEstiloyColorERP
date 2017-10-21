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
        private CategoriaBusiness categoriaBusiness;
        private ProductoBusiness productoBusiness;
        private LinkedList<Categoria> categorias;
        private LinkedList<Producto> productos;

        protected void Page_Load(object sender, EventArgs e)
        {
            categoriaBusiness = new CategoriaBusiness();
            categorias = categoriaBusiness.obtenerCategorias();
            foreach (Categoria categoria in categorias)
            {
                lbCategoria.Items.Add(categoria.Nombre);
            }
            
            productoBusiness = new ProductoBusiness();
            productos = productoBusiness.obtenerTodosProductos();
            foreach (Producto producto in productos)
            {
                if (categorias.First.Value.Codigo.Equals(producto.IdCategoria))
                {
                    lbArticulos.Items.Add(producto.Nombre);
                }
            }

        }//load

        protected void btnInsertar_Click(object sender, EventArgs e)
        {

        }//accion insertar venta

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            
        }//accion agregar articulo

        protected void lbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void lbArticulos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}