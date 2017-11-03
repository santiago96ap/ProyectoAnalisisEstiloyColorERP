using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using DOMAIN;

namespace DATA{
    public class ClienteData{

        private String stringConeccion;

        public ClienteData(string stringConeccion){
            this.stringConeccion = stringConeccion;
        }//constructor

        public Boolean insertarCliente(Cliente cliente){
            SqlConnection connection = new SqlConnection(this.stringConeccion);
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
        }//insertarCliente

        public Boolean actualizarCliente(Cliente cliente, String clienteV){
            SqlConnection connection = new SqlConnection(this.stringConeccion);
            String sqlStoreProcedure = "sp_actualizarCliente";
            SqlCommand cmdActualizar = new SqlCommand(sqlStoreProcedure, connection);
            cmdActualizar.CommandType = System.Data.CommandType.StoredProcedure;

            cmdActualizar.Parameters.Add(new SqlParameter("@telefonoN", cliente.Telefono));
            cmdActualizar.Parameters.Add(new SqlParameter("@telefono", clienteV));
            cmdActualizar.Parameters.Add(new SqlParameter("@nombre", cliente.Nombre));
            cmdActualizar.Parameters.Add(new SqlParameter("@apellidos", cliente.Apellidos));
            cmdActualizar.Parameters.Add(new SqlParameter("@direccion", cliente.Direccion));
            cmdActualizar.Parameters.Add(new SqlParameter("@email", cliente.Correo));

            cmdActualizar.Connection.Open();
            cmdActualizar.ExecuteNonQuery();
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

        }//actualizarCliente

        public LinkedList<Cliente> obtenerClientes(){
            SqlConnection connection = new SqlConnection(this.stringConeccion);

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

            foreach (DataRow currentRow in dataRow){
                Cliente clienteActual = new Cliente();
                clienteActual.Telefono = currentRow["telefono"].ToString();
                clienteActual.Nombre = currentRow["nombre"].ToString();
                clienteActual.Apellidos = currentRow["apellidos"].ToString();
                clienteActual.Direccion = currentRow["direccion"].ToString();
                clienteActual.Correo = currentRow["email"].ToString();
                clientes.AddLast(clienteActual);
            }//recorrer todos los clientes que vienen de la DB
            return clientes;
        }//obtenerClientes

        public Cliente obtenerCliente(Cliente cliente){
            LinkedList<Cliente> clientes = obtenerClientes();
            foreach (Cliente clienteActual in clientes){
                if (cliente.Telefono.Equals(clienteActual.Telefono)){
                    return clienteActual;
                }//validar el cliente
            }//recorrer todos los clientes
            return null;
        }//obtenerCliente
    }//class
}//namespace