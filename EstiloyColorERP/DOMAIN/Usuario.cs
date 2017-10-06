using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOMAIN
{
    public class Usuario
    {
        //Atributos
        private String nombre;
        private String correo;
        private String rol;
        private String contrsena;
        private String telefono;

        public Usuario()
        {
            this.nombre = "";
            this.correo = "";
            this.rol = "";
            this.contrsena = "";
            this.telefono = "";
        }//constructor por defecto

        public Usuario(String nombre, String correo, String rol, String contrasena, String telefono)
        {
            this.nombre = nombre;
            this.correo = correo;
            this.rol = rol;
            this.contrsena = contrsena;
            this.telefono = telefono;
        }//constructor sobrecargado


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
                return rol;
            }

            set
            {
                rol = value;
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

    }//fin de clase

}//fin del namespace