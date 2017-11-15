using DOMAIN;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;

namespace DATA
{
    public class OfertaData
    {
        private String conectionString;
        public OfertaData(string conectionString)
        {
            this.conectionString = conectionString;
        }//constructor

        public Boolean insertarOfertaProducto(Oferta oferta) {
            SqlConnection connection = new SqlConnection(this.conectionString);
            String sqlStoreProcedure = "sp_insertarOferta";
            SqlCommand cmdInsertar = new SqlCommand(sqlStoreProcedure, connection);
            cmdInsertar.CommandType = System.Data.CommandType.StoredProcedure;
            cmdInsertar.Parameters.Add(new SqlParameter("@fecha_inicial", oferta.FechaInicio));
            cmdInsertar.Parameters.Add(new SqlParameter("@fecha_fin", oferta.FechaFinal));
            cmdInsertar.Parameters.Add(new SqlParameter("@descuento", oferta.Descuento));
            cmdInsertar.Parameters.Add(new SqlParameter("@id_producto", oferta.IdProducto));

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
        }//insertarOfertaProducto

        public Boolean eliminarOferta(Oferta oferta)
        {
            SqlConnection connection = new SqlConnection(this.conectionString);
            String sqlStoreProcedure = "sp_eliminarOferta";
            SqlCommand cmdEliminar = new SqlCommand(sqlStoreProcedure, connection);
            cmdEliminar.CommandType = System.Data.CommandType.StoredProcedure;

            cmdEliminar.Parameters.Add(new SqlParameter("@id", oferta.Id));
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
        }//eliminarOferta

        public Boolean editarOferta(Oferta oferta)
        {
            SqlConnection connection = new SqlConnection(this.conectionString);
            String sqlStoreProcedure = "sp_actualizarOferta";
            SqlCommand cmdActualizar = new SqlCommand(sqlStoreProcedure, connection);
            cmdActualizar.CommandType = System.Data.CommandType.StoredProcedure;
            cmdActualizar.Parameters.Add(new SqlParameter("@id", oferta.Id));
            cmdActualizar.Parameters.Add(new SqlParameter("@fecha_inicial", oferta.FechaInicio));
            cmdActualizar.Parameters.Add(new SqlParameter("@fecha_fin", oferta.FechaFinal));
            cmdActualizar.Parameters.Add(new SqlParameter("@descuento", oferta.Descuento));
            cmdActualizar.Parameters.Add(new SqlParameter("@id_producto", oferta.IdProducto));
            cmdActualizar.Parameters.Add(new SqlParameter("@nuevoPrecio", oferta.PrecioDescuento));


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
            }
        }//editarOferta

        public LinkedList<Oferta> obtenerOfertas()
        {
            SqlConnection connection = new SqlConnection(this.conectionString);

            String sqlSelect = "sp_obtenerTodaOferta;";

            SqlDataAdapter sqlDataAdapterOferta = new SqlDataAdapter();
            sqlDataAdapterOferta.SelectCommand = new SqlCommand();
            sqlDataAdapterOferta.SelectCommand.CommandText = sqlSelect;
            sqlDataAdapterOferta.SelectCommand.Connection = connection;

            DataSet dataSetCategoria = new DataSet();
            sqlDataAdapterOferta.Fill(dataSetCategoria, "tb_Oferta");
            sqlDataAdapterOferta.SelectCommand.Connection.Close();

            DataRowCollection dataRow = dataSetCategoria.Tables["tb_Oferta"].Rows;

            LinkedList<Oferta> ofertas = new LinkedList<Oferta>();

            foreach (DataRow currentRow in dataRow)
            {
                Oferta ofertaActual = new Oferta();
                ofertaActual.Id = int.Parse(currentRow["id"].ToString());
                ofertaActual.FechaInicio = currentRow["fecha_inicial"].ToString().Split(' ')[0];
                ofertaActual.FechaFinal = currentRow["fecha_fin"].ToString().Split(' ')[0];
                ofertaActual.Descuento = float.Parse(currentRow["descuento"].ToString());
                ofertaActual.PrecioDescuento = float.Parse(currentRow["nuevoPrecio"].ToString());
                ofertaActual.IdProducto = int.Parse(currentRow["id_producto"].ToString());
                ofertas.AddLast(ofertaActual);
            }//foreach
            return ofertas;
        }//obtenerOfertas

        public LinkedList<Oferta> obtenerOfertaFecha(String fechaI, String fechaF)
        {
            SqlConnection connection = new SqlConnection(this.conectionString);

            String sqlSelect = "sp_obtenerOfertasPorFecha";

            SqlDataAdapter sqladapterIngresos = new SqlDataAdapter();

            sqladapterIngresos.SelectCommand = new SqlCommand(sqlSelect, connection);
            sqladapterIngresos.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqladapterIngresos.SelectCommand.Parameters.Add(new SqlParameter("@fechaI", fechaI));
            sqladapterIngresos.SelectCommand.Parameters.Add(new SqlParameter("@fechaf", fechaF));

            DataSet dataIngresos = new DataSet();
            sqladapterIngresos.Fill(dataIngresos, "tb_Ofertas");
            sqladapterIngresos.SelectCommand.Connection.Close();

            DataRowCollection dataRow = dataIngresos.Tables["tb_Ofertas"].Rows;


            LinkedList<Oferta> ofertas = new LinkedList<Oferta>();

            foreach (DataRow currentRow in dataRow)
            {
                Oferta ofertaActual = new Oferta();
                ofertaActual.Id = int.Parse(currentRow["id"].ToString());
                ofertaActual.FechaInicio = currentRow["fecha_inicial"].ToString().Split(' ')[0];
                ofertaActual.FechaFinal = currentRow["fecha_fin"].ToString().Split(' ')[0];
                ofertaActual.Descuento = float.Parse(currentRow["descuento"].ToString());
                ofertaActual.PrecioDescuento = float.Parse(currentRow["nuevoPrecio"].ToString());
                ofertaActual.IdProducto = int.Parse(currentRow["id_producto"].ToString());
                ofertas.AddLast(ofertaActual);
            }//foreach
            return ofertas;
        }//obtenerOfertaFecha

    }//fin de clase ofertaData
}//fin de namespace