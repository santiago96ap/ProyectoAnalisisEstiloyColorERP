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
        private int cliente;
 public void Agenda()
        {
            Fecha = "";
            Hora = "";
            actividad = "";
            direccion= "";
            cliente = 0;
        }//constructor

        public void Agenda(String fecha, String hora,String actividad, String direccion, int cliente)
        {
            fecha = fecha;
            hora = hora;
            actividad = actividad;
            direccion = direccion;
            cliente = cliente;
        }//constructor sobrecargado
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

        public string Actividad
        {
            get
            {
                return actividad;
            }

            set
            {
                actividad = value;
            }
        }

        public string Direccion
        {
            get
            {
                return direccion;
            }

            set
            {
                direccion = value;
            }
        }

        public int Cliente
        {
            get
            {
                return cliente;
            }

            set
            {
                cliente = value;
            }
        }

       
    }//class
}//namespace