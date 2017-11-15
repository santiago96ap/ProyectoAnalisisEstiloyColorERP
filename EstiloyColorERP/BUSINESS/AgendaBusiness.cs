using System;
using System.Collections.Generic;
using System.Web.Configuration;
using System.Linq;
using System.Web;
using DOMAIN;
using DATA;

namespace BUSINESS
{
    public class AgendaBusiness
    {
        private AgendaData agendaData;
        private string stringConeccion;

        public AgendaBusiness() {
            this.stringConeccion = WebConfigurationManager.ConnectionStrings["BaseDatos"].ToString();
            this.agendaData = new AgendaData(this.stringConeccion);
        }//constructor
        public Boolean insertarAgenda(Agenda agenda)
        {
            return this.agendaData.insertarAgenda(agenda);
        }//insertar agenda

        public Boolean eliminarAgenda(Agenda agenda)
        {
            return this.agendaData.eliminarAgenda(agenda);
        }//eliminar venta

        public LinkedList<Agenda> obtenerAgendasFecha(String fecha)
        {
            return this.agendaData.obtenerAgendasFecha(fecha);
        }//obtener todas las citas de la agenda

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