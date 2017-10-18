using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DOMAIN;

namespace DATA
{
    public class VentaData
    {
        private String stringConeccion;
        public VentaData(string stringConeccion)
        {
            this.stringConeccion = stringConeccion;
        }//constructor

        public Boolean insertarVenta(Venta venta){
            return false;
        }//insertar venta

        public Boolean eliminarVenta(Venta venta)
        {
            return false;
        }//eliminar venta

        public LinkedList<Venta> obtenerVentas()
        {
            return null;
        }//obtener todas las ventas

        public Venta obtenerVenta(Venta venta)
        {
            return null;
        }//obtener una venta
    }//class
}//namespace