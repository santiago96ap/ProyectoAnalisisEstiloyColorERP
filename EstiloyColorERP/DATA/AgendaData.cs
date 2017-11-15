using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using DOMAIN;

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
            SqlConnection connection = new SqlConnection(this.stringConeccion);
            String sqlStoreProcedure = "sp_eliminarAgenda";
            SqlCommand cmdEliminar = new SqlCommand(sqlStoreProcedure, connection);
            cmdEliminar.CommandType = System.Data.CommandType.StoredProcedure;

            cmdEliminar.Parameters.Add(new SqlParameter("@fecha", agenda.Fecha));
            cmdEliminar.Parameters.Add(new SqlParameter("@hora", agenda.Hora));
            cmdEliminar.Connection.Open();
            if (cmdEliminar.ExecuteNonQuery() > 0)
            {
                cmdEliminar.Connection.Close();
                return true;
            }
            else
            {
                cmdEliminar.Connection.Close();
                return false;
            }
        }//eliminar venta

        public LinkedList<Agenda> obtenerAgendasFecha(String fecha)
        {
            SqlConnection connection = new SqlConnection(this.stringConeccion);

            String sqlSelect = "sp_obtenerAgendaFecha";

            SqlDataAdapter sqlDataAdapterAgenda = new SqlDataAdapter();

            sqlDataAdapterAgenda.SelectCommand = new SqlCommand(sqlSelect, connection);
            sqlDataAdapterAgenda.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlDataAdapterAgenda.SelectCommand.Parameters.Add(new SqlParameter("@Fecha", fecha));

            DataSet dataSetAgenda = new DataSet();
            sqlDataAdapterAgenda.Fill(dataSetAgenda, "tb_Agenda");
            sqlDataAdapterAgenda.SelectCommand.Connection.Close();

            DataRowCollection dataRow = dataSetAgenda.Tables["tb_Agenda"].Rows;

            LinkedList<Agenda> actividades = new LinkedList<Agenda>();

            foreach (DataRow currentRow in dataRow)
            {
                Agenda agendaActual = new Agenda();
                agendaActual.Fecha = currentRow["fecha"].ToString().Split(' ')[0];
                agendaActual.Hora = currentRow["hora"].ToString();
                agendaActual.Actividad = currentRow["actividad"].ToString();
                agendaActual.Direccion = currentRow["direccion"].ToString();
                agendaActual.Cliente = currentRow["id_cliente_tel"].ToString();
                actividades.AddLast(agendaActual);
            }//recorrer todos los clientes que vienen de la DB
            return actividades;
        }//obtener todas las citas de la agenda

        public LinkedList<Agenda> obtenerAgendas()
        {
            SqlConnection connection = new SqlConnection(this.stringConeccion);

            String sqlSelect = "sp_obtenerTodaAgenda;";

            SqlDataAdapter sqlDataAdapterAgenda = new SqlDataAdapter();
            sqlDataAdapterAgenda.SelectCommand = new SqlCommand();
            sqlDataAdapterAgenda.SelectCommand.CommandText = sqlSelect;
            sqlDataAdapterAgenda.SelectCommand.Connection = connection;

            DataSet dataSetAgenda = new DataSet();
            sqlDataAdapterAgenda.Fill(dataSetAgenda, "tb_Agenda");
            sqlDataAdapterAgenda.SelectCommand.Connection.Close();

            DataRowCollection dataRow = dataSetAgenda.Tables["tb_Agenda"].Rows;

            LinkedList<Agenda> actividades = new LinkedList<Agenda>();

            foreach (DataRow currentRow in dataRow)
            {
                Agenda agendaActual = new Agenda();
                agendaActual.Fecha = currentRow["fecha"].ToString().Split(' ')[0];
                agendaActual.Hora = currentRow["hora"].ToString();
                agendaActual.Actividad = currentRow["actividad"].ToString();
                agendaActual.Direccion = currentRow["direccion"].ToString();
                agendaActual.Cliente = currentRow["id_cliente_tel"].ToString();
                actividades.AddLast(agendaActual);
            }//recorrer todos los clientes que vienen de la DB
            return actividades;
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