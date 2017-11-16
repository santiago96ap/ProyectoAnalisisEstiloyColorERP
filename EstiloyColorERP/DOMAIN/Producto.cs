using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOMAIN
{
    public class Producto
    {
        /// <summary>
        /// La clase producto representa a todos los elementos existentes en el inventario por parte de la empresa los mismos se pueden adquirir
        /// por clientes al realizar una compra(Venta)
        /// </summary>

        private int idProct;
        private String nombre;
        private String descripcion;
        private float costo;
        private float precio;
        private int cantidad;
        private String idProveedor;
        private int idCategoria;

        private float descuento;
        private float precioDescuento;

        public Producto(int idProct, string nombre, string descripcion, float costo, float precio, int cantidad, string idProveedor, int idCategoria)
        {
            this.idProct = idProct;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.costo = costo;
            this.precio = precio;
            this.cantidad = cantidad;
            this.idProveedor = idProveedor;
            this.idCategoria = idCategoria;

            this.descuento = 0;
            this.precioDescuento = 0;
        }//constructor

        public Producto()
        {
            this.idProct = 0;
            this.nombre = "";
            this.descripcion ="";
            this.costo = 0;
            this.precio = 0;
            this.cantidad = 0;
            this.idProveedor = "";
            this.idCategoria = 0;

            this.descuento = 0;
            this.precioDescuento = 0;
        }//constructor default


        //Médodos accesores
        public int IdProct
        {
            get
            {
                return idProct;
            }

            set
            {
                idProct = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }

        public float Costo
        {
            get
            {
                return costo;
            }

            set
            {
                costo = value;
            }
        }

        public float Precio
        {
            get
            {
                return precio;
            }

            set
            {
                precio = value;
            }
        }

        public int Cantidad
        {
            get
            {
                return cantidad;
            }

            set
            {
                cantidad = value;
            }
        }

        public string IdProveedor
        {
            get
            {
                return idProveedor;
            }

            set
            {
                idProveedor = value;
            }
        }

        public int IdCategoria
        {
            get
            {
                return idCategoria;
            }

            set
            {
                idCategoria = value;
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
    }//class
}//namespace