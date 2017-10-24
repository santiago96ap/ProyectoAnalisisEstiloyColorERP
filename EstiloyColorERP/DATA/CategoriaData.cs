using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DOMAIN;
using System.Data.SqlClient;

namespace DATA {
    public class CategoriaData {
        private String conectionString;

        public CategoriaData(String stringConection) {
            this.conectionString = stringConection;
        }//constructor

        public Boolean insertarCategoria(Categoria categoria) {
            SqlConnection connection = new SqlConnection(this.conectionString);
            String sqlStoreProcedure = "sp_insertarCategoria";
            SqlCommand cmdInsertar = new SqlCommand(sqlStoreProcedure, connection);
            cmdInsertar.CommandType = System.Data.CommandType.StoredProcedure;

            cmdInsertar.Parameters.Add(new SqlParameter("@nombre", categoria.Nombre));

            cmdInsertar.Connection.Open();
            cmdInsertar.ExecuteNonQuery();
            cmdInsertar.Connection.Close();
            return true;
        }//insertarCategoria

        public Boolean actualizarCategoria(Categoria categoria) {
            SqlConnection connection = new SqlConnection(this.conectionString);
            String sqlStoreProcedure = "sp_actualizarCategoria";
            SqlCommand cmdActualizar = new SqlCommand(sqlStoreProcedure, connection);
            cmdActualizar.CommandType = System.Data.CommandType.StoredProcedure;
            cmdActualizar.Parameters.Add(new SqlParameter("@id", categoria.Id));
            cmdActualizar.Parameters.Add(new SqlParameter("@nombre", categoria.Nombre));


            cmdActualizar.Connection.Open();
            cmdActualizar.ExecuteNonQuery();
            cmdActualizar.Connection.Close();
            return false;
        }//actualizarCategoria

        public LinkedList<Categoria> obtenerCategorias(String fechaI, String fechaF) {
            SqlConnection connection = new SqlConnection(this.conectionString);

            String sqlSelect = "sp_obtenerTodaCategoria;";

            SqlDataAdapter sqlDataAdapterClient = new SqlDataAdapter();
            sqlDataAdapterClient.SelectCommand = new SqlCommand();
            sqlDataAdapterClient.SelectCommand.CommandText = sqlSelect;
            sqlDataAdapterClient.SelectCommand.Connection = connection;

            DataSet dataSetCategoria = new DataSet();
            sqlDataAdapterClient.Fill(dataSetCategoria, "tb_Categoria");
            sqlDataAdapterClient.SelectCommand.Connection.Close();

            DataRowCollection dataRow = dataSetCategoria.Tables["tb_Categoria"].Rows;

            LinkedList<Categoria> categorias = new LinkedList<Categoria>();

            foreach (DataRow currentRow in dataRow)
            {
                Ingreso eActual = new Categoria();
                eActual.Id = int.Parse(currentRow["id"].ToString());
                eActual.Nombre = currentRow["nombre"].ToString();
                categorias.AddLast(eActual);
            }//foreach
            return categorias;
        }//obtenerCategorias

        public Categoria obtenerCategoria(Categoria categoria) {
            return null;
        }//obtenerCategoria

        public Boolean eliminarCategoria(Categoria categoria) {
            SqlConnection connection = new SqlConnection(this.conectionString);
            String sqlStoreProcedure = "sp_eliminarCategoria";
            SqlCommand cmdEliminar = new SqlCommand(sqlStoreProcedure, connection);
            cmdEliminar.CommandType = System.Data.CommandType.StoredProcedure;

            cmdEliminar.Parameters.Add(new SqlParameter("@id", categoia.Id));
            cmdEliminar.Connection.Open();
            cmdEliminar.ExecuteNonQuery();
            cmdEliminar.Connection.Close();
            return true;
        }//eliminarCategoria
    }//clase
}
