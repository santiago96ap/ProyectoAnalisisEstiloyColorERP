using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOMAIN
{
    public class Oferta
    {
        private int idProducto;
        private int id;
        private String fechaInicio;
        private String fechaFinal;
        private float descuento;
        private float precioDescuento;

      
        public Oferta()
        {
            this.idProducto = 0;
            this.id = 0;
            this.fechaInicio = "";
            this.fechaFinal = "";
            this.descuento = 0;
            this.precioDescuento = 0;
        }//constructor por defecto

        public Oferta(String fechaInicio, String fechaFinal, float descuento, int idProducto)
        {
            this.idProducto = idProducto;
            this.fechaInicio = fechaInicio;
            this.fechaFinal = fechaFinal;
            this.descuento = descuento;
        }//constructor sobrecargado Oferta

        public Oferta(int id, String fechaInicio, String fechaFinal, float descuento, int idProducto, float precioDescuento)
        {
            this.id = id;
            this.idProducto = idProducto;
            this.fechaInicio = fechaInicio;
            this.fechaFinal = fechaFinal;
            this.descuento = descuento;
            this.precioDescuento = precioDescuento;
        }//constructor sobrecargado Oferta

        public int IdProducto
        {
            get
            {
                return idProducto;
            }

            set
            {
                idProducto = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string FechaInicio
        {
            get
            {
                return fechaInicio;
            }

            set
            {
                fechaInicio = value;
            }
        }

        public string FechaFinal
        {
            get
            {
                return fechaFinal;
            }

            set
            {
                fechaFinal = value;
            }
        }

        public float Descuento
        {
            get
            {
                return descuento;
            }

            set
            {
                descuento = value;
            }
        }

        public float PrecioDescuento
        {
            get
            {
                return precioDescuento;
            }

            set
            {
                precioDescuento = value;
            }
        }


    }//fin de la clase
}//fin de namespace