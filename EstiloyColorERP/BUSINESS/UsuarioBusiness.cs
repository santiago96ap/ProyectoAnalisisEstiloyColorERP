using DATA;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace BUSINESS
{
    public class UsuarioBusiness
    {
        /// <summary>
        /// Clase encargadad de las reglas de negocios para acceder a la base de datos
        /// </summary>

        //Atributos
        private UsuarioData usuarioData;
        private string stringConeccion;

        /// <summary>
        /// Método constructor de la clase
        /// </summary>
        public UsuarioBusiness()
        {
            this.stringConeccion = WebConfigurationManager.ConnectionStrings["BaseDatos"].ToString();
            this.usuarioData = new UsuarioData(this.stringConeccion);
        }//constructor

        /// <summary>
        /// Método por el cual se ingresa un nuevo usuario en el sistema
        /// </summary>
        /// <param name="usuario">Usuario creado por un administrador</param>
        /// <returns>1 si se pudo completar la acción o 0 si hubo un error</returns>
        public Boolean registrarUsuario(Usuario usuario)
        {
            return this.usuarioData.registrarUsuario(usuario);
        }//registrarUsuario

        /// <summary>
        /// Método para eliminar un usuario del sistema
        /// </summary>
        /// <param name="usuario">Usuario al que se desa borrar</param>
        /// <returns>1 si se pudo completar la acción o 0 si hubo un error</returns>
        public Boolean eliminarUsuario(Usuario usuario)
        {
            return this.usuarioData.eliminarUsuario(usuario);
        }//eliminarUsuario

        /// <summary>
        /// Método encargado de la edición de datos en un usuario
        /// </summary>
        /// <param name="usuario">Usuario con datos modificados</param>
        /// <returns>1 si se pudo completar la acción o 0 si hubo un error</returns>
        public Boolean editarUsuario(Usuario usuario)
        {
            return this.usuarioData.editarUsuario(usuario);
        }//editarusuario

        /// <summary>
        /// Método por el cual se obtienen todos los usuarios del sistema
        /// </summary>
        /// <returns>Lista con todos los usuarios del sistema</returns>
        public LinkedList<Usuario> obtenerUsuarios()
        {
            return this.usuarioData.obtenerUsuarios();
        }//obtenerUsuarios       

    }//fin de clase UsuarioBusiness
}//fin de namespace