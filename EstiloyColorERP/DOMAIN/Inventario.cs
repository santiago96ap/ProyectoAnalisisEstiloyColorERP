using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOMAIN {
    public class Inventario {
        private LinkedList<int> productos;
        private int cantidad;

        public Inventario() {
            this.cantidad = 0;
            this.productos = new LinkedList<int>();
        }

        public Inventario(LinkedList<int> productos, int cantidad) {
            this.productos = productos;
            this.cantidad = cantidad;
        }

        public LinkedList<int> Productos {
            get {
                return productos;
            }

            set {
                productos = value;
            }
        }

        public int Cantidad {
            get {
                return cantidad;
            }

            set {
                cantidad = value;
            }
        }
    }

}