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

        private UsuarioData usuarioData;
        private string stringConeccion;

        public UsuarioBusiness()
        {
            this.stringConeccion = WebConfigurationManager.ConnectionStrings["BaseDatos"].ToString();
            this.usuarioData = new UsuarioData(this.stringConeccion);
        }//constructor

        public Boolean registrarUsuario(Usuario usuario)
        {
            return this.usuarioData.registrarUsuario(usuario);
        }//registrarUsuario

        public Boolean eliminarUsuario(Usuario usuario)
        {
            return this.usuarioData.eliminarUsuario(usuario);
        }//eliminarUsuario

        public Boolean editarUsuario(Usuario usuario, Usuario nuevoUsuario)
        {
            return this.usuarioData.editarUsuario(usuario, nuevoUsuario);
        }//editarusuario

        public LinkedList<Usuario> obtenerUsuarios()
        {
            return this.usuarioData.obtenerUsuarios();
        }//obtenerUsuarios

        public Usuario obtenerUsuario()
        {
            return this.usuarioData.obtenerUsuario();
        }//obtenerUsuario

    }//fin de clase UsuarioBusiness

}//fin de namespace