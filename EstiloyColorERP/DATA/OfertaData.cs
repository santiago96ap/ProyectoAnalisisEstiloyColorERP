using DOMAIN;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

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
            cmdInsertar.Parameters.Add(new SqlParameter("@fecha_fin", oferta.FechaInicio));
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
            /**
             * CÓDIGO AQUÍ
             * **/
            return false;
        }//eliminarOferta

        public Boolean editarOferta(Oferta oferta)
        {
            /**
             * CÓDIGO AQUÍ
             * **/
            return false;
        }//editarOferta

        public Oferta obtenerOferta()
        {
            /**
             * CÓDIGO AQUÍ
             * **/
            return null;
        }//obtenerOferta

        public LinkedList<Oferta> obtenerOfertas()
        {
            /**
             * CÓDIGO AQUÍ
             * **/

            return null;
        }//obtenerOfertas

    }//fin de clase ofertaData
}//fin de namespace