﻿using System;
using System.Collections.Generic;
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

            cmdInsertar.Parameters.Add(new SqlParameter("@fecha", venta.fecha));
            cmdInsertar.Parameters.Add(new SqlParameter("@hora", venta.hora));
            cmdInsertar.Parameters.Add(new SqlParameter("@cliente", venta.cliente));
            cmdInsertar.Parameters.Add(new SqlParameter("@vendedor", venta.vendedor));
            cmdInsertar.Parameters.Add(new SqlParameter("@tipoServicio", venta.tipoServicio));
            cmdInsertar.Parameters.Add(new SqlParameter("@articuloComprado", venta.articuloComprado));
            cmdInsertar.Parameters.Add(new SqlParameter("@subTotal", venta.subTotal));
            cmdInsertar.Parameters.Add(new SqlParameter("@total", venta.total));
            cmdInsertar.Parameters.Add(new SqlParameter("@tipoPago", venta.tipoPago));

            cmdInsertar.Connection.Open();
            cmdInsertar.ExecuteNonQuery();
            cmdInsertar.Connection.Close();
            return true;
        }//insertar venta

        public Boolean eliminarVenta(Venta venta)
        {
            return false;
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

            DataRowCollection dataRow = dataSetVentas.Tables["tb_Cliente"].Rows;

            LinkedList<Venta> ventas = new LinkedList<Venta>();

            foreach (DataRow currentRow in dataRow)
            {
                Venta ventaActual = new Venta();
                ventaActual.Fecha = currentRow["fecha"].ToString();
                ventaActual.Hora = currentRow["hora"].ToString();
                ventaActual.Cliente = currentRow["cliente"].ToString();
                ventaActual.Vendedor = currentRow["vendedor"].ToString();
                ventaActual.TipoServicio = currentRow["tipoServicio"].ToString();
                ventaActual.ArticuloComprado = currentRow["articuloComprado"].ToString();
                ventaActual.SubTotal = currentRow["subTotal"].ToString();
                ventaActual.Total = currentRow["total"].ToString();
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
                if (venta.Hora.Equals(ventaActual.Hora))
                {
                    return ventaActual;
                }
            }
            return null;
        }//obtener una venta
    }//class
}//namespace