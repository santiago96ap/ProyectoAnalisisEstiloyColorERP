using System;
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
            String sqlStoreProcedure = "sp_insertarCliente";
            SqlCommand cmdInsertar = new SqlCommand(sqlStoreProcedure, connection);
            cmdInsertar.CommandType = System.Data.CommandType.StoredProcedure;

            //cmdInsertar.Parameters.Add(new SqlParameter("@telefono", cliente.Telefono));
            //cmdInsertar.Parameters.Add(new SqlParameter("@nombre", cliente.Nombre));
            //cmdInsertar.Parameters.Add(new SqlParameter("@apellidos", cliente.Apellidos));
            //cmdInsertar.Parameters.Add(new SqlParameter("@direccion", cliente.Direccion));
            //cmdInsertar.Parameters.Add(new SqlParameter("@email", cliente.Correo));

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
        }//insertarApartado

        public Boolean eliminarApartado(Apartado apartado)
        {
            return false;
        }//eliminarApartado

        public LinkedList<Apartado> obtenerApartados()
        {
            return null;
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