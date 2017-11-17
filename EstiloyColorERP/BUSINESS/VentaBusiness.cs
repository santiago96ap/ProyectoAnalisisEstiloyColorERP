using System;
using System.Collections.Generic;
using System.Web.Configuration;
using System.Linq;
using System.Web;
using DOMAIN;
using DATA;

namespace BUSINESS
{
    public class VentaBusiness
    {
        /// <summary>
        /// Clase encargadad de las reglas de negocios para acceder a la base de datos
        /// </summary>

        //Atributos
        private VentaData ventaData;
        private string stringConeccion;

        /// <summary>
        /// Método constructor de la clase
        /// </summary>
        public VentaBusiness()
        {
            this.stringConeccion = WebConfigurationManager.ConnectionStrings["BaseDatos"].ToString();
            this.ventaData = new VentaData(this.stringConeccion);
        }//constructor

        /// <summary>
        /// Método por el cual se inserta una nueva venta en el sistema
        /// </summary>
        /// <param name="venta">Venta creada por un usuario</param>
        /// <returns>1 si se pudo completar la acción o 0 si hubo un error</returns>
        public Boolean insertarVenta(Venta venta)
        {
            return this.ventaData.insertarVenta(venta);
        }//insertar venta

        /// <summary>
        /// Método encargado de la eliminación de una venta realizada
        /// </summary>
        /// <param name="venta">Venta la cual se desee eliminar</param>
        /// <returns>1 si se pudo completar la acción o 0 si hubo un error</returns>
        public Boolean eliminarVenta(Venta venta)
        {
            return this.ventaData.eliminarVenta(venta);
        }//eliminar venta

        /// <summary>
        /// Método encargado de obtener todas las ventas existentes en el sistema
        /// </summary>
        /// <returns>Lista con todas las ventas que existan en la base de datos</returns>
        public LinkedList<Venta> obtenerVentas()
        {
            return this.ventaData.obtenerVentas();
        }//obtener todas las ventas

        /// <summary>
        /// Método por el cual se puede obtener una venta en específico
        /// </summary>
        /// <param name="venta">Venta a la que se quiere tener acceso</param>
        /// <returns>Venta existente en la base de datos</returns>
        public Venta obtenerVenta(Venta venta)
        {
            return this.ventaData.obtenerVenta(venta);
        }//obtener una venta

        /// <summary>
        /// Método que inserta un producto que se encuentre en una venta 
        /// </summary>
        /// <param name="vp">Producto que se vendió o se registra en una venta</param>
        /// <returns>1 si se pudo completar la acción o 0 si hubo un error</returns>
        public Boolean insertarVentaProducto(VentaProducto vp)
        {
            return this.ventaData.insertarVentaProducto(vp);
        }//insertarVentaProducto

        /// <summary>
        /// Método que obtiene las ventas que se eliminaron en un rango de fecha
        /// </summary>
        /// <param name="fechaI">Fecha inicial del rango</param>
        /// <param name="fechaF">Fecha final del rango</param>
        /// <returns>Lista de las ventas eliminadas que se encuentren en ese rango de fechas</returns>
        public LinkedList<Venta> obtenerVentasEliminar(String fechaI, String fechaF)
        {
            return this.ventaData.obtenerVentasEliminar(fechaI, fechaF);
        }//obtener ventas eliminar
    }//class
}//namespace