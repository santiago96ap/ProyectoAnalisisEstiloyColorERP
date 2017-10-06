using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOMAIN
{
    public class Producto
    {
        private int idProct;
        private String nombre;
        private String descripcion;
        private float costo;
        private float precio;
        private int cantidad;
        private int idProveedor;
        private int idCategoria;

        public Producto(int idProct, string nombre, string descripcion, float costo, float precio, int cantidad, int idProveedor, int idCategoria)
        {
            this.idProct = idProct;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.costo = costo;
            this.precio = precio;
            this.cantidad = cantidad;
            this.idProveedor = idProveedor;
            this.idCategoria = idCategoria;
        }//constructor

        public Producto()
        {
            this.idProct = 0;
            this.nombre = "";
            this.descripcion ="";
            this.costo = 0;
            this.precio = 0;
            this.cantidad = 0;
            this.idProveedor = 0;
            this.idCategoria = 0;
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

        public int IdProveedor
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
    }//class
}//namespace