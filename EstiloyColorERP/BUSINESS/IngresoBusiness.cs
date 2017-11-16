using DATA;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace BUSINESS
{
    public class IngresoBusiness
    {
        /// <summary>
        /// Clase encargadad de las reglas de negocios para acceder a la base de datos
        /// </summary>
        
        //Atributos
        private IngresoData id;
        private String connString = WebConfigurationManager.ConnectionStrings["baseDatos"].ToString();

        /// <summary>
        /// Método constructor de la clase
        /// </summary>
        public IngresoBusiness()
        {
            this.id = new IngresoData(connString);
        }//constructor

        /// <summary>
        /// Método encargado de registrar un nuevo ingreso en el sistema
        /// </summary>
        /// <param name="ingreso">Ingreso registrado por un usuario</param>
        /// <returns>1 si se pudo completar la acción o 0 si hubo un error</returns>
        public Boolean insertarIngreso(Ingreso ingreso)
        {
            return this.id.insertarIngreso(ingreso);
        }//insertarIngreso

        /// <summary>
        /// Método utilizado para actualizar un ingreso existente
        /// </summary>
        /// <param name="ingreso">Ingreso con datos modificados</param>
        /// <returns>1 si se pudo completar la acción o 0 si hubo un error</returns>
        public Boolean actualizarIngreso(Ingreso ingreso)
        {
            return this.id.actualizarIngreso(ingreso);
        }//actualizarIngreso

        /// <summary>
        /// Método por el cua se elimina un ingreso seleccionado
        /// </summary>
        /// <param name="ingreso">Ingreso que se desea eliminar</param>
        /// <returns>1 si se pudo completar la acción o 0 si hubo un error</returns>
        public Boolean eliminarIngreso(Ingreso ingreso)
        {
            return this.id.eliminarIngreso(ingreso);
        }//eliminarIngreso

        /// <summary>
        /// Método utilizado para obtener los ingresos existentes en un rango de fecha
        /// </summary>
        /// <param name="fechaI">Fecha inicial del rango</param>
        /// <param name="fechaF">Fecha final del rango</param>
        /// <returns>Lista con ingresos en el rango de fechas</returns>
        public LinkedList<Ingreso> obtenerIngreso(String fechaI, String fechaF)
        {
            return this.id.obtenerIngreso(fechaI,fechaF);
        }//obtenerIngreso
    }//class
}//namespace