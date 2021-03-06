﻿using System;
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
        private String stringConeccion;//Este será el String de conexión hacia la BD 
        public AgendaData(string stringConeccion)
        {
            this.stringConeccion = stringConeccion;
        }//constructor

        /// <summary>
        /// Este  metodo lo que realiza es insertar una actividad en la agenda
        /// </summary>
        /// <param name="agenda"></param>
        /// <returns>Boolean</returns>
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

        /// <summary>
        /// Este metodo lo que realiza es eliminar una actividad en la agenda
        /// </summary>
        /// <param name="agenda"></param>
        /// <returns>Boolean</returns>
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


        /// <summary>
        /// Este metodo realiza una busqueda que de las actividades que se encuentran en la fecha solicitada
        /// </summary>
        /// <param name="fecha"></param>
        /// <returns>LinkedList<Agenda></returns>
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



        /// <summary>
        /// Este metodo lo que realiza es obtener todas actividades sin importar alguna fecho o un parametro
        /// </summary>
        /// <returns>LinkedList<Agenda></returns>

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


        /// <summary>
        /// Este metodo lo que realiza es actulizar una actividad que tengan en la fecho y hora puesta
        /// </summary>
        /// <param name="agenda"></param>
        /// <returns></returns>
        public Boolean actualizarAgenda(Agenda agenda)
        {
            SqlConnection connection = new SqlConnection(this.stringConeccion);
            String sqlStoreProcedure = "sp_actualizarAgenda";
            SqlCommand cmdActualizar = new SqlCommand(sqlStoreProcedure, connection);
            cmdActualizar.CommandType = System.Data.CommandType.StoredProcedure;
            cmdActualizar.Parameters.Add(new SqlParameter("@fechaN", agenda.FechaN));
            cmdActualizar.Parameters.Add(new SqlParameter("@fecha", agenda.Fecha));
            cmdActualizar.Parameters.Add(new SqlParameter("@horaN", agenda.HoraN));
            cmdActualizar.Parameters.Add(new SqlParameter("@hora", agenda.Hora));
            cmdActualizar.Parameters.Add(new SqlParameter("@actividad", agenda.Actividad));
            cmdActualizar.Parameters.Add(new SqlParameter("@direccion", agenda.Direccion));
            cmdActualizar.Parameters.Add(new SqlParameter("@id_cliente_tel", agenda.Cliente));

            cmdActualizar.Connection.Open();
            if (cmdActualizar.ExecuteNonQuery() > 0)
            {
                cmdActualizar.Connection.Close();
                return true;
            }
            else
            {
                cmdActualizar.Connection.Close();
                return false;
            }//if-else
        }//actualizar una cita en la agenda
    }//class
}//namespace