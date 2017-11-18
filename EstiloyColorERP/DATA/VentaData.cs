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
        private String stringConeccion;//Este será el String de conexion de la Bd
        public VentaData(string stringConeccion)
        {
            this.stringConeccion = stringConeccion;
        }//constructor

        /// <summary>
        /// Este método insertrá una venta a la BD
        /// </summary>
        /// <param name="venta"></param>
        /// <returns></returns>
        public Boolean insertarVenta(Venta venta){
            SqlConnection connection = new SqlConnection(this.stringConeccion);
            String sqlStoreProcedure = "sp_insertarVenta";
            SqlCommand cmdInsertar = new SqlCommand(sqlStoreProcedure, connection);
            cmdInsertar.CommandType = System.Data.CommandType.StoredProcedure;

            cmdInsertar.Parameters.Add(new SqlParameter("@fecha", venta.Fecha));
            cmdInsertar.Parameters.Add(new SqlParameter("@hora", venta.Hora));
            cmdInsertar.Parameters.Add(new SqlParameter("@id_cliente", venta.Cliente));
            cmdInsertar.Parameters.Add(new SqlParameter("@usuario", venta.Vendedor));
            cmdInsertar.Parameters.Add(new SqlParameter("@tipo_Servicio", venta.TipoServicio));
            cmdInsertar.Parameters.Add(new SqlParameter("@subTotal", venta.SubTotal));
            cmdInsertar.Parameters.Add(new SqlParameter("@total", venta.Total));
            cmdInsertar.Parameters.Add(new SqlParameter("@tipo_Pago", venta.TipoPago));

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

        }//insertar venta

        /// <summary>
        /// Este método insertrá una Venta con sus productos correspondientes en la BD
        /// </summary>
        /// <param name="vp"></param>
        /// <returns>Boolean</returns>
        public Boolean insertarVentaProducto(VentaProducto vp)
        {
            SqlConnection connection = new SqlConnection(this.stringConeccion);
            String sqlStoreProcedure = "sp_InsertarVentaProductos";
            SqlCommand cmdInsertar = new SqlCommand(sqlStoreProcedure, connection);
            cmdInsertar.CommandType = System.Data.CommandType.StoredProcedure;
            //@id_producto int, @id_categoria int, @total float, @fecha date, @hora time ,@id_cliente varchar(15)
            cmdInsertar.Parameters.Add(new SqlParameter("@id_producto", vp.IdProduco));
            cmdInsertar.Parameters.Add(new SqlParameter("@id_categoria", vp.IdCategoria));
            cmdInsertar.Parameters.Add(new SqlParameter("@total", vp.Total));
            cmdInsertar.Parameters.Add(new SqlParameter("@fecha", vp.Fecha));
            cmdInsertar.Parameters.Add(new SqlParameter("@hora", vp.Hora));
            cmdInsertar.Parameters.Add(new SqlParameter("@id_cliente", vp.IdCliente));

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

        }//insertar venta

        /// <summary>
        /// Este eliminará una venta del sustema
        /// </summary>
        /// <param name="venta"></param>
        /// <returns>Boolean</returns>
        public Boolean eliminarVenta(Venta venta)
        {
            SqlConnection connection = new SqlConnection(this.stringConeccion);
            String sqlStoreProcedure = "sp_eliminarVenta";
            SqlCommand cmdEliminar = new SqlCommand(sqlStoreProcedure, connection);
            cmdEliminar.CommandType = System.Data.CommandType.StoredProcedure;

            cmdEliminar.Parameters.Add(new SqlParameter("@id_venta", venta.Id));
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
        }//eliminar venta


        /// <summary>
        /// Este método obtendrá todas las ventas del sistema
        /// </summary>
        /// <returns>LinkedList<Venta></returns>
        public LinkedList<Venta> obtenerVentas()
        {
            SqlConnection connection = new SqlConnection(this.stringConeccion);

            String sqlSelect = "sp_obtenerTodoVenta;";

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
                ventaActual.Id = int.Parse(currentRow["id_venta"].ToString());
                ventaActual.Fecha = currentRow["fecha"].ToString().Split(' ')[0];
                ventaActual.Hora = currentRow["hora"].ToString();
                ventaActual.Cliente = currentRow["id_cliente"].ToString();
                ventaActual.TipoServicio = currentRow["tipo_Servicio"].ToString();
                ventaActual.TipoPago = currentRow["tipo_Pago"].ToString();
                ventaActual.Vendedor = currentRow["usuario"].ToString();
                ventaActual.SubTotal = float.Parse(currentRow["subtotal"].ToString());
                ventaActual.Total = float.Parse(currentRow["total"].ToString());
                ventas.AddLast(ventaActual);
            }//foreach
            return ventas;
        }//obtener todas las ventas

        /// <summary>
        /// Obtendrá una unica venta que será por el id
        /// </summary>
        /// <param name="venta"></param>
        /// <returns></returns>
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


        /// <summary>
        /// obtendrá las ventas por medio de fechas para que se puedan elimnar
        /// </summary>
        /// <param name="fechaI"></param>
        /// <param name="fechaF"></param>
        /// <returns></returns>
        public LinkedList<Venta> obtenerVentasEliminar(String fechaI, String fechaF)
        {
            SqlConnection connection = new SqlConnection(this.stringConeccion);

            String sqlSelect = "sp_obtenerVentas";

            SqlDataAdapter sqladapterVentas = new SqlDataAdapter();

            sqladapterVentas.SelectCommand = new SqlCommand(sqlSelect, connection);
            sqladapterVentas.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqladapterVentas.SelectCommand.Parameters.Add(new SqlParameter("@FechaI", fechaI));
            sqladapterVentas.SelectCommand.Parameters.Add(new SqlParameter("@FechaF", fechaF));

            DataSet dataVentas = new DataSet();
            sqladapterVentas.Fill(dataVentas, "tb_Ventas");
            sqladapterVentas.SelectCommand.Connection.Close();

            DataRowCollection dataRow = dataVentas.Tables["tb_Ventas"].Rows;


            LinkedList<Venta> ventas = new LinkedList<Venta>();

            foreach (DataRow currentRow in dataRow)
            {
                Venta ventaActual = new Venta();
                ventaActual.Id = int.Parse(currentRow["id_venta"].ToString());
                ventaActual.Fecha = currentRow["fecha"].ToString().Split(' ')[0];
                ventaActual.Hora = currentRow["hora"].ToString();
                ventaActual.Cliente = currentRow["id_cliente"].ToString();
                ventaActual.TipoServicio = currentRow["tipo_Servicio"].ToString();
                ventaActual.TipoPago = currentRow["tipo_Pago"].ToString();
                ventaActual.Vendedor = currentRow["usuario"].ToString();
                ventaActual.SubTotal = float.Parse(currentRow["subtotal"].ToString());
                ventaActual.Total = float.Parse(currentRow["total"].ToString());
                ventas.AddLast(ventaActual);
            }//foreach

            return ventas;
        }//obtener ventas eliminar
    }//class
}//namespace