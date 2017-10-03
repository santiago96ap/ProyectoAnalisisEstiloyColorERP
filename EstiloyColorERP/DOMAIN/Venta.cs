using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOMAIN
{
    public class Venta
    {
        private String fecha;
        private String hora;
        private int cliente;
        private int vendedor;
        private String tipoServicio;
        private int articuloComprado;
        private float subTotal;
        private float total;
        private String tipoPago;
        public void Venta(){
            Fecha = "";
            Hora= "";
            Cliente = 0;
            Vendedor = 0;
            TipoServicio = "";
            ArticuloComprado = 0;
            SubTotal = 0;
            Total = 0;
            TipoPago = "";
        }//constructor

        public void Venta(String fecha, String hora, int cliente, int vendedor, String tipoServicio, int articuloComprado, int subTotal, int total, String tipoPago){
            fecha = fecha;
            hora = hora;
            cliente = cliente;
            vendedor = vendedor;
            tipoServicio = tipoServicio;
            articuloComprado = articuloComprado;
            subTotal = subTotal;
            total = total;
            tipoPago = tipoPago;
        }//constructor sobrecargado
        public string Fecha
        {
            get
            {
                return fecha;
            }

            set
            {
                fecha = value;
            }
        }

        public string Hora
        {
            get
            {
                return hora;
            }

            set
            {
                hora = value;
            }
        }

        public int Cliente
        {
            get
            {
                return cliente;
            }

            set
            {
                cliente = value;
            }
        }

        public int Vendedor
        {
            get
            {
                return vendedor;
            }

            set
            {
                vendedor = value;
            }
        }

        public string TipoServicio
        {
            get
            {
                return tipoServicio;
            }

            set
            {
                tipoServicio = value;
            }
        }

        public int ArticuloComprado
        {
            get
            {
                return articuloComprado;
            }

            set
            {
                articuloComprado = value;
            }
        }

        public float SubTotal
        {
            get
            {
                return subTotal;
            }

            set
            {
                subTotal = value;
            }
        }

        public float Total
        {
            get
            {
                return total;
            }

            set
            {
                total = value;
            }
        }

        public string TipoPago
        {
            get
            {
                return tipoPago;
            }

            set
            {
                tipoPago = value;
            }
        }




    }//class
}//namespace