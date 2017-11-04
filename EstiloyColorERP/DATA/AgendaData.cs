using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DOMAIN;
using System.Data.SqlClient;

namespace DATA
{
    public class AgendaData
    {
        private String stringConeccion;
        public AgendaData(string stringConeccion)
        {
            this.stringConeccion = stringConeccion;
        }//constructor

        public Boolean insertarAgenda(Agenda agenda)
        {
            SqlConnection connection = new SqlConnection(this.stringConeccion);
            String sqlStoreProcedure = "sp_insertarAgenda";
            SqlCommand cmdInsertar = new SqlCommand(sqlStoreProcedure, connection);
            cmdInsertar.CommandType = System.Data.CommandType.StoredProcedure;
            cmdInsertar.Parameters.Add(new SqlParameter("@fecha", agenda.Fecha));
            cmdInsertar.Parameters.Add(new SqlParameter("@hora", agenda.Hora));
            cmdInsertar.Parameters.Add(new SqlParameter("@actividad", agenda.Actividad));
            cmdInsertar.Parameters.Add(new SqlParameter("@direccion", agenda.Direccion));
            cmdInsertar.Parameters.Add(new SqlParameter("@id_cliente_tel", agenda.Cliente));

            cmdInsertar.Connection.Open();
            if (cmdInsertar.ExecuteNonQuery() > 0)
            {
                cmdInsertar.Connection.Close();
                return true;
            }
            else
            {
                cmdInsertar.Connection.Close();
                return false;
            }//if-else
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