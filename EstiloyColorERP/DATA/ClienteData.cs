﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DOMAIN;

namespace DATA
{
    public class ClienteData
    {

        private String stringConeccion;

        public ClienteData(string stringConeccion)
        {
            this.stringConeccion = stringConeccion;
        }//constructor

        public Boolean insertarCliente(Cliente cliente)
        {
            SqlConnection connection = new SqlConnection(this.conectionString);
            String sqlStoreProcedure = "sp_insertarCliente";
            SqlCommand cmdInsertar = new SqlCommand(sqlStoreProcedure, connection);
            cmdInsertar.CommandType = System.Data.CommandType.StoredProcedure;

            cmdInsertar.Parameters.Add(new SqlParameter("@telefono", cliente.Telefono));
            cmdInsertar.Parameters.Add(new SqlParameter("@nombre", cliente.Nombre));
            cmdInsertar.Parameters.Add(new SqlParameter("@apellidos", cliente.Apellidos));
            cmdInsertar.Parameters.Add(new SqlParameter("@direccion", cliente.Direccion));
            cmdInsertar.Parameters.Add(new SqlParameter("@email", cliente.Correo));

            cmdInsertar.Connection.Open();
            cmdInsertar.ExecuteNonQuery();
            cmdInsertar.Connection.Close();
            return true;
        }//insertarCliente

        public Boolean actualizarCliente(Cliente cliente)
        {
            SqlConnection connection = new SqlConnection(this.conectionString);
            String sqlStoreProcedure = "sp_actualizarCliente";
            SqlCommand cmdActualizar = new SqlCommand(sqlStoreProcedure, connection);
            cmdActualizar.CommandType = System.Data.CommandType.StoredProcedure;

            cmdActualizar.Parameters.Add(new SqlParameter("@telefono", cliente.Telefono));
            cmdActualizar.Parameters.Add(new SqlParameter("@nombre", cliente.Nombre));
            cmdActualizar.Parameters.Add(new SqlParameter("@apellidos", cliente.Apellidos));
            cmdActualizar.Parameters.Add(new SqlParameter("@direccion", cliente.Direccion));
            cmdActualizar.Parameters.Add(new SqlParameter("@email", cliente.Correo));

            cmdActualizar.Connection.Open();
            cmdActualizar.ExecuteNonQuery();
            cmdActualizar.Connection.Close();
            return true;
        }//actualizarCliente

        public LinkedList<Cliente> obtenerClientes()
        {
            SqlConnection connection = new SqlConnection(this.conectionString);

            String sqlSelect = "sp_obtenerTodosCliente;";

            SqlDataAdapter sqlDataAdapterClient = new SqlDataAdapter();
            sqlDataAdapterClient.SelectCommand = new SqlCommand();
            sqlDataAdapterClient.SelectCommand.CommandText = sqlSelect;
            sqlDataAdapterClient.SelectCommand.Connection = connection;

            DataSet dataSetClientes = new DataSet();
            sqlDataAdapterClient.Fill(dataSetClientes, "tb_Cliente");
            sqlDataAdapterClient.SelectCommand.Connection.Close();

            DataRowCollection dataRow = dataSetClientes.Tables["tb_Cliente"].Rows;

            LinkedList<Cliente> clientes = new LinkedList<Cliente>();

            foreach (DataRow currentRow in dataRow)
            {
                Cliente clienteActual = new Cliente();
                clienteActual.Telefono = currentRow["telefono"].ToString();
                clienteActual.Nombre = currentRow["nombre"].ToString();
                clienteActual.Apellidos = currentRow["apellidos"].ToString();
                clienteActual.Direccion = currentRow["direccion"].ToString();
                clienteActual.Correo = currentRow["email"].ToString();
                clientes.AddLast(clienteActual);
            }//foreach
            return clientes;
        }//obtenerClientes

        public Cliente obtenerCliente(Cliente cliente)
        {
            LinkedList<Cliente> clientes = obtenerClientes();
            foreach (Cliente clienteActual in clientes)
            {
                if (cliente.Telefono.Equals(clienteActual.Telefono))
                {
                    return clienteActual;
                }
            }
            return null;
        }//obtenerCliente

    }//class
}//namespace