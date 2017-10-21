using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DOMAIN;

namespace DATA {
    public class InventarioData {

        private String stringConeccion;

        public InventarioData(string stringConeccion) {
            this.stringConeccion = stringConeccion;
        }//constructor
    
        public Boolean actualizarInventario(Inventario inventario) {
            SqlCommand cmdInventario = new SqlCommand();
            cmdInventario.CommandText = "actualizar_inventario";
            cmdInventario.CommandType = System.Data.CommandType.StoredProcedure;
            cmdInventario.Parameters.Add(new SqlParameter("@productos", inventario.Productos));
            cmdInventario.Parameters.Add(new SqlParameter("@cantidad", inventario.Cantidad));

            SqlConnection connection = new SqlConnection(connectionString);
            SqlTransaction transaction = null;
            try
            {
                connection.Open();
                transaction = connection.BeginTransaction();
                cmdInventario.Connection = connection;
                cmdInventario.Transaction = transaction;
                cmdInventario.ExecuteNonQuery();
                inventario.Productos = Int32.Parse(cmdInventario.Parameters["@productos"].Value.ToString());

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
        }//actualizarInventario

        public Boolean eliminarInventario(Inventario inventario) {
            SqlCommand cmdInventario = new SqlCommand();
            cmdInventario.CommandText = "eliminar_inventario";
            cmdInventario.CommandType = System.Data.CommandType.StoredProcedure;
            cmdInventario.Parameters.Add(new SqlParameter("@productos", inventario.Productos));
            cmdInventario.Parameters.Add(new SqlParameter("@cantidad", inventario.Cantidad));

            SqlConnection connection = new SqlConnection(connectionString);
            SqlTransaction transaction = null;
            try
            {
                connection.Open();
                transaction = connection.BeginTransaction();
                cmdInventario.Connection = connection;
                cmdInventario.Transaction = transaction;
                cmdInventario.ExecuteNonQuery();
                inventario.Productos = Int32.Parse(cmdInventario.Parameters["@productos"].Value.ToString());

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
        }//eliminarInventario

        public Inventario obtenerInventario(Inventario inventario) {
            SqlConnection connection = new SqlConnection(connectionString);
            string sqlProcedureObtenerInventario = "obtener_inventario";
            SqlCommand comandoObtenerInventario = new SqlCommand(sqlProcedureObtenerInventario, connection);
            comandoObtenerInventario.CommandType = System.Data.CommandType.StoredProcedure;
            comandoObtenerInventario.Parameters.Add(new SqlParameter("@productos", inventario.Productos));
            try
            {
                connection.Open();
                transaction = connection.BeginTransaction();
                cmdInventario.Connection = connection;
                cmdInventario.Transaction = transaction;
                cmdInventario.ExecuteNonQuery();
                inventario.Productos = Int32.Parse(cmdInventario.Parameters["@productos"].Value.ToString());

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

            return inventario;
        }//obtenerInventrio
    }
}