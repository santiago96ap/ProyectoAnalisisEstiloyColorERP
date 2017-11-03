using DOMAIN;
using System;
using System.Collections.Generic;
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
            String sqlStoreProcedure = " sp_insertarProducto";
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
            return false;
        }//eliminarProducto

        public LinkedList<Producto> obtenerTodosProductos()
        {
            return null;
        }//obtenerTodosProductos

        public LinkedList<Producto> obtenerProductoPorCategoria(Categoria categoria)
        {
            return null;
        }//obtenerProductoPorCategoria

        public LinkedList<Producto> obtenerProductoPorID(Producto producto)
        {
            return null;
        }// obtenerProductoPorID

    }//class
}//namespace