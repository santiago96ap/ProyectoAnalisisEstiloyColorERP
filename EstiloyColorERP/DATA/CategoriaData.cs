using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using DOMAIN;

namespace DATA {
    public class CategoriaData {
        private String conectionString;//Este será el String de conexión

        public CategoriaData(String stringConection) {
            this.conectionString = stringConection;
        }//constructor


        /// <summary>
        /// Este metodo insertará una Categoría nueva en la BD
        /// </summary>
        /// <param name="categoria"></param>
        /// <returns>Boolean</returns>
        public Boolean insertarCategoria(Categoria categoria) {
            SqlConnection connection = new SqlConnection(this.conectionString);
            String sqlStoreProcedure = "sp_insertarCategoria";
            SqlCommand cmdInsertar = new SqlCommand(sqlStoreProcedure, connection);
            cmdInsertar.CommandType = System.Data.CommandType.StoredProcedure;
            cmdInsertar.Parameters.Add(new SqlParameter("@nombre", categoria.Nombre));

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
        }//insertarCategoria


        /// <summary>
        /// Este método actualizrá una categoría ya existente
        /// </summary>
        /// <param name="categoria"></param>
        /// <returns>Boolean</returns>
        public Boolean actualizarCategoria(Categoria categoria) {
            SqlConnection connection = new SqlConnection(this.conectionString);
            String sqlStoreProcedure = "sp_actualizarCategoria";
            SqlCommand cmdActualizar = new SqlCommand(sqlStoreProcedure, connection);
            cmdActualizar.CommandType = System.Data.CommandType.StoredProcedure;
            cmdActualizar.Parameters.Add(new SqlParameter("@id", categoria.Codigo));
            cmdActualizar.Parameters.Add(new SqlParameter("@nombre", categoria.Nombre));

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
        }//actualizarCategoria

        /// <summary>
        /// Este método obtendrá todas las categorías existentes
        /// </summary>
        /// <returns></returns>
        public LinkedList<Categoria> obtenerCategorias() {
            SqlConnection connection = new SqlConnection(this.conectionString);

            String sqlSelect = "sp_obtenerTodaCategoria;";

            SqlDataAdapter sqlDataAdapterCategoria = new SqlDataAdapter();
            sqlDataAdapterCategoria.SelectCommand = new SqlCommand();
            sqlDataAdapterCategoria.SelectCommand.CommandText = sqlSelect;
            sqlDataAdapterCategoria.SelectCommand.Connection = connection;

            DataSet dataSetCategoria = new DataSet();
            sqlDataAdapterCategoria.Fill(dataSetCategoria, "tb_Categoria");
            sqlDataAdapterCategoria.SelectCommand.Connection.Close();

            DataRowCollection dataRow = dataSetCategoria.Tables["tb_Categoria"].Rows;

            LinkedList<Categoria> categorias = new LinkedList<Categoria>();

            foreach (DataRow currentRow in dataRow)
            {
                Categoria categoriaActual = new Categoria();
                categoriaActual.Codigo = int.Parse(currentRow["id"].ToString());
                categoriaActual.Nombre = currentRow["nombre"].ToString();
                categorias.AddLast(categoriaActual);
            }//foreach
            return categorias;
        }//obtenerCategorias

        /// <summary>
        /// Este metodo eliminará una categoría existente de la BD
        /// </summary>
        /// <param name="categoria"></param>
        /// <returns>Booleam</returns>
        public Boolean eliminarCategoria(Categoria categoria) {
            SqlConnection connection = new SqlConnection(this.conectionString);
            String sqlStoreProcedure = "sp_eliminarCategoria";
            SqlCommand cmdEliminar = new SqlCommand(sqlStoreProcedure, connection);
            cmdEliminar.CommandType = System.Data.CommandType.StoredProcedure;

            cmdEliminar.Parameters.Add(new SqlParameter("@id", categoria.Codigo));
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
        }//eliminarCategoria
    }//class
}//namespace
