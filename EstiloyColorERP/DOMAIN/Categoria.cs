using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOMAIN {
    public class Categoria {

        /// <summary>
        /// Cada producto tiene asociada una categoría para su mejor acomodo y obtencioón cuando se consulte por los mismos.
        /// </summary>

        private int codigo;
        private String nombre;

        public Categoria() {
            this.codigo = 0;
            this.nombre = "";
        }//constructor Default

        public Categoria(int codigo, String nombre) {
            this.codigo = codigo;
            this.nombre = nombre;
        }//constructor sobrecargado 1

        public Categoria(String nombre)
        {
            this.nombre = nombre;
        }//constructor sobrecargado 2


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

    }//class
}//namespace