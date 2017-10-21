using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DOMAIN;

namespace DATA {
    public class CategoriaData {
        private String conectionString;

        public CategoriaData(String stringConection) {
            this.conectionString = stringConection;
        }//constructor

        public Boolean insertarCategoria(Categoria categoria) {
            SqlCommand cmdCategoria = new SqlCommand();
            cmdCategoria.CommandText = "insertar_categoria";
            cmdCategoria.CommandType = System.Data.CommandType.StoredProcedure;
            cmdCategoria.Parameters.Add(new SqlParameter("@codigo", categoria.Codigo));
            cmdCategoria.Parameters.Add(new SqlParameter("@nombre", categoria.Nombre));

            SqlConnection connection = new SqlConnection(connectionString);
            SqlTransaction transaction = null;
            try
            {
                connection.Open();
                transaction = connection.BeginTransaction();
                cmdCategoria.Connection = connection;
                cmdCategoria.Transaction = transaction;
                cmdCategoria.ExecuteNonQuery();
                categoria.Codigo = Int32.Parse(cmdCategoria.Parameters["@categoria"].Value.ToString());

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
        }//insertarCategoria

        public Boolean actualizarCategoria(Categoria categoria) {
            SqlCommand cmdCategoria = new SqlCommand();
            cmdCategoria.CommandText = "actualizar_categoria";
            cmdCategoria.CommandType = System.Data.CommandType.StoredProcedure;
            cmdCategoria.Parameters.Add(new SqlParameter("@codigo", categoria.Codigo));
            cmdCategoria.Parameters.Add(new SqlParameter("@nombre", categoria.Nombre));


            SqlConnection connection = new SqlConnection(connectionString);
            SqlTransaction transaction = null;
            try
            {
                connection.Open();
                transaction = connection.BeginTransaction();
                cmdCategoria.Connection = connection;
                cmdCategoria.Transaction = transaction;
                cmdCategoria.ExecuteNonQuery();
                categoria.Codigo = Int32.Parse(cmdCategoria.Parameters["@codigo"].Value.ToString());

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
        }//actualizarCategoria

        public LinkedList<Categoria> obtenerCategorias() {
            return null;
        }//obtenerCategorias

        public Categoria obtenerCategoria(Categoria categoria) {
            SqlConnection connection = new SqlConnection(connectionString);
            string sqlProcedureObtenerCategoria = "obtener_categoria";
            SqlCommand comandoObtenerInventario = new SqlCommand(sqlProcedureObtenerCategoria, connection);
            comandoObtenerInventario.CommandType = System.Data.CommandType.StoredProcedure;
            comandoObtenerInventario.Parameters.Add(new SqlParameter("@pemails", inventario.Productos));
            try
            {
                connection.Open();
                transaction = connection.BeginTransaction();
                cmdCategoria.Connection = connection;
                cmdCategoria.Transaction = transaction;
                cmdCategoria.ExecuteNonQuery();
                categoria.Codigo = Int32.Parse(cmdCategoria.Parameters["@codigo"].Value.ToString());

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
            return categoria;
        }//obtenerCategoria

        public Boolean eliminarCategoria(Categoria categoria) {
            SqlCommand cmdCategoria = new SqlCommand();
            cmdCategoria.CommandText = "eliminar_categoria";
            cmdCategoria.CommandType = System.Data.CommandType.StoredProcedure;
            cmdCategoria.Parameters.Add(new SqlParameter("@codigo", categoria.Codigo));
            cmdCategoria.Parameters.Add(new SqlParameter("@nombre", categoria.Nombre));

            SqlConnection connection = new SqlConnection(connectionString);
            SqlTransaction transaction = null;
            try
            {
                connection.Open();
                transaction = connection.BeginTransaction();
                cmdCategoria.Connection = connection;
                cmdCategoria.Transaction = transaction;
                cmdCategoria.ExecuteNonQuery();
                categoria.Codigo = Int32.Parse(cmdCategoria.Parameters["@categoria"].Value.ToString());

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
        }//eliminarCategoria
    }//clase
}
