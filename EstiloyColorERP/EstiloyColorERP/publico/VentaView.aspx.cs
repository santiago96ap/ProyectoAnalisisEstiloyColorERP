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
            String nombreCategoria = lbCategoria.SelectedItem.Value;
            String codigoCategoria = "";

            foreach (Categoria categoria in categorias)
            {
                if (categoria.Nombre.Equals(nombreCategoria)){
                    codigoCategoria = categoria.Codigo;
                }
            }//obtiene el codigo de la categoria seleccionada

            lbArticulos.Items.Clear;

            foreach (Producto producto in productos)
            {
                if (codigoCategoria.Equals(producto.IdCategoria))
                {
                    lbArticulos.Items.Add(producto.Nombre);
                }
            }// carga los articulos de acuerdo a la categoria
        }//categoria seleccionada

        protected void lbArticulos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }//articulo seleccionado
    }
}