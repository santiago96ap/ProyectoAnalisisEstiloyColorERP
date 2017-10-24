using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOMAIN {
    public class Categoria {

        private int id;
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

        public Categoria(int id, int codigo, String nombre)
        {
            this.id = id;
            this.codigo = codigo;
            this.nombre = nombre;
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
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