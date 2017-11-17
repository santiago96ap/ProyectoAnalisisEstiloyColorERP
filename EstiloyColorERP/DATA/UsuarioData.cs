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

        private String stringConeccion;//Este va hacer el String de conexión de la BD

        public UsuarioData(String stringConeccion)
        {
            this.stringConeccion = stringConeccion;
        }//constructor

        /// <summary>
        /// Este método hará una inserción a la BD
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns>Boolean</returns>
        public Boolean registrarUsuario(Usuario usuario)
        {
            SqlConnection connection = new SqlConnection(this.stringConeccion);
            String sqlStoreProcedure = "sp_insertarUsuario";
            SqlCommand cmdInsertar = new SqlCommand(sqlStoreProcedure, connection);
            cmdInsertar.CommandType = System.Data.CommandType.StoredProcedure;

            cmdInsertar.Parameters.Add(new SqlParameter("@nombre", usuario.Nombre));
            cmdInsertar.Parameters.Add(new SqlParameter("@nombre_usuario", usuario.NombreUsuario));
            cmdInsertar.Parameters.Add(new SqlParameter("@apellidos", usuario.Apellido));
            cmdInsertar.Parameters.Add(new SqlParameter("@tipo_Usuario", usuario.Rol));
            cmdInsertar.Parameters.Add(new SqlParameter("@constrasenia", usuario.Contrsena));
            cmdInsertar.Parameters.Add(new SqlParameter("@email", usuario.Correo));
            cmdInsertar.Parameters.Add(new SqlParameter("@telefono", usuario.Telefono));

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

        }//registrarUsuario


        /// <summary>
        /// Este método eliminará un usuario
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns>Boolean</returns>
        public Boolean eliminarUsuario(Usuario usuario)
        {
            SqlConnection connection = new SqlConnection(this.stringConeccion);
            String sqlStoreProcedure = "sp_eliminarUsuario";
            SqlCommand cmdEliminar = new SqlCommand(sqlStoreProcedure, connection);
            cmdEliminar.CommandType = System.Data.CommandType.StoredProcedure;

            cmdEliminar.Parameters.Add(new SqlParameter("@nombre_usuario", usuario.NombreUsuario));
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
        }//eliminarUsuario

        /// <summary>
        /// Este método actualizará la información de un usuario
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns>Boolean</returns>
        public Boolean editarUsuario(Usuario usuario)
        {
            SqlConnection connection = new SqlConnection(this.stringConeccion);
            String sqlStoreProcedure = "sp_actualizarUsuario";
            SqlCommand cmdActualizar = new SqlCommand(sqlStoreProcedure, connection);
            cmdActualizar.CommandType = System.Data.CommandType.StoredProcedure;

            cmdActualizar.Parameters.Add(new SqlParameter("@nombre_usuarioN", usuario.NombreUsuarioActualizar));
            cmdActualizar.Parameters.Add(new SqlParameter("@usuario", usuario.NombreUsuario));
            cmdActualizar.Parameters.Add(new SqlParameter("@nombre", usuario.Nombre));
            cmdActualizar.Parameters.Add(new SqlParameter("@apellidos", usuario.Apellido));
            cmdActualizar.Parameters.Add(new SqlParameter("@tipo_Usuario", usuario.Rol));
            cmdActualizar.Parameters.Add(new SqlParameter("@constrasenia", usuario.Contrsena));
            cmdActualizar.Parameters.Add(new SqlParameter("@email", usuario.Correo));
            cmdActualizar.Parameters.Add(new SqlParameter("@telefono", usuario.Telefono));

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
        }//editarUsuario


        /// <summary>
        /// Obtiene todos los usuarios de la BD
        /// </summary>
        /// <returns> LinkedList<Usuario></returns>
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
                usuarioActual.NombreUsuario = currentRow["nombre_usuario"].ToString();
                usuarioActual.Nombre = currentRow["nombre"].ToString();
                usuarioActual.Apellido = currentRow["apellidos"].ToString();
                usuarioActual.Rol = currentRow["tipo_Usuario"].ToString();
                usuarioActual.Correo = currentRow["email"].ToString();
                usuarioActual.Telefono = currentRow["telefono"].ToString();
                usuarioActual.Contrsena = currentRow["constrasenia"].ToString();
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