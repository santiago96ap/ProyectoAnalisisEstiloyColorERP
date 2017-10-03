using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BUSINESS
{
    public class VentaBusiness
    {
        public VentaData ventaData;

        public VentaBusiness()
        {
           this.ventaData = new VentaData();
        }//constructor

        public boolean insertarVenta()
        {
            this.ventaData.insertarVenta();
        }//insertar venta

        public boolean eliminarVenta()
        {
            this.ventaData.eliminarVenta();
        }//eliminar venta

        public LinkedList<Venta> obtenerVentas()
        {
            this.ventaData.obtenerVentas();
        }//obtener todas las ventas

        public Venta obtenerVenta()
        {
            this.ventaData.obtenerVenta();
        }//obtener una venta
    }//class
}//namespace