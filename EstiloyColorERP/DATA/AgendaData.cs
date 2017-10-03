using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DOMAIN;

namespace DATA
{
    public class AgendaData
    {
        public Boolean insertarAgenda(Agenda agenda)
        {
            return false;
        }//insertar agenda

        public Boolean eliminarAgenda(Agenda agenda)
        {
            return false;
        }//eliminar venta

        public LinkedList<Agenda> obtenerAgendas()
        {
            return null;
        }//obtener todas las citas de la agenda

        public Agenda obtenerAgenda(Agenda agenda)
        {
            return null;
        }//obtener una cita en la agenda

        public Boolean actualizarAgenda(Agenda agenda)
        {
            return false;
        }//actualizar una cita en la agenda
    }//class
}//namespace