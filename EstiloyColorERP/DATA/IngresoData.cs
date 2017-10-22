using DOMAIN;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DATA
{
    public class IngresoData
    {
        private String conectionString;
        public IngresoData(String conectionString)
        {
            this.conectionString = conectionString;
        }//constructor

        public Boolean insertarIngreso(Ingreso ingreso)
        {
            SqlConnection connection = new SqlConnection(this.conectionString);
            String sqlStoreProcedure = "sp_insertarIngresos";
            SqlCommand cmdInsertar = new SqlCommand(sqlStoreProcedure, connection);
            cmdInsertar.CommandType = System.Data.CommandType.StoredProcedure;
            //@fecha date , @hora time ,@concepto varchar(100), @total float, @id_usuario varchar(30)
            cmdInsertar.Parameters.Add(new SqlParameter("@fecha", ingreso.Fecha));
            cmdInsertar.Parameters.Add(new SqlParameter("@hora", ingreso.Hora));
            cmdInsertar.Parameters.Add(new SqlParameter("@concepto", ingreso.Concepto));
            cmdInsertar.Parameters.Add(new SqlParameter("@total", ingreso.Total));
            cmdInsertar.Parameters.Add(new SqlParameter("@id_usuario", ingreso.Usuario));

            cmdInsertar.Connection.Open();
            cmdInsertar.ExecuteNonQuery();
            cmdInsertar.Connection.Close();
            return true;
        }//insertarIngreso

        public Boolean actualizarIngreso(Ingreso ingreso)
        {
            SqlConnection connection = new SqlConnection(this.conectionString);
            String sqlStoreProcedure = "sp_actualizarIngresos";
            SqlCommand cmdActualizar = new SqlCommand(sqlStoreProcedure, connection);
            cmdActualizar.CommandType = System.Data.CommandType.StoredProcedure;
            cmdActualizar.Parameters.Add(new SqlParameter("@id", ingreso.Id));
            cmdActualizar.Parameters.Add(new SqlParameter("@fecha", ingreso.Fecha));
            cmdActualizar.Parameters.Add(new SqlParameter("@hora", ingreso.Hora));
            cmdActualizar.Parameters.Add(new SqlParameter("@concepto", ingreso.Concepto));
            cmdActualizar.Parameters.Add(new SqlParameter("@total", ingreso.Total));
            cmdActualizar.Parameters.Add(new SqlParameter("@id_usuario", ingreso.Usuario));


            cmdActualizar.Connection.Open();
            cmdActualizar.ExecuteNonQuery();
            cmdActualizar.Connection.Close();
            return false;
        }//actualiazarIngreso

        public Boolean eliminarIngreso(Ingreso ingreso)
        {
            SqlConnection connection = new SqlConnection(this.conectionString);
            String sqlStoreProcedure = "sp_eliminarIngresos";
            SqlCommand cmdEliminar = new SqlCommand(sqlStoreProcedure, connection);
            cmdEliminar.CommandType = System.Data.CommandType.StoredProcedure;

            cmdEliminar.Parameters.Add(new SqlParameter("@id", ingreso.Id));
            cmdEliminar.Connection.Open();
            cmdEliminar.ExecuteNonQuery();
            cmdEliminar.Connection.Close();
            return true;
        }//eliminarIngreso

        public LinkedList<Ingreso> obtenerIngreso(String fechaI, String fechaF)
        {
            SqlConnection connection = new SqlConnection(this.conectionString);

            String sqlSelect = "sp_obtenerTodoIngreso;";

            SqlDataAdapter sqlDataAdapterClient = new SqlDataAdapter();
            sqlDataAdapterClient.SelectCommand = new SqlCommand();
            sqlDataAdapterClient.SelectCommand.CommandText = sqlSelect;
            sqlDataAdapterClient.SelectCommand.Connection = connection;

            DataSet dataSetPersonas = new DataSet();
            sqlDataAdapterClient.Fill(dataSetPersonas, "tb_Ingresos");
            sqlDataAdapterClient.SelectCommand.Connection.Close();

            DataRowCollection dataRow = dataSetPersonas.Tables["tb_Ingresos"].Rows;

            LinkedList<Ingreso> ingresos = new LinkedList<Ingreso>();

            foreach (DataRow currentRow in dataRow)
            {
                Ingreso eActual = new Ingreso();
                eActual.Id = int.Parse(currentRow["id"].ToString());
                eActual.Fecha = currentRow["fecha"].ToString();
                eActual.Hora = currentRow["hora"].ToString();
                eActual.Concepto = currentRow["concepto"].ToString();
                eActual.Usuario = currentRow["usuario"].ToString();
                ingresos.AddLast(eActual);
            }//foreach
            return ingresos;
        }//obtenerIngreso
    }//class
}//namespace