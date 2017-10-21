using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DOMAIN;

namespace DATA {
    public class ProveedorData {
        private String stringConnection;

        public ProveedorData(String stringConection) {
            this.stringConnection = stringConection;
        }//constructor

        public Boolean insertarProveedor(Proveedor proveedor) {
            SqlCommand cmdProveedor = new SqlCommand();
            cmdProveedor.CommandText = "insertar_proveedor";
            cmdProveedor.CommandType = System.Data.CommandType.StoredProcedure;
            cmdProveedor.Parameters.Add(new SqlParameter("@nombre", proveedor.Nombre));
            cmdProveedor.Parameters.Add(new SqlParameter("@telefono", proveedor.Telefono));
            cmdProveedor.Parameters.Add(new SqlParameter("@direccion", proveedor.Direccion));
            cmdProveedor.Parameters.Add(new SqlParameter("@email", proveedor.Email));

            SqlConnection connection = new SqlConnection(connectionString);
            SqlTransaction transaction = null;
            try
            {
                connection.Open();
                transaction = connection.BeginTransaction();
                cmdProveedor.Connection = connection;
                cmdProveedor.Transaction = transaction;
                cmdProveedor.ExecuteNonQuery();
                proveedor.email = Int32.Parse(cmdProveedor.Parameters["@proveedor"].Value.ToString());

                transaction.Commit();
            }
            catch (SqlException ex)
            {
                if (transaction != null)
                    transaction.Rollback();
                throw ex;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }//finally

            return true;
        }//insertarProveedor

        public Boolean actualizarProveedor(Proveedor proveedor) {
            SqlCommand cmdProveedor = new SqlCommand();
            cmdProveedor.CommandText = "actualizar_proveedor";
            cmdProveedor.CommandType = System.Data.CommandType.StoredProcedure;
            cmdProveedor.Parameters.Add(new SqlParameter("@nombre", proveedor.Nombre));
            cmdProveedor.Parameters.Add(new SqlParameter("@telefono", proveedor.Telefono));
            cmdProveedor.Parameters.Add(new SqlParameter("@direccion", proveedor.Direccion));
            cmdProveedor.Parameters.Add(new SqlParameter("@email", proveedor.Email));

            SqlConnection connection = new SqlConnection(connectionString);
            SqlTransaction transaction = null;
            try
            {
                connection.Open();
                transaction = connection.BeginTransaction();
                cmdProveedor.Connection = connection;
                cmdProveedor.Transaction = transaction;
                cmdProveedor.ExecuteNonQuery();
                proveedor.Email = Int32.Parse(cmdProveedor.Parameters["@email"].Value.ToString());

                transaction.Commit();
            }
            catch (SqlException ex)
            {
                if (transaction != null)
                    transaction.Rollback();
                throw ex;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }//finally

            return true;
        }//actualizarProveedor

        public LinkedList<Proveedor> obtenerProveedores() {
            return null;
        }//obtenerProveedores

        public Proveedor obtenerProveedor(Proveedor proveedor) {
            SqlConnection connection = new SqlConnection(connectionString);
            string sqlProcedureObtenerProveedor = "obtener_proveedor";
            SqlCommand comandoObtenerProveedor = new SqlCommand(sqlProcedureObtenerProveedor, connection);
            comandoObtenerProveedor.CommandType = System.Data.CommandType.StoredProcedure;
            comandoObtenerProveedor.Parameters.Add(new SqlParameter("@email", proveedor.Email));
            try
            {
                connection.Open();
                transaction = connection.BeginTransaction();
                cmdProveedor.Connection = connection;
                cmdProveedor.Transaction = transaction;
                cmdProveedor.ExecuteNonQuery();
                proveedor.email = Int32.Parse(cmdProveedor.Parameters["@email"].Value.ToString());

                transaction.Commit();
            }
            catch (SqlException ex)
            {
                if (transaction != null)
                    transaction.Rollback();
                throw ex;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }//finally

            return proveedor;
        }//obtenerProveedor

        public Boolean eliminarProveedor(Proveedor proveedor) {
            retuSqlCommand cmdProveedor = new SqlCommand();
            cmdProveedor.CommandText = "eliminar_proveedor";
            cmdProveedor.CommandType = System.Data.CommandType.StoredProcedure;
            cmdProveedor.Parameters.Add(new SqlParameter("@nombre", proveedor.Nombre));
            cmdProveedor.Parameters.Add(new SqlParameter("@telefono", proveedor.Telefono));
            cmdProveedor.Parameters.Add(new SqlParameter("@direccion", proveedor.Direccion));
            cmdProveedor.Parameters.Add(new SqlParameter("@email", proveedor.Email));

            SqlConnection connection = new SqlConnection(connectionString);
            SqlTransaction transaction = null;
            try
            {
                connection.Open();
                transaction = connection.BeginTransaction();
                cmdProveedor.Connection = connection;
                cmdProveedor.Transaction = transaction;
                cmdProveedor.ExecuteNonQuery();
                proveedor.Email = Int32.Parse(cmdProveedor.Parameters["@email"].Value.ToString());

                transaction.Commit();
            }
            catch (SqlException ex)
            {
                if (transaction != null)
                    transaction.Rollback();
                throw ex;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }//finally

            return true;
        }//eliminarProveedor
    }//clase
}