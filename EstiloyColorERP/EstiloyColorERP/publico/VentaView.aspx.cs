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
        private List<Categoria> categorias;
        private List<Producto> productos;

        protected void Page_Load(object sender, EventArgs e)
        {
            categoriaBusiness = new CategoriaBusiness();
            categorias= categoriaBusiness.obtenerCategorias();
            foreach (Categoria categoria in categorias)
            {
                lbCategoria.items.Add(categorias[i].Nombre);
            }
            
             productoBusiness = new ProductoBusiness();
            productos.obtenerTodosProductos();
            foreach (Producto producto in productos)
            {
                if (categorias[0].Codigo.equals(productos[i].idCategoria))
                {
                    lbArticulos.items.Add(productos[i]);
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
            foreach(Categoria categoria in categorias)
            {

            }
        }//categoria seleccionada

        protected void lbArticulos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }//articulo seleccionado
    }
}