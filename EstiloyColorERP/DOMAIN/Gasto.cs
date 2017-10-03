using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOMAIN
{
    public class Gasto
    {
        //Atributos
        private String fecha;
        private String hora;
        private String concepto;
        private float total;
        private String vendedor;
        
        public Gasto()
        {

            this.fecha = "";
            this.hora = "";
            this.concepto = "";
            this.total = "";
            this.vendedor = "";

        }//constructor por defecto

        public Gasto(String fecha, String hora, String concepto, float total, String vendedor)
        {

            this.fecha = fecha;
            this.hora = hora;
            this.concepto = concepto;
            this.total = total;
            this.vendedor = vendedor;

        }//constructor sobrecargado

        //OBTENER e INSERTAR
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

        public string Concepto
        {
            get
            {
                return concepto;
            }

            set
            {
                concepto = value;
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

        public string Vendedor
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

    }//fin de clase

}//fin de namespace