using System;
using System.Web.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DATA;
using DOMAIN;

namespace BUSINESS {
    public class InventarioBusiness {

        private InventarioData inventarioData;
        private string stringConeccion;

        public InventarioBusiness() {
            this.stringConeccion = WebConfigurationManager.ConnectionStrings["BaseDatos"].ToString();
            this.inventarioData = new InventarioData(this.stringConeccion);
        }

        public Boolean actualizarInventario(Inventario inventario) {
            return this.inventarioData.actualizarInventario(inventario);
        }//actualizarInventario

        public Boolean eliminarInventario(Inventario inventario) {
            return this.inventarioData.eliminarInventario(inventario);
        }//eliminarInventario

        public Inventario obtenerInventario(Inventario inventario) {
            return this.inventarioData.obtenerInventario(inventario);
        }//obtenerInventrio

    }
}