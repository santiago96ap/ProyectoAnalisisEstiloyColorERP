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
        /// <summary>
        /// Clase encargadad de las reglas de negocios para acceder a la base de datos
        /// </summary>

        //Atributos
        private ProductoData pd;
        private String connString = WebConfigurationManager.ConnectionStrings["baseDatos"].ToString();

        /// <summary>
        /// Método constructor de la clase
        /// </summary>
        public ProductoBusiness()
        {
            this.pd = new ProductoData(connString);
        }//constructor

        /// <summary>
        /// Método encargado de insertar un nuevo producto en la base de datos y en el inventario
        /// </summary>
        /// <param name="producto">Producto nuevo creado por un usuario</param>
        /// <returns>1 si se pudo completar la acción o 0 si hubo un error</returns>
        public Boolean insertarProducto(Producto producto)
        {
            return this.pd.insertarProducto(producto);
        }//insertarProducto

        /// <summary>
        /// Método encargado de actualizar información de un producto existente en la base de datos
        /// </summary>
        /// <param name="producto">Producto modificado</param>
        /// <returns>1 si se pudo completar la acción o 0 si hubo un error</returns>
        public Boolean actualizarProducto(Producto producto)
        {
            return this.pd.actualizarProducto(producto);
        }//actualizarProducto

        /// <summary>
        /// Método encargado de eliminar un producto en la base de datos
        /// </summary>
        /// <param name="producto">Producto a eliminar</param>
        /// <returns>1 si se pudo completar la acción o 0 si hubo un error</returns>
        public Boolean eliminarProducto(Producto producto)
        {
            return this.pd.eliminarProducto(producto);
        }//eliminarProducto
        
        /// <summary>
        /// Método establecido para retornar todos los productso en inventario
        /// </summary>
        /// <returns>Lista de inventario con todos los productos y cantidades de los mismos </returns>
        public LinkedList<Producto> obtenerTodosProductos()
        {
            return this.pd.obtenerTodosProductos();
        }//obtenerTodosProductos

        /// <summary>
        /// Método que obtiene productos por una categoría indicada por el usuario para visualizar
        /// </summary>
        /// <param name="categoria">Categoría existente en el sistema</param>
        /// <returns>Lista con productos que pertenecen a la categoría indicada</returns>
        public LinkedList<Producto> obtenerProductoPorCategoria(Categoria categoria)
        {
            return this.pd.obtenerProductoPorCategoria(categoria);
        }//obtenerProductoPorCategoria

        /// <summary>
        /// Método por el cuel se obtiene un producto por su ID
        /// </summary>
        /// <param name="id">id del producto seleccionado</param>
        /// <returns>Devuelve un producto</returns>
        public Producto obtenerProductoPorID(int id)
        {
            return this.pd.obtenerProductoPorID(id);
        }// obtenerProductoPorID

    }//class
}//namespace