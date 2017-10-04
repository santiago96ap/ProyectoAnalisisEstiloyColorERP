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
        public Boolean insertarAgenda(Agenda agenda)
        {
            return this.agendaData.insertarAgenda(agenda);
        }//insertar agenda

        public Boolean eliminarAgenda(Agenda agenda)
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

        public Boolean actualizarAgenda(Agenda agenda)
        {
            return this.agendaData.actualizarAgenda(agenda);
        }//actualizar una cita en la agenda
    }//class
}//namespace