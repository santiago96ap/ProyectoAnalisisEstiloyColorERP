using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DOMAIN;

namespace DATA {
    public class CategoriaData {
        private String stringConnection;

        public CategoriaData(String stringConection) {
            this.stringConeccion = stringConeccion;
        }//constructor

        public Boolean insertarCategoria(Categoria categoria) {
            return false;
        }//insertarCategoria

        public Boolean actualizarCategoria(Categoria categoria) {
            return false;
        }//actualizarCategoria

        public LinkedList<Categoria> obtenerCategorias() {
            return null;
        }//obtenerCategorias

        public Categoria obtenerCategoria(Categoria categoria) {
            return null;
        }//obtenerCategoria

        public Boolean eliminarCategoria(Categoria categoria) {
            return false;
        }//eliminarCategoria
    }//clase
}
