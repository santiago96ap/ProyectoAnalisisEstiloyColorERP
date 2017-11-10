using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace DATA
{
    public class GastoData
    {
        private String conectionString;

        public GastoData(String stringConection)
        {
            this.conectionString = stringConection;
        }//constructor

        public Boolean insertarGasto(Gasto gasto)//, Vendedor venedor
        {
            SqlConnection connection = new SqlConnection(this.conectionString);
            String sqlStoreProcedure = "sp_insertarGasto";
            SqlCommand cmdInsertar = new SqlCommand(sqlStoreProcedure, connection);
            cmdInsertar.CommandType = System.Data.CommandType.StoredProcedure;

            cmdInsertar.Parameters.Add(new SqlParameter("@fecha", gasto.Fecha));
            cmdInsertar.Parameters.Add(new SqlParameter("@hora", gasto.Hora));
            cmdInsertar.Parameters.Add(new SqlParameter("@concepto", gasto.Concepto));
            cmdInsertar.Parameters.Add(new SqlParameter("@total", gasto.Total));
            cmdInsertar.Parameters.Add(new SqlParameter("@id_usuario", gasto.Vendedor));

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

        }//insertarGasto

        public Boolean eliminarGasto(Gasto gasto)
        {
            SqlConnection connection = new SqlConnection(this.conectionString);
            String sqlStoreProcedure = "sp_eliminarGastos";
            SqlCommand cmdEliminar = new SqlCommand(sqlStoreProcedure, connection);
            cmdEliminar.CommandType = System.Data.CommandType.StoredProcedure;

            cmdEliminar.Parameters.Add(new SqlParameter("@id", gasto.Id));
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
            }//if-else;

        }//eliminarGasto

        public Boolean editarGasto(Gasto gasto)
        {
            SqlConnection connection = new SqlConnection(this.conectionString);
            String sqlStoreProcedure = "sp_actualizarGastos";
            SqlCommand cmdActualizar = new SqlCommand(sqlStoreProcedure, connection);
            cmdActualizar.CommandType = System.Data.CommandType.StoredProcedure;
            cmdActualizar.Parameters.Add(new SqlParameter("@id", gasto.Id));
            cmdActualizar.Parameters.Add(new SqlParameter("@fecha", gasto.Fecha));
            cmdActualizar.Parameters.Add(new SqlParameter("@hora", gasto.Hora));
            cmdActualizar.Parameters.Add(new SqlParameter("@concepto", gasto.Concepto));
            cmdActualizar.Parameters.Add(new SqlParameter("@total", gasto.Total));
            cmdActualizar.Parameters.Add(new SqlParameter("@id_usuario", gasto.Vendedor));
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
        }//editarGasto

        public Gasto obtenerGasto()
        {
            return null;
        }//obtenerGasto

        public LinkedList<Gasto> obtenerGastos(String fechaI, String fechaF)
        {
            SqlConnection connection = new SqlConnection(this.conectionString);

            String sqlSelect = "sp_obtenerTodoGasto";

            SqlDataAdapter sqladapterIngresos = new SqlDataAdapter();

            sqladapterIngresos.SelectCommand = new SqlCommand(sqlSelect, connection);
            sqladapterIngresos.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqladapterIngresos.SelectCommand.Parameters.Add(new SqlParameter("@FechaI", fechaI));
            sqladapterIngresos.SelectCommand.Parameters.Add(new SqlParameter("@FechaF", fechaF));

            DataSet dataIngresos = new DataSet();
            sqladapterIngresos.Fill(dataIngresos, "tb_Gastos");
            sqladapterIngresos.SelectCommand.Connection.Close();

            DataRowCollection dataRow = dataIngresos.Tables["tb_Gastos"].Rows;


            LinkedList<Gasto> gasto = new LinkedList<Gasto>();

            foreach (DataRow currentRow in dataRow)
            {
                Gasto eActual = new Gasto();
                eActual.Id = int.Parse(currentRow["id"].ToString());
                eActual.Fecha = currentRow["fecha"].ToString().Split(' ')[0];
                eActual.Hora = currentRow["hora"].ToString();
                eActual.Concepto = currentRow["concepto"].ToString();
                eActual.Total = float.Parse(currentRow["total"].ToString());
                eActual.Vendedor = currentRow["id_usuario"].ToString();
                eActual.Servicio = currentRow["tipoServicio"].ToString();
                gasto.AddLast(eActual);
            }//foreach

            return gasto;
        }//obtenerGastos

    }//fin de clase
}//fin de namespace