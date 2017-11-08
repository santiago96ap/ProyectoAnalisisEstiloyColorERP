using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOMAIN
{
    public class VentaProducto
    {
        private int idProduco;
        private int idCategoria;
        private float total;
        private string fecha;
        private string hora;
        private string idCliente;

        public VentaProducto(int idProduco, int idCategoria, float total, string fecha, string hora, string idCliente)
        {
            this.idProduco = idProduco;
            this.idCategoria = idCategoria;
            this.total = total;
            this.fecha = fecha;
            this.hora = hora;
            this.idCliente = idCliente;
        }//constructor sobre cargado

        public VentaProducto()
        {
            this.idProduco = 0;
            this.idCategoria = 0;
            this.total = 0;
            this.fecha = "";
            this.hora = "";
            this.idCliente = "";
        }//constructor sobre cargado

        public int IdProduco
        {
            get
            {
                return idProduco;
            }

            set
            {
                idProduco = value;
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

        public string IdCliente
        {
            get
            {
                return idCliente;
            }

            set
            {
                idCliente = value;
            }
        }


    }//class
}//namespace