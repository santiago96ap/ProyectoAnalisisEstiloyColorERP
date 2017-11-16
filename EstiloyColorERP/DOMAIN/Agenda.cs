using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOMAIN
{
    public class Agenda
    {
        /// <summary>
        /// La clase Agenda viene a representar las actividades que se pueden realizar en una fecha y hora establecidos
        /// Esto porque se brinda el servicio de diseño de interiores a domicilio.
        /// </summary>
        private String fecha;
        private String hora;
        private String fechaN;
        private String horaN;
        private String actividad;
        private String direccion;
        private String cliente;
        public Agenda()
        {
            Fecha = "";
            Hora = "";
            actividad = "";
            direccion= "";
            cliente = "";
        }//constructor

        public Agenda(String fecha, String hora,String actividad, String direccion, String cliente)
        {
            this.fecha = fecha;
            this.hora = hora;
            this.actividad = actividad;
            this.direccion = direccion;
            this.cliente = cliente;
        }//constructor sobrecargado


        /// <summary>
        /// Este constructor se utiliza cuando se va actualizar una actividad en la agenda
        /// </summary>
        /// <param name="fechaN"></param>
        /// <param name="horaN"></param>
        /// <param name="fecha"></param>
        /// <param name="hora"></param>
        /// <param name="actividad"></param>
        /// <param name="direccion"></param>
        /// <param name="cliente"></param>
        public Agenda(String fechaN, String horaN, String fecha, String hora, String actividad, String direccion, String cliente)
        {
            this.fecha = fecha;
            this.hora = hora;
            this.actividad = actividad;
            this.direccion = direccion;
            this.cliente = cliente;
            this.fechaN = fechaN;
            this.horaN = horaN;
        }//constructor sobrecargado
        public string Fecha
        {
            get
            {
                return fecha;
            }//get fecha

            set
            {
                fecha = value;
            }//set fecha
        }//set y get fecha

        public string Hora
        {
            get
            {
                return hora;
            }//get hora

            set
            {
                hora = value;
            }//set hora
        }//set y get hora

        public string Actividad
        {
            get
            {
                return actividad;
            }//get actividad

            set
            {
                actividad = value;
            }//set actividad
        }//set y get actividad

        public string Direccion
        {
            get
            {
                return direccion;
            }//get direccion

            set
            {
                direccion = value;
            }//set direccion
        }//set y get direccion

        public String Cliente
        {
            get
            {
                return cliente;
            }//get cliente

            set
            {
                cliente = value;
            }//set cliente
        }//set y get cliente

        public string FechaN
        {
            get
            {
                return fechaN;
            }

            set
            {
                fechaN = value;
            }
        }

        public string HoraN
        {
            get
            {
                return horaN;
            }

            set
            {
                horaN = value;
            }
        }
    }//class
}//namespace