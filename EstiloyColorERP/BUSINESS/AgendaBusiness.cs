using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DOMAIN;
using DATA;

namespace BUSINESS
{
    public class AgendaBusiness
    {
        public AgendaData agendaData;

        public AgendaBusiness() {
            this.agendaData = new AgendaData();
        }//constructor
        public boolean insertarAgenda(Agenda agenda)
        {
            return this.agendaData.insertarAgenda(agenda);
        }//insertar agenda

        public boolean eliminarAgenda(Agenda agenda)
        {
            return this.agendaData.eliminarAgenda(agenda);
        }//eliminar venta

        public LinkedList<Agenda> obtenerAgendas()
        {
            return this.agendaData.obtenerAgendas();
        }//obtener todas las citas de la agenda

        public Agenda obtenerAgenda(Agenda agenda)
        {
            return this.agendaData.obtenerAgenda(agenda);
        }//obtener una cita en la agenda

        public boolean actualizarAgenda(Agenda agenda)
        {
            return this.agendaData.actualizarAgenda(agenda);
        }//actualizar una cita en la agenda
    }//class
}//namespace