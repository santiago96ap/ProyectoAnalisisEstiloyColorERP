using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using DOMAIN;

namespace DATA
{
    public class ProveedorData
    {
        private String stringConnection;

        public ProveedorData(String stringConection)
        {
            this.stringConnection = stringConection;
        }//constructor

        public Boolean insertarProveedor(Proveedor proveedor)
        {
            SqlConnection connection = new SqlConnection(this.stringConnection);
            String sqlStoreProcedure = "sp_insertarProveedor";
            SqlCommand cmdInsertar = new SqlCommand(sqlStoreProcedure, connection);
            cmdInsertar.CommandType = System.Data.CommandType.StoredProcedure;

            cmdInsertar.Parameters.Add(new SqlParameter("@email", proveedor.Email));
            cmdInsertar.Parameters.Add(new SqlParameter("@nombre", proveedor.Nombre));
            cmdInsertar.Parameters.Add(new SqlParameter("@telefono", proveedor.Telefono));
            cmdInsertar.Parameters.Add(new SqlParameter("@direccion", proveedor.Direccion));

            cmdInsertar.Connection.Open();
            cmdInsertar.ExecuteNonQuery();
            cmdInsertar.Connection.Close();
            return true;
        }//insertarProveedor

        public Boolean actualizarProveedor(Proveedor proveedor)
        {
            SqlConnection connection = new SqlConnection(this.stringConnection);
            String sqlStoreProcedure = "sp_actualizarProveedor";
            SqlCommand cmdActualizar = new SqlCommand(sqlStoreProcedure, connection);
            cmdActualizar.CommandType = System.Data.CommandType.StoredProcedure;
            cmdActualizar.Parameters.Add(new SqlParameter("@email", proveedor.Email));
            cmdActualizar.Parameters.Add(new SqlParameter("@nombre", proveedor.Nombre));
            cmdActualizar.Parameters.Add(new SqlParameter("@telefono", proveedor.Telefono));
            cmdActualizar.Parameters.Add(new SqlParameter("@direccion", proveedor.Direccion));

            cmdActualizar.Connection.Open();
            cmdActualizar.ExecuteNonQuery();
            cmdActualizar.Connection.Close();
            return false;
        }//actualizarProveedor

        public LinkedList<Proveedor> obtenerProveedores(String fechaI, String fechaF)
        {
            SqlConnection connection = new SqlConnection(this.stringConnection);

            String sqlSelect = "sp_obtenerTodoProveedor;";

            SqlDataAdapter sqlDataAdapterClient = new SqlDataAdapter();
            sqlDataAdapterClient.SelectCommand = new SqlCommand();
            sqlDataAdapterClient.SelectCommand.CommandText = sqlSelect;
            sqlDataAdapterClient.SelectCommand.Connection = connection;

            DataSet dataSetProveedores = new DataSet();
            sqlDataAdapterClient.Fill(dataSetProveedores, "tb_Proveedor");
            sqlDataAdapterClient.SelectCommand.Connection.Close();

            DataRowCollection dataRow = dataSetProveedores.Tables["tb_Proveedor"].Rows;

            LinkedList<Proveedor> proveedor = new LinkedList<Proveedor>();

            foreach (DataRow currentRow in dataRow)
            {
                Proveedor provActual = new Proveedor();
                provActual.Email = currentRow["email"].ToString();
                provActual.Nombre = currentRow["nombre"].ToString();
                provActual.Telefono = currentRow["telefono"].ToString();
                provActual.Direccion = currentRow["direccion"].ToString();
                proveedor.AddLast(provActual);
            }//foreach
            return proveedor;
        }//obtenerProveedores

        public Boolean eliminarProveedor(Proveedor proveedor)
        {
            SqlConnection connection = new SqlConnection(this.stringConnection);
            String sqlStoreProcedure = "sp_eliminarProveedor";
            SqlCommand cmdEliminar = new SqlCommand(sqlStoreProcedure, connection);
            cmdEliminar.CommandType = System.Data.CommandType.StoredProcedure;

            cmdEliminar.Parameters.Add(new SqlParameter("@email", proveedor.Email));
            cmdEliminar.Connection.Open();
            cmdEliminar.ExecuteNonQuery();
            cmdEliminar.Connection.Close();
            return true;
        }//eliminarProveedor
    }//clase
}