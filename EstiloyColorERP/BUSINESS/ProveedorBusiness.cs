using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DOMAIN;
using DATA;
using System.Web.Configuration;

namespace BUSINESS {
    public class ProveedorBusiness {
        private ProveedorData proveedorData;
        private String connString = WebConfigurationManager.ConnectionStrings["baseDatos"].ToString();

        public ProveedorBusiness() {
            this.proveedorData = new ProveedorData(connString);
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