using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BUSINESS {
    public class InventarioBusiness {

        private InventarioData inventarioData;

        public InventarioBusiness(string stringConeccion) {
            this.inventarioData = new InventarioData(stringConeccion);
        }

        public Boolean actualizarInventario(Inventario inventario) {
            this.inventarioData.actualizarInventario(inventario);
        }//actualizarInventario

        public Boolean eliminarInventario(Inventario inventario) {
            return this.inventarioData.eliminarInventario(inventario);
        }//eliminarInventario

        public Inventario obtenerInventario(Inventario inventario) {
            return this.inventarioData.obtenerInventario(inventario);
        }//obtenerInventrio

    }
}