using DOMAIN;
using System;
using System.Collections.Generic;
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
            return false;
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