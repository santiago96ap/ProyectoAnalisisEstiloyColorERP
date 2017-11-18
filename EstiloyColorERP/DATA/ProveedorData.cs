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
        private String stringConnection;//Este será el String de conexión a la BD

        public ProveedorData(String stringConection)
        {
            this.stringConnection = stringConection;
        }//constructor

        /// <summary>
        /// Este método insertará un proveedor en la BD
        /// </summary>
        /// <param name="proveedor"></param>
        /// <returns></returns>
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
            cmdInsertar.Parameters.Add(new SqlParameter("@web", proveedor.Web));

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

        }//insertarProveedor


        /// <summary>
        /// Este método se actualizará los proveedores
        /// </summary>
        /// <param name="proveedor"></param>
        /// <returns>Boolean</returns>
        public Boolean actualizarProveedor(Proveedor proveedor)
        {
            SqlConnection connection = new SqlConnection(this.stringConnection);
            String sqlStoreProcedure = "sp_actualizarProveedor";
            SqlCommand cmdActualizar = new SqlCommand(sqlStoreProcedure, connection);
            cmdActualizar.CommandType = System.Data.CommandType.StoredProcedure;
            cmdActualizar.Parameters.Add(new SqlParameter("@email", proveedor.Email));
            cmdActualizar.Parameters.Add(new SqlParameter("@emailN", proveedor.Email));
            cmdActualizar.Parameters.Add(new SqlParameter("@nombre", proveedor.Nombre));
            cmdActualizar.Parameters.Add(new SqlParameter("@telefono", proveedor.Telefono));
            cmdActualizar.Parameters.Add(new SqlParameter("@direccion", proveedor.Direccion));

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

        }//actualizarProveedor

        /// <summary>
        /// Este método obtendrá los proveedores
        /// </summary>
        /// <returns></returns>
        public LinkedList<Proveedor> obtenerProveedores()
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
                provActual.Web = currentRow["web"].ToString();
                proveedor.AddLast(provActual);
            }//foreach
            return proveedor;
        }//obtenerProveedores


        /// <summary>
        /// Obtendrá solo un unico proveedor
        /// </summary>
        /// <param name="proveedor"></param>
        /// <returns> Proveedor</returns>
        public Proveedor obtenerProveedor(Proveedor proveedor)
        {
            LinkedList<Proveedor> proveedores = obtenerProveedores();
            foreach (Proveedor proveedorActual in proveedores)
            {
                if (proveedor.Telefono.Equals(proveedorActual.Telefono))
                {
                    return proveedorActual;
                }
            }
            return null;
        }//obtenerCliente

        /// <summary>
        /// Este metdo eliminará el proveedor
        /// </summary>
        /// <param name="proveedor"></param>
        /// <returns></returns>
        public Boolean eliminarProveedor(Proveedor proveedor)
        {
            SqlConnection connection = new SqlConnection(this.stringConnection);
            String sqlStoreProcedure = "sp_eliminarProveedor";
            SqlCommand cmdEliminar = new SqlCommand(sqlStoreProcedure, connection);
            cmdEliminar.CommandType = System.Data.CommandType.StoredProcedure;

            cmdEliminar.Parameters.Add(new SqlParameter("@email", proveedor.Email));
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
            }//if-else
        }//eliminarProveedor
    }//class
}//namespce