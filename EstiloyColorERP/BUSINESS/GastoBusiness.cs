using DATA;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Web.Configuration;
using System.Linq;
using System.Web;

namespace BUSINESS
{
    public class GastoBusiness
    {
        /// <summary>
        /// Clase encargadad de las reglas de negocios para acceder a la base de datos
        /// </summary>

        //Atributos
        private GastoData gastoData;
        private string stringConeccion;

        /// <summary>
        /// Método constructor de la clase
        /// </summary>
        public GastoBusiness()
        {
            this.stringConeccion = WebConfigurationManager.ConnectionStrings["BaseDatos"].ToString();
            this.gastoData = new GastoData(this.stringConeccion);
        }//constructor

        /// <summary>
        /// Método para insertar un nuevo gasto en el sistema
        /// </summary>
        /// <param name="gasto">Gasto creado un usuario</param>
        /// <returns>1 si se pudo completar la acción o 0 si hubo un error</returns>
        public Boolean insertarGasto(Gasto gasto)//, Vendedor venedor
        {
            return this.gastoData.insertarGasto(gasto);//, venedor
        }//insertarGasto

        /// <summary>
        /// Método utilizado para eliminar un gasto del sistema
        /// </summary>
        /// <param name="gasto">Gasto que se desea eliminar</param>
        /// <returns></returns>
        public Boolean eliminarGasto(Gasto gasto)
        {
            return this.gastoData.eliminarGasto(gasto);
        }//eliminarGasto

        /// <summary>
        /// Método encargado de modificar los datos de un gasto en el sistema
        /// </summary>
        /// <param name="gasto">GAsto con los datos modificados</param>
        /// <returns>1 si se pudo completar la acción o 0 si hubo un error</returns>
        public Boolean editarGasto(Gasto gasto)
        {
            return this.gastoData.editarGasto(gasto);          
        }//editarGasto
        
        /// <summary>
        /// Método para obtener gastos dentro de un rango
        /// </summary>
        /// <param name="fechaIni">Fecha inicial para el rango</param>
        /// <param name="fechaFin">Fecha final para el rango</param>
        /// <returns>Lista con los gastos encontrados en el rango dado</returns>
        public LinkedList<Gasto> obtenerGastos(String fechaIni, String fechaFin)
        {
            return this.gastoData.obtenerGastos(fechaIni, fechaFin);
        }//obtenerGastos

    }//fin de la clase
}//fin del namespace