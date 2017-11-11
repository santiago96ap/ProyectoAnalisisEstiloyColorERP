using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOMAIN
{
    public class Gasto
    {
        //Atributos
        private int id;
        private String fecha;
        private String hora;
        private String concepto;
        private float total;
        private String vendedor;
        private String servico;

        public Gasto()
        {

            this.fecha = "";
            this.hora = "";
            this.concepto = "";
            this.total = 0;
            this.vendedor = "";

        }//constructor por defecto

        public Gasto(String fecha, String hora, String concepto, float total, String vendedor, string servicio)
        {

            this.fecha = fecha;
            this.hora = hora;
            this.concepto = concepto;
            this.total = total;
            this.vendedor = vendedor;
            this.servico = servicio;

        }//constructor sobrecargado

        public Gasto(int id, String fecha, String hora, String concepto, float total, String vendedor, string servicio)
        {
            this.id = id;
            this.fecha = fecha;
            this.hora = hora;
            this.concepto = concepto;
            this.total = total;
            this.vendedor = vendedor;
            this.servico = servicio;

        }//constructor sobrecargado

        //OBTENER e INSERTAR

        public int Id
        {
            get
            {
                return this.id;
            }

            set
            {
                this.id = value;
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

        public string Servicio
        {
            get
            {
                return servico;
            }

            set
            {
                servico = value;
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