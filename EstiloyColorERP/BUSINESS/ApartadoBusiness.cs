using System;
using System.Collections.Generic;
using System.Web.Configuration;
using System.Linq;
using System.Web;
using DOMAIN;
using DATA;

namespace BUSINESS
{
    public class ApartadoBusiness
    {
        /// <summary>
        /// Clase encargadad de las reglas de negocios para acceder a la base de datos
        /// </summary>

        //Atributos
        private ApartadoData apartadoData;
        private string stringConeccion;

        /// <summary>
        /// Método constructor de la clase
        /// </summary>
        public ApartadoBusiness()
        {
            this.stringConeccion = WebConfigurationManager.ConnectionStrings["BaseDatos"].ToString();
            this.apartadoData = new ApartadoData(this.stringConeccion);
        }//constructor

        /// <summary>
        /// Método por el cual se ingresa un nuevo apartado en el sistema
        /// </summary>
        /// <param name="apartado">Apartado nuevo creado por un usuario</param>
        /// <returns>1 si se pudo completar la acción o 0 si hubo un error</returns>
        public Boolean insertarApartado(Apartado apartado)
        {
            return this.apartadoData.insertarApartado(apartado);
        }//insertarApartado

        /// <summary>
        /// Método por el cual se elimina un apartado dado
        /// </summary>
        /// <param name="apartado">Apartado que se desea eliminar</param>
        /// <returns>1 si se pudo completar la acción o 0 si hubo un error</returns>
        public Boolean eliminarApartado(Apartado apartado)
        {
            return this.apartadoData.eliminarApartado(apartado);
        }//eliminarApartado

        /// <summary>
        /// Método para obtener los apartados existentes en el sistema
        /// </summary>
        /// <returns>Lista de todos los apartados en el sistema</returns>
        public LinkedList<Apartado> obtenerApartados()
        {
            return this.apartadoData.obtenerApartados();
        }//obtenerApartados

        /// <summary>
        /// Método para obtener datos de un apartado en específico
        /// </summary>
        /// <param name="apartado">Apartado seleccionado</param>
        /// <returns>Apartado existente en la base de datos</returns>
        public Apartado obtenerApartado(Apartado apartado)
        {
            return this.apartadoData.obtenerApartado(apartado);
        }//obtenerApartado

        /// <summary>
        /// Método para actualizar un apartado
        /// </summary>
        /// <param name="apartado">Apartado con los datos modificados</param>
        /// <returns>1 si se pudo completar la acción o 0 si hubo un error</returns>
        public Boolean actualizarApartado(Apartado apartado)
        {
            return this.apartadoData.actualizarApartado(apartado);
        }//actualizarApartado

    }//class
}//namespace