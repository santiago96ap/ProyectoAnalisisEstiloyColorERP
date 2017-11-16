using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOMAIN
{
    public class Ingreso
    {

        /// <summary>
        /// Se registra o se establece como cualquier motivo que permite adquirir dinero por parte de la empresa.
        /// </summary>
        private int id;
        private String fecha;
        private String hora;
        private String concepto;
        private float total;
        private String usuario;

        public Ingreso(string fecha, string hora, string concepto, float total, string usuario)
        {
            this.fecha = fecha;
            this.hora = hora;
            this.concepto = concepto;
            this.total = total;
            this.usuario = usuario;
        }//constructor sobreCargado
        public Ingreso(int id,string fecha, string hora, string concepto, float total, string usuario)
        {
            this.id = id;
            this.fecha = fecha;
            this.hora = hora;
            this.concepto = concepto;
            this.total = total;
            this.usuario = usuario;
        }

        public Ingreso()
        {
            this.id = 0;
            this.fecha = "";
            this.hora = "";
            this.concepto = "";
            this.total =0;
            this.usuario = "";
        }//constructor default

        //Métodos accesores
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

        public string Usuario
        {
            get
            {
                return usuario;
            }

            set
            {
                usuario = value;
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
    }//class
}//namespace