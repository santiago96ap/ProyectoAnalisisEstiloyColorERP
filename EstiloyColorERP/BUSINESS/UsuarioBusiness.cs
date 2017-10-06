using DATA;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BUSINESS
{
    public class UsuarioBusiness
    {

        private UsuarioData usuarioData;

        public UsuarioBusiness(String connectionString)
        {
            this.usuarioData = new UsuarioData(connectionString);
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