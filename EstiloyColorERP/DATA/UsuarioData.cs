using DOMAIN;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DATA
{
    public class UsuarioData
    {

        private String stringConeccion;

        public UsuarioData(String stringConeccion)
        {
            this.stringConeccion = stringConeccion;
        }//constructor

        public Boolean registrarUsuario(Usuario usuario)
        {
            SqlConnection connection = new SqlConnection(this.stringConeccion);
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

            SqlConnection connection = new SqlConnection(this.stringConeccion);

            String sqlSelect = "sp_obtenerTodoUsuario;";

            SqlDataAdapter sqlDataAdapterClient = new SqlDataAdapter();
            sqlDataAdapterClient.SelectCommand = new SqlCommand();
            sqlDataAdapterClient.SelectCommand.CommandText = sqlSelect;
            sqlDataAdapterClient.SelectCommand.Connection = connection;

            DataSet dataSetClientes = new DataSet();
            sqlDataAdapterClient.Fill(dataSetClientes, "tb_Usuario");
            sqlDataAdapterClient.SelectCommand.Connection.Close();

            DataRowCollection dataRow = dataSetClientes.Tables["tb_Usuario"].Rows;

            LinkedList<Usuario> usuarios = new LinkedList<Usuario>();

            foreach (DataRow currentRow in dataRow)
            {
                Usuario usuarioActual = new Usuario();
                usuarioActual.Id = currentRow["nombre_usuario"].ToString();
                usuarioActual.Nombre = currentRow["nombre"].ToString() +" "+ currentRow["apellidos"].ToString();
                usuarioActual.Rol = currentRow["tipo_Usuario"].ToString();
                usuarioActual.Correo = currentRow["email"].ToString();
                usuarioActual.Telefono = currentRow["telefono"].ToString();
                usuarios.AddLast(usuarioActual);
            }//recorrer todos los clientes que vienen de la DB
            return usuarios;

        }//obtenerUsuarios

        public Usuario obtenerUsuario()
        {
            return null;
        }//obtenerUsuario

    }//fin de clase UsuarioData

}//fin de namespace