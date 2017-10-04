using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DOMAIN;
using DATA;

namespace BUSINESS {
    public class CategoriaBusiness {
        private CategoriaData categoriaData;

        public CategoriaBusiness(string stringConeccion) {
            this.categoriaData = new CategoriaData(stringConeccion);
        }//constructor

        public Boolean insertarCategoria(Categoria categoria) {
            return this.categoriaData.insertarCategoria(categoria);
        }//insertarCategoria

        public Boolean actualizarCategoria(Categoria categoria) {
            return this.categoriaData.actualizarCategoria(categoria);
        }//actualizarCategoria

        public LinkedList<Categoria> obtenerCategorias() {
            return this.categoriaData.obtenerCategorias();
        }//obtenerCategorias

        public Categoria obtenerCategoria(Categoria categoria) {
            return this.categoriaData.obtenerCategoria(categoria);
        }//obtenerCategoria

        public Boolean eliminarCategoria(Categoria categoria) {
            return this.categoriaData.eliminarCategoria(categoria);
        }//eliminarCategoria

    }//class
}//namespace
