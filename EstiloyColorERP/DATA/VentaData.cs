using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using DOMAIN;

namespace DATA
{
    public class VentaData
    {
        private String stringConeccion;
        public VentaData(string stringConeccion)
        {
            this.stringConeccion = stringConeccion;
        }//constructor

        public Boolean insertarVenta(Venta venta){
            SqlConnection connection = new SqlConnection(this.stringConeccion);
            String sqlStoreProcedure = "sp_insertarVenta";
            SqlCommand cmdInsertar = new SqlCommand(sqlStoreProcedure, connection);
            cmdInsertar.CommandType = System.Data.CommandType.StoredProcedure;

            cmdInsertar.Parameters.Add(new SqlParameter("@fecha", venta.Fecha));
            cmdInsertar.Parameters.Add(new SqlParameter("@hora", venta.Hora));
            cmdInsertar.Parameters.Add(new SqlParameter("@cliente", venta.Cliente));
            cmdInsertar.Parameters.Add(new SqlParameter("@vendedor", venta.Vendedor));
            cmdInsertar.Parameters.Add(new SqlParameter("@tipoServicio", venta.TipoServicio));
            cmdInsertar.Parameters.Add(new SqlParameter("@articuloComprado", venta.ArticuloComprado));
            cmdInsertar.Parameters.Add(new SqlParameter("@subTotal", venta.SubTotal));
            cmdInsertar.Parameters.Add(new SqlParameter("@total", venta.Total));
            cmdInsertar.Parameters.Add(new SqlParameter("@tipoPago", venta.TipoPago));

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

        }//insertar venta

        public Boolean eliminarVenta(Venta venta)
        {
            SqlConnection connection = new SqlConnection(this.stringConeccion);
            String sqlStoreProcedure = "sp_eliminarVenta";
            SqlCommand cmdEliminar = new SqlCommand(sqlStoreProcedure, connection);
            cmdEliminar.CommandType = System.Data.CommandType.StoredProcedure;

            cmdEliminar.Parameters.Add(new SqlParameter("@id", venta.Id));
            cmdEliminar.Connection.Open();
            cmdEliminar.ExecuteNonQuery();
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
        }//eliminar venta

        public LinkedList<Venta> obtenerVentas()
        {
            SqlConnection connection = new SqlConnection(this.stringConeccion);

            String sqlSelect = "sp_obtenerTodosVentas;";

            SqlDataAdapter sqlDataAdapterClient = new SqlDataAdapter();
            sqlDataAdapterClient.SelectCommand = new SqlCommand();
            sqlDataAdapterClient.SelectCommand.CommandText = sqlSelect;
            sqlDataAdapterClient.SelectCommand.Connection = connection;

            DataSet dataSetVentas = new DataSet();
            sqlDataAdapterClient.Fill(dataSetVentas, "tb_Venta");
            sqlDataAdapterClient.SelectCommand.Connection.Close();

            DataRowCollection dataRow = dataSetVentas.Tables["tb_Venta"].Rows;

            LinkedList<Venta> ventas = new LinkedList<Venta>();

            foreach (DataRow currentRow in dataRow)
            {
                Venta ventaActual = new Venta();
                ventaActual.Fecha = currentRow["fecha"].ToString();
                ventaActual.Hora = currentRow["hora"].ToString();
                ventaActual.Cliente = currentRow["cliente"].ToString();
                ventaActual.Vendedor = currentRow["vendedor"].ToString();
                ventaActual.TipoServicio = currentRow["tipoServicio"].ToString();
                //ventaActual.ArticuloComprado = currentRow["articuloComprado"].ToString(); Hay que hacer una consulta de los productos relacionados con la venta
                ventaActual.SubTotal = float.Parse(currentRow["subTotal"].ToString());
                ventaActual.Total = float.Parse(currentRow["total"].ToString());
                ventaActual.TipoPago = currentRow["tipoPago"].ToString();
                ventas.AddLast(ventaActual);
            }//foreach
            return ventas;
        }//obtener todas las ventas

        public Venta obtenerVenta(Venta venta)
        {
            LinkedList<Venta> ventas = obtenerVentas();
            foreach (Venta ventaActual in ventas)
            {
                if (venta.Id.Equals(ventaActual.Id))
                {
                    return ventaActual;
                }
            }
            return null;
        }//obtener una venta
    }//class
}//namespace