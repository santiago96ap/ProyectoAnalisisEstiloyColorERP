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
        /// <summary>
        /// Clase encargadad de las reglas de negocios para acceder a la base de datos
        /// </summary>

        //Atributos
        private AgendaData agendaData;
        private string stringConeccion;

        /// <summary>
        /// Método constructor de la clase
        /// </summary>
        public AgendaBusiness() {
            this.stringConeccion = WebConfigurationManager.ConnectionStrings["BaseDatos"].ToString();
            this.agendaData = new AgendaData(this.stringConeccion);
        }//constructor

        /// <summary>
        /// Método encargado de insertar una actividad en la agenda
        /// </summary>
        /// <param name="agenda"></param>
        /// <returns>1 si se pudo insertar o 0 si no se logró la operación</returns>
        public Boolean insertarAgenda(Agenda agenda)
        {
            return this.agendaData.insertarAgenda(agenda);
        }//insertar agenda

        /// <summary>
        /// Método encargado de eliminar una actividad en la agenda
        /// </summary>
        /// <param name="agenda"></param>
        /// <returns>1 si se pudo eliminar o 0 si no se logró la operación</returns>
        public Boolean eliminarAgenda(Agenda agenda)
        {
            return this.agendaData.eliminarAgenda(agenda);
        }//eliminar venta

        /// <summary>
        /// Método encargado de devolver las actividades en agenda por una fecha específica
        /// </summary>
        /// <param name="fecha"></param>
        /// <returns>Retorna la lista de actividades en la Agenda en la fecha indicada</returns>
        public LinkedList<Agenda> obtenerAgendasFecha(String fecha)
        {
            return this.agendaData.obtenerAgendasFecha(fecha);
        }//obtenerAgendasFecha

        /// <summary>
        /// Método encargado de obtener todas las actividades existentes
        /// </summary>
        /// <returns>Devuelve una lista de actividades existentes en la base de datos</returns>
        public LinkedList<Agenda> obtenerAgendas()
        {
            return this.agendaData.obtenerAgendas();
        }//obtenerAgendas

        /// <summary>
        /// Método encargado de obtener una actividad indicada
        /// </summary>
        /// <param name="agenda"></param>
        /// <returns>Devuelve el objeto encontrado si existe sino devuelve nulo</returns>
        public Agenda obtenerAgenda(Agenda agenda)
        {
            return this.agendaData.obtenerAgenda(agenda);
        }//obtenerAgenda

        /// <summary>
        /// Método encargado de actualizar una actividad existente en la base de datos
        /// </summary>
        /// <param name="agenda">Actividad modificada</param>
        /// <returns>1 si se completó la acción 0 si no se tuvo éxito</returns>
        public Boolean actualizarAgenda(Agenda agenda)
        {
            return this.agendaData.actualizarAgenda(agenda);
        }//actualizarAgenda

    }//class
}//namespace