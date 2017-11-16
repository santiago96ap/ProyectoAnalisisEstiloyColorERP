using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DOMAIN;
using DATA;
using System.Web.Configuration;

namespace BUSINESS {
    public class ProveedorBusiness
    {
        /// <summary>
        /// Clase encargadad de las reglas de negocios para acceder a la base de datos
        /// </summary>

        //Atributos
        private ProveedorData proveedorData;
        private String connString = WebConfigurationManager.ConnectionStrings["baseDatos"].ToString();

        /// <summary>
        /// Método constructor de la clase
        /// </summary>
        public ProveedorBusiness()
        {
            this.proveedorData = new ProveedorData(connString);
        }//constructor

        /// <summary>
        /// Método por el cuel se inserta un nuevo proveedor en el sistema
        /// </summary>
        /// <param name="proveedor">Proveedor creado por un usuario</param>
        /// <returns>1 si se pudo completar la acción o 0 si hubo un error</returns>
        public Boolean insertarProveedor(Proveedor proveedor)
        {
            return this.proveedorData.insertarProveedor(proveedor);
        }//insertarProveedor

        /// <summary>
        /// Método por el cuel se actualizan datos de un proveedor
        /// </summary>
        /// <param name="proveedor">Proveedor con los datos modificados</param>
        /// <returns>1 si se pudo completar la acción o 0 si hubo un error</returns>
        public Boolean actualizarProveedor(Proveedor proveedor)
        {
            return this.proveedorData.actualizarProveedor(proveedor);
        }//actualizarProveedor

        /// <summary>
        /// Método encargado de devolver todos los proveedores existentes en la base de datos
        /// </summary>
        /// <returns>Lista con proveedores existentes en la base de datos</returns>
        public LinkedList<Proveedor> obtenerProveedores()
        {
            return this.proveedorData.obtenerProveedores();
        }//obtenerProveedores

        /// <summary>
        /// Método que devuelve un proveedor en específico
        /// </summary>
        /// <param name="proveedor">Proveedor existente en el sistema</param>
        /// <returns>Proveedor de la base de datos</returns>
        public Proveedor obtenerProveedor(Proveedor proveedor)
        {
            return this.proveedorData.obtenerProveedor(proveedor);
        }//obtenerProveedor

        /// <summary>
        /// Método por el cual se elimina un proveedor
        /// </summary>
        /// <param name="proveedor">Proveedor existente en el sistema</param>
        /// <returns>1 si se pudo completar la acción o 0 si hubo un error</returns>
        public Boolean eliminarProveedor(Proveedor proveedor)
        {
            return this.proveedorData.eliminarProveedor(proveedor);
        }//eliminarProveedor

    }//class
}//namespace