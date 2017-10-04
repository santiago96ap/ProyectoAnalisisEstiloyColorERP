using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DOMAIN;

namespace DATA {
    public class ProveedorData {
        private String stringConnection;

        public ProveedorData(String stringConection) {
            this.stringConeccion = stringConeccion;
        }//constructor

        public Boolean insertarProveedor(Proveedor proveedor) {
            return false;
        }//insertarProveedor

        public Boolean actualizarProveedor(Proveedor proveedor) {
            return false;
        }//actualizarProveedor

        public LinkedList<Proveedor> obtenerProveedores() {
            return null;
        }//obtenerProveedores

        public Proveedor obtenerProveedor(ProveedorData proveedor) {
            return null;
        }//obtenerProveedor

        public Boolean eliminarProveedor(Proveedor proveedor) {
            return false;
        }//eliminarProveedor
    }//clase
}