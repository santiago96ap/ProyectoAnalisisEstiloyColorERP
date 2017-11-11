using DOMAIN;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DATA
{
    public class ProductoData
    {
        private String conectionString;

        public ProductoData(String conectionString)
        {
            this.conectionString = conectionString;
        }//constructor


        public Boolean insertarProducto(Producto producto)
        {
            SqlConnection connection = new SqlConnection(this.conectionString);
            String sqlStoreProcedure = "sp_insertarProducto";
            SqlCommand cmdInsertar = new SqlCommand(sqlStoreProcedure, connection);
            cmdInsertar.CommandType = System.Data.CommandType.StoredProcedure;
            cmdInsertar.Parameters.Add(new SqlParameter("@id_Proct", producto.IdProct));
            cmdInsertar.Parameters.Add(new SqlParameter("@nombre", producto.Nombre));
            cmdInsertar.Parameters.Add(new SqlParameter("@descripcion", producto.Descripcion));
            cmdInsertar.Parameters.Add(new SqlParameter("@costo", producto.Costo));
            cmdInsertar.Parameters.Add(new SqlParameter("@precio", producto.Precio));
            cmdInsertar.Parameters.Add(new SqlParameter("@cantidad", producto.Cantidad));
            cmdInsertar.Parameters.Add(new SqlParameter("@id_Prov", producto.IdProveedor));
            cmdInsertar.Parameters.Add(new SqlParameter("@id_Cat", producto.IdCategoria));

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
        }//insertarProducto

        public Boolean actualizarProducto(Producto producto)
        {
            return false;
        }//actualizarProducto

        public Boolean eliminarProducto(Producto producto)
        {
            SqlConnection connection = new SqlConnection(this.conectionString);
            String sqlStoreProcedure = "sp_eliminarProducto";
            SqlCommand cmdEliminar = new SqlCommand(sqlStoreProcedure, connection);
            cmdEliminar.CommandType = System.Data.CommandType.StoredProcedure;

            cmdEliminar.Parameters.Add(new SqlParameter("@id_Proct", producto.IdProct));
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
        }//eliminarProducto

        public LinkedList<Producto> obtenerTodosProductos()
        {
            SqlConnection connection = new SqlConnection(this.conectionString);

            String sqlSelect = "sp_obtenerTodoProducto;";

            SqlDataAdapter sqlDataAdapterClient = new SqlDataAdapter();
            sqlDataAdapterClient.SelectCommand = new SqlCommand();
            sqlDataAdapterClient.SelectCommand.CommandText = sqlSelect;
            sqlDataAdapterClient.SelectCommand.Connection = connection;

            DataSet dataSetCategoria = new DataSet();
            sqlDataAdapterClient.Fill(dataSetCategoria, "tb_Producto");
            sqlDataAdapterClient.SelectCommand.Connection.Close();

            DataRowCollection dataRow = dataSetCategoria.Tables["tb_Producto"].Rows;

            LinkedList<Producto> productos = new LinkedList<Producto>();

            foreach (DataRow currentRow in dataRow)
            {
                Producto pa = new Producto();
                pa.IdProct = int.Parse(currentRow["id_Proct"].ToString());
                pa.Nombre = currentRow["nombre"].ToString();
                pa.Descripcion = currentRow["descripcion"].ToString();
                pa.Costo = float. Parse(currentRow["costo"].ToString());
                pa.Precio = float.Parse(currentRow["precio"].ToString());
                pa.Cantidad = int.Parse(currentRow["precio"].ToString());
                pa.IdProveedor = currentRow["id_Prov"].ToString();
                pa.IdCategoria = int.Parse(currentRow["id_Cat"].ToString());

                productos.AddLast(pa);
            }//foreach
            return productos;
        }//obtenerTodosProductos

        public LinkedList<Producto> obtenerProductoPorCategoria(Categoria categoria)
        {
            return null;
        }//obtenerProductoPorCategoria

        public Producto obtenerProductoPorID(int id)
        {
            SqlConnection connection = new SqlConnection(this.conectionString);

            String sqlSelect = "sp_obtenerProducto";

            SqlDataAdapter sqladapterProducto = new SqlDataAdapter();

            sqladapterProducto.SelectCommand = new SqlCommand(sqlSelect, connection);
            sqladapterProducto.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqladapterProducto.SelectCommand.Parameters.Add(new SqlParameter("@ID",id));

            DataSet dataIngresos = new DataSet();
            sqladapterProducto.Fill(dataIngresos, "tb_Producto");
            sqladapterProducto.SelectCommand.Connection.Close();

            DataRowCollection dataRow = dataIngresos.Tables["tb_Producto"].Rows;
            Producto pActual = new Producto();
            foreach (DataRow currentRow in dataRow)
            {
                pActual.IdProct = int.Parse(currentRow["id_Proct"].ToString());
                pActual.Nombre = currentRow["nombre"].ToString();
                pActual.Descripcion = currentRow["descripcion"].ToString();
                pActual.Costo = float.Parse(currentRow["costo"].ToString());
                pActual.Precio = float.Parse(currentRow["precio"].ToString());
                pActual.Cantidad = int.Parse(currentRow["precio"].ToString());
                pActual.IdProveedor = currentRow["id_Prov"].ToString();
                pActual.IdCategoria = int.Parse(currentRow["id_Cat"].ToString());

            }
            return pActual;
        }// obtenerProductoPorID

    }//class
}//namespace