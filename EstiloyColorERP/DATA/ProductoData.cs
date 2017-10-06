using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DATA
{
    public class ProductoData
    {
        private String conectionString;

        public ProductoData(String conectionString)
        {
            this.conectionString = conectionString;
        }//constructor


        public Boolean insertarProducto(Producto producto)
        {
            return false;
        }//insertarProducto

        public Boolean actualizarProducto(Producto producto)
        {
            return false;
        }//actualizarProducto

        public Boolean eliminarProducto(Producto producto)
        {
            return false;
        }//eliminarProducto

        public LinkedList<Producto> obtenerTodosProductos()
        {
            return null;
        }//obtenerTodosProductos

        public LinkedList<Producto> obtenerProductoPorCategoria(Categoria categoria)
        {
            return null;
        }//obtenerProductoPorCategoria

        public LinkedList<Producto> obtenerProductoPorID(Producto producto)
        {
            return null;
        }// obtenerProductoPorID

    }//class
}//namespace