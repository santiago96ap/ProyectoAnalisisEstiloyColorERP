using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DATA
{
    public class Oferta
    {
        //Atributos
        private int idProducto;
        private int idCategoria;
        //Atributos fijos
        private String fechaInicio;
        private String fechaFinal;
        private float descuento;

        public Oferta()
        {

            this.idProducto = 0;
            this.idCategoria = 0;
            this.fechaInicio = "";
            this.fechaFinal = "";
            this.descuento = 0;

        }//constructor por defecto

        public Oferta(int idCategoria, String fechainicio, String fechaFinal, float descuento)
        {
            this.idCategoria = idCategoria;
            this.fechaInicio = fechainicio;
            this.fechaFinal = fechaFinal;
            this.descuento = descuento;
        }//constructor sobrecargado Categoria

        public Oferta(String fechaInicio, String fechaFinal, float descuento, int idProducto)
        {
            this.idProducto = idProducto;
            this.fechaInicio = fechaInicio;
            this.fechaFinal = fechaFinal;
            this.descuento = descuento;
        }//constructor sobrecargado Producto
        
    }//fin de la clase
}//fin de namespace