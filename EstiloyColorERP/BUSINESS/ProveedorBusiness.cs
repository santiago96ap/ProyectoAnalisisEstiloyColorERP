using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DOMAIN;
using DATA;

namespace BUSINESS {
    public class ProveedorBusiness {
        private ProveedorData proveedorData;

        public ProveedorBusiness(string stringConeccion) {
            this.proveedorData = new ProveedorData(stringConeccion);
        }//constructor

        public Boolean insertarProveedor(Proveedor proveedor) {
            return this.proveedorData.insertarProveedor(proveedor);
        }//insertarProveedor

        public Boolean actualizarProveedor(Proveedor proveedor) {
            return this.proveedorData.actualizarProveedor(proveedor);
        }//actualizarProveedor

        public LinkedList<Proveedor> obtenerProveedores() {
            return this.proveedorData.obtenerProveedores();
        }//obtenerProveedores

        public Proveedor obtenerProveedor(Proveedor proveedor) {
            return this.proveedorData.obtenerProveedor(proveedor);
        }//obtenerProveedor

        public Boolean eliminarProveedor(Proveedor proveedor) {
            return this.proveedorData.eliminarProveedor(proveedor);
        }

    }//class
}//namespace