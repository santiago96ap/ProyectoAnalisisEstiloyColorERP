using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOMAIN {
    public class Proveedor {
        private String nombre;
        private String telefono;
        private String direccion;
        private String email;
        private String web;
        public Proveedor() {
            this.nombre = "";
            this.telefono = "";
            this.direccion = "";
            this.email = "";
            this.web = "";
        }//constructor

        public Proveedor(String nombre, String telefono, String direccion, String email) {
            this.nombre = nombre;
            this.telefono = telefono;
            this.direccion = direccion;
            this.email = email;
        }//constructor sobrecargado 

        public Proveedor(String nombre, String telefono, String direccion, String email, String web)
        {
            this.nombre = nombre;
            this.telefono = telefono;
            this.direccion = direccion;
            this.email = email;
            this.web = web;
        }//constructor sobrecargado 

        public string Nombre {
            get {
                return nombre;
            }

            set {
                nombre = value;
            }
        }

        public string Telefono {
            get {
                return telefono;
            }

            set {
                telefono = value;
            }
        }

        public string Direccion {
            get {
                return direccion;
            }

            set {
                direccion = value;
            }
        }

        public string Web
        {
            get
            {
                return web;
            }

            set
            {
                web = value;
            }
        }

        public string Email {
            get {
                return email;
            }

            set {
                email = value;
            }
        }


    }//class
}
