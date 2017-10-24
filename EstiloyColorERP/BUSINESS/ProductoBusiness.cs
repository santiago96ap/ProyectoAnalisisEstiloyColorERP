using DATA;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace BUSINESS
{
    public class ProductoBusiness
    {
        private ProductoData pd;
        private String connString = WebConfigurationManager.ConnectionStrings["baseDatos"].ToString();

        public ProductoBusiness()
        {
            this.pd = new ProductoData(connString);
        }//constructor

        public Boolean insertarProducto(Producto producto)
        {
            return this.pd.insertarProducto(producto);
        }//insertarProducto

        public Boolean actualizarProducto(Producto producto)
        {
            return this.pd.actualizarProducto(producto);
        }//actualizarProducto

        public Boolean eliminarProducto(Producto producto)
        {
            return this.pd.eliminarProducto(producto);
        }//eliminarProducto

        public LinkedList<Producto> obtenerTodosProductos()
        {
            return this.pd.obtenerTodosProductos();
        }//obtenerTodosProductos

        public LinkedList<Producto> obtenerProductoPorCategoria(Categoria categoria)
        {
            return this.pd.obtenerProductoPorCategoria(categoria);
        }//obtenerProductoPorCategoria

        public LinkedList<Producto> obtenerProductoPorID(Producto producto)
        {
            return this.pd.obtenerProductoPorID(producto);
        }// obtenerProductoPorID


    }//class
}//namespace