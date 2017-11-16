using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOMAIN
{
    public class Usuario
    {

        /// <summary>
        /// Cualquier persona que se le de la posibilidad de ingresar de manera lícita en el sistema es un usuario o tiene un usuario ligado.
        /// </summary>

        //Atributos
        private String nombreUsuario;
        private String nombre;
        private String apellido;
        private String correo;
        private String tipoUsuario;
        private String contrsena;
        private String telefono;
        private String nombreUsuarioActualizar;

        public Usuario()
        {
            this.nombreUsuario = "";
            this.nombre = "";
            this.apellido = "";
            this.correo = "";
            this.tipoUsuario = "";
            this.contrsena = "";
            this.telefono = "";
            this.nombreUsuarioActualizar = "";
        }//constructor por defecto

        public Usuario(String id, String nombre, string apellido, String correo, String rol, String contrasena, String telefono)
        {
            this.nombreUsuario = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.correo = correo;
            this.tipoUsuario = rol;
            this.contrsena = contrasena;
            this.telefono = telefono;
        }//constructor sobrecargado

        public Usuario(String id, String usuarioNuevo, String nombre, string apellido, String correo, String rol, String contrasena, String telefono)
        {
            this.nombreUsuario = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.correo = correo;
            this.tipoUsuario = rol;
            this.contrsena = contrasena;
            this.telefono = telefono;
            this.nombreUsuarioActualizar = usuarioNuevo;
        }//constructor sobrecargado para Actualizar

        public string NombreUsuario
        {
            get
            {
                return nombreUsuario;
            }

            set
            {
                nombreUsuario = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Correo
        {
            get
            {
                return correo;
            }

            set
            {
                correo = value;
            }
        }

        public string Rol
        {
            get
            {
                return tipoUsuario;
            }

            set
            {
                tipoUsuario = value;
            }
        }

        public string Contrsena
        {
            get
            {
                return contrsena;
            }

            set
            {
                contrsena = value;
            }
        }

        public string Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
            }
        }

        public string Apellido
        {
            get
            {
                return apellido;
            }

            set
            {
                apellido = value;
            }
        }

        public string NombreUsuarioActualizar
        {
            get
            {
                return nombreUsuarioActualizar;
            }

            set
            {
                nombreUsuarioActualizar = value;
            }
        }
    }//fin de clase

}//fin del namespace