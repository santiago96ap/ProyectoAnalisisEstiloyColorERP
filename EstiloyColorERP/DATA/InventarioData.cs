using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DATA {
    public class InventarioData {

        private String stringConeccion;

        public InventarioData(string stringConeccion) {
            this.stringConeccion = stringConeccion;
        }//constructor
    
        public Boolean actualizarInventario(Inventario inventario) {
            return false;
        }//actualizarInventario

        public Boolean eliminarInventario(Inventario inventario) {
            return false;
        }//eliminarInventario

        public Inventario obtenerInventario(Inventario inventario) {
            return null;
        }//obtenerInventrio
    }
}