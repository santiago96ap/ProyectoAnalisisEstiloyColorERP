﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using DOMAIN;

namespace DATA
{
    public class ApartadoData
    {

        private String stringConeccion;

        public ApartadoData(string stringConeccion)
        {
            this.stringConeccion = stringConeccion;
        }//constructor

        public Boolean insertarApartado(Apartado apartado)
        {
            SqlConnection connection = new SqlConnection(this.stringConeccion);
            String sqlStoreProcedure = "sp_insertarApartado";
            SqlCommand cmdInsertar = new SqlCommand(sqlStoreProcedure, connection);
            cmdInsertar.CommandType = System.Data.CommandType.StoredProcedure;
            
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
        }//insertarApartado

        public Boolean insertarApartadoProducto(VentaProducto vp)
        {
            SqlConnection connection = new SqlConnection(this.stringConeccion);
            String sqlStoreProcedure = "sp_insertarApartadoProducto";
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

        public Boolean eliminarApartado(Apartado apartado)
        {
            SqlConnection connection = new SqlConnection(this.stringConeccion);
            String sqlStoreProcedure = "sp_eliminarApartado";
            SqlCommand cmdEliminar = new SqlCommand(sqlStoreProcedure, connection);
            cmdEliminar.CommandType = System.Data.CommandType.StoredProcedure;

            cmdEliminar.Parameters.Add(new SqlParameter("@id", apartado.Id));
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
        }//eliminarApartado

        public LinkedList<Apartado> obtenerApartados()
        {
            SqlConnection connection = new SqlConnection(this.stringConeccion);

            String sqlSelect = "sp_obtenerTodoApartado;";

            SqlDataAdapter sqlDataAdapterApartado = new SqlDataAdapter();
            sqlDataAdapterApartado.SelectCommand = new SqlCommand();
            sqlDataAdapterApartado.SelectCommand.CommandText = sqlSelect;
            sqlDataAdapterApartado.SelectCommand.Connection = connection;

            DataSet dataSetApartados = new DataSet();
            sqlDataAdapterApartado.Fill(dataSetApartados, "tb_Apartado");
            sqlDataAdapterApartado.SelectCommand.Connection.Close();

            DataRowCollection dataRow = dataSetApartados.Tables["tb_Apartado"].Rows;

            LinkedList<Apartado> apartados = new LinkedList<Apartado>();

            foreach (DataRow currentRow in dataRow)
            {
                Apartado apartadoActual = new Apartado();
                apartadoActual.Id = int.Parse(currentRow["id"].ToString());
                apartadoActual.IdCliente = currentRow["telf_cliente"].ToString();
                apartadoActual.Monto = float.Parse(currentRow["monto"].ToString());
                apartadoActual.Abono = float.Parse(currentRow["abono"].ToString());
                apartadoActual.FechaInicio = currentRow["fecha_inicio"].ToString().Split(' ')[0];
                apartadoActual.FechaFinal = currentRow["fecha_fin"].ToString().Split(' ')[0];
                apartadoActual.Estado = currentRow["estado"].ToString();
                apartadoActual.NumFactura = int.Parse(currentRow["numFactCliente"].ToString());
                apartados.AddLast(apartadoActual);
            }//recorrer todos los clientes que vienen de la DB
            return apartados;
        }//obtenerApartados

        public Apartado obtenerApartado(Apartado apartado)
        {
            return null;
        }//obtenerApartado

        public Boolean actualizarApartado(Apartado apartado)
        {
            return false;
        }//actualizarApartado

    }//class
}//namespace