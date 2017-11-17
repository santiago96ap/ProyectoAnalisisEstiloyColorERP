using DATA;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace BUSINESS
{
    public class OfertaBusiness
    {
        /// <summary>
        /// Clase encargadad de las reglas de negocios para acceder a la base de datos
        /// </summary>

        //Atributos
        private OfertaData ofertaData;
        private String stringConeccion;

        /// <summary>
        /// Método constructor de la clase
        /// </summary>
        public OfertaBusiness()
        {
            this.stringConeccion = WebConfigurationManager.ConnectionStrings["BaseDatos"].ToString();
            this.ofertaData = new OfertaData(this.stringConeccion);
        }//constructor

        /// <summary>
        /// Método encargado de insertar una oferta relacionada a un producto
        /// </summary>
        /// <param name="oferta">Oferta nueva creada por un usuario</param>
        /// <returns>1 si se pudo completar la acción o 0 si hubo un error</returns>
        public Boolean insertarOfertaProducto(Oferta oferta)//Producto producto,
        {
            return this.ofertaData.insertarOfertaProducto(oferta);//producto,
        }//insertarOfertaProducto

        /// <summary>
        /// Método encargado de eliminar una Oferta existente
        /// </summary>
        /// <param name="oferta">Oferta que se desee eliminar</param>
        /// <returns>1 si se pudo completar la acción o 0 si hubo un error</returns>
        public Boolean eliminarOferta(Oferta oferta)
        {
            return this.ofertaData.eliminarOferta(oferta);
        }//eliminarOferta

        /// <summary>
        /// Método encargado de modificar datos de una oferta exietene 
        /// </summary>
        /// <param name="oferta">Oferta modificada</param>
        /// <returns>1 si se pudo completar la acción o 0 si hubo un error</returns>
        public Boolean editarOferta(Oferta oferta)
        {
            return this.ofertaData.editarOferta(oferta);
        }//editarOferta

        /// <summary>
        /// Método que devuelve todas las ofertas existentes
        /// </summary>
        /// <returns>Lista con todas las ofertas que se encuentren en la base de datos</returns>
        public LinkedList<Oferta> obtenerOfertas()
        {
            return this.ofertaData.obtenerOfertas();
        }//obtenerOfertas

        /// <summary>
        /// Método que devuelve una cantidad de ofertas en un rango de fechas
        /// </summary>
        /// <param name="fechaI">Fecha inicial del rango</param>
        /// <param name="fechaF">Fecha final del rango</param>
        /// <returns>Lista con las ofertas en la base de datos que se encuentren en el rango indicado</returns>
        public LinkedList<Oferta> obtenerOfertaFecha(String fechaI, String fechaF)
        {
            return this.ofertaData.obtenerOfertaFecha(fechaI, fechaF);
        }//obtenerOfertaFecha

    }//fin de clase OfertaBusiness
}//fin de namespace