using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOMAIN {
    public class Categoria {

        private int codigo;
        private String nombre;

        public Categoria() {
            this.codigo = 0;
            this.nombre = "";
        }

        public Categoria(int codigo, String nombre) {
            this.codigo = codigo;
            this.nombre = nombre;
        }

        public int Codigo {
            get {
                return codigo;
            }

            set {
                codigo = value;
            }
        }

        public String Nombre {
            get {
                return nombre;
            }

            set {
                nombre = value;
            }
        }

    }
}