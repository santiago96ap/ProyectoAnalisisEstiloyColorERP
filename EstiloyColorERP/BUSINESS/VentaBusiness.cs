using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DOMAIN;
using DATA;

namespace BUSINESS
{
    public class VentaBusiness
    {
        public VentaData ventaData;

        public VentaBusiness(string stringConeccion)
        {
            this.ventaData = new VentaData(stringConeccion);
        }//constructor

        public Boolean insertarVenta(Venta venta)
        {
            return this.ventaData.insertarVenta(venta);
        }//insertar venta

        public Boolean eliminarVenta(Venta venta)
        {
            return this.ventaData.eliminarVenta(venta);
        }//eliminar venta

        public LinkedList<Venta> obtenerVentas()
        {
            return this.ventaData.obtenerVentas();
        }//obtener todas las ventas

        public Venta obtenerVenta(Venta venta)
        {
            return this.ventaData.obtenerVenta(venta);
        }//obtener una venta
    }//class
}//namespace