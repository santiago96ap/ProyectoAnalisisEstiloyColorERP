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

            this.Fecha = "";
            this.Hora = "";
            this.Concepto = "";
            this.Total = 0;
            this.Vendedor = "";

        }//constructor por defecto

        public Gasto(String fecha, String hora, String concepto, float total, String vendedor)
        {

            this.Fecha = fecha;
            this.Hora = hora;
            this.Concepto = concepto;
            this.Total = total;
            this.Vendedor = vendedor;

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