using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BUSINESS
{
    public class AgendaBusiness
    {
        public AgendaData agendaData;

        public AgendaBusiness() {
            this.agendaData = new AgendaData();
        }//constructor
        public boolean insertarAgenda()
        {
            this.agendaData.insertarAgenda();
        }//insertar agenda

        public boolean eliminarAgenda()
        {
            this.agendaData.eliminarAgenda();
        }//eliminar venta

        public LinkedList<Agenda> obtenerAgendas()
        {
            this.agendaData.obtenerAgendas();
        }//obtener todas las citas de la agenda

        public Agenda obtenerAgenda()
        {
            this.agendaData.obtenerAgenda();
        }//obtener una cita en la agenda

        public boolean actualizarAgenda()
        {
            this.agendaData.actualizarAgenda();
        }//actualizar una cita en la agenda
    }//class
}//namespace