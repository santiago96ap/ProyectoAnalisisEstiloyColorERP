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
        private VentaData ventaData;
        private string stringConeccion;

        public VentaBusiness()
        {
            this.stringConeccion = WebConfigurationManager.ConnectionStrings["BaseDatos"].ToString();
            this.ventaData = new VentaData(this.stringConeccion);
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

        public Boolean insertarVentaProducto(VentaProducto vp)
        {
            return this.ventaData.insertarVentaProducto(vp);
        }//insertarVentaProducto

        public LinkedList<Venta> obtenerVentasEliminar(String fechaI, String fechaF)
        {
            return this.ventaData.obtenerVentasEliminar(fechaI, fechaF);
        }//obtener ventas eliminar
    }//class
}//namespace