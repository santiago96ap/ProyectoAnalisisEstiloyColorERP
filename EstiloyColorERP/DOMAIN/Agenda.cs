using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOMAIN
{
    public class Agenda
    {
        private String fecha;
        private String hora;
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

       
    }//class
}//namespace