using DOMAIN;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DATA
{
    public class UsuarioData
    {

        private String conectionString;

        public UsuarioData(String conectionString)
        {
            this.conectionString = conectionString;
        }//constructor

        public Boolean registrarUsuario(Usuario usuario)
        {
            SqlConnection connection = new SqlConnection(this.conectionString);
            String sqlStoreProcedure = "sp_insertarUsuario";
            SqlCommand cmdInsertar = new SqlCommand(sqlStoreProcedure, connection);
            cmdInsertar.CommandType = System.Data.CommandType.StoredProcedure;

            cmdInsertar.Parameters.Add(new SqlParameter("@nombre", usuario.Nombre));
            cmdInsertar.Parameters.Add(new SqlParameter("@apellido", usuario.Telefono));
            cmdInsertar.Parameters.Add(new SqlParameter("@tipo_Usuario", usuario.Rol));
            cmdInsertar.Parameters.Add(new SqlParameter("@contrasenia", usuario.Contrsena));
            cmdInsertar.Parameters.Add(new SqlParameter("@email", usuario.Correo));

            cmdInsertar.Connection.Open();
            cmdInsertar.ExecuteNonQuery();
            cmdInsertar.Connection.Close();

            return true;
        }//registrarUsuario

        public Boolean eliminarUsuario(Usuario usuario)
        {
            return false;
        }//eliminarUsuario

        public Boolean editarUsuario(Usuario usuario, Usuario nuevoUsuario)
        {
            return false;
        }//editarUsuario

        public LinkedList<Usuario> obtenerUsuarios()
        {
            return null;
        }//obtenerUsuarios

        public Usuario obtenerUsuario()
        {
            return null;
        }//obtenerUsuario

    }//fin de clase UsuarioData

}//fin de namespace