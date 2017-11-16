using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using DOMAIN;
using DATA;

namespace BUSINESS {
    public class CategoriaBusiness {
        /// <summary>
        /// Clase encargadad de las reglas de negocios para acceder a la base de datos
        /// </summary>

        //Atributos
        private CategoriaData categoriaData;
        private string stringConeccion;

        /// <summary>
        /// Método constructor de la clase
        /// </summary>
        public CategoriaBusiness() {
            this.stringConeccion = WebConfigurationManager.ConnectionStrings["BaseDatos"].ToString();
            this.categoriaData = new CategoriaData(stringConeccion);
        }//constructor

        /// <summary>
        /// Método para insertar una nueva categoría
        /// </summary>
        /// <param name="categoria">Categoría creada por el usuario</param>
        /// <returns>1 si se pudo completar la acción o 0 si hubo un error</returns>
        public Boolean insertarCategoria(Categoria categoria) {
            return this.categoriaData.insertarCategoria(categoria);
        }//insertarCategoria

        /// <summary>
        /// Método encargado de actualizar datos existentes de una categoría
        /// </summary>
        /// <param name="categoria">Categoría con datos modificados</param>
        /// <returns>1 si se pudo completar la acción o 0 si hubo un error</returns>
        public Boolean actualizarCategoria(Categoria categoria) {
            return this.categoriaData.actualizarCategoria(categoria);
        }//actualizarCategoria

        /// <summary>
        /// Método que devuelve todas las categorías existentes en el sistema
        /// </summary>
        /// <returns>Lista con todas las categorías en el sistema</returns>
        public LinkedList<Categoria> obtenerCategorias() {
            return this.categoriaData.obtenerCategorias();
        }//obtenerCategorias

        /// <summary>
        /// Método que se encarga de eliminar una categoría
        /// </summary>
        /// <param name="categoria">Categoría a eliminar</param>
        /// <returns>1 si se pudo completar la acción o 0 si hubo un error</returns>
        public Boolean eliminarCategoria(Categoria categoria) {
            return this.categoriaData.eliminarCategoria(categoria);
        }//eliminarCategoria

    }//class
}//namespace
