using DATA;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BUSINESS
{
    public class OfertaBusiness
    {
        //Atributos
        private OfertaData ofertaData;

        public OfertaBusiness()
        {
            this.ofertaData = new OfertaData();
        }//constructor

        public Boolean insertarOfertaCategoria(Categoria categoria, Oferta oferta)
        {
            return this.ofertaData.insertarOfertaCategoria(categoria, oferta);
        }//insertarOfertaCategoria

        public Boolean insertarOfertaProducto(Producto producto, Oferta oferta)
        {
            return this.ofertaData.insertarOfertaProducto(producto, oferta);
        }//insertarOfertaProducto

        public Boolean eliminarOferta(Oferta oferta)
        {
            return this.ofertaData.eliminarOferta(oferta);
        }//eliminarOferta

        public Boolean editarOferta(Oferta oferta)
        {
            return this.ofertaData.editaroferta(oferta);
        }//editarOferta

        public Oferta obtenerOferta()
        {
            return this.ofertaData.obtenerOferta();
        }//obtenerOferta

        public LinkedList<Oferta> obtenerOfertas()
        {
            return this.ofertaData.obtenerOferta();
        }//obtenerOfertas

    }//fin de clase OfertaBusiness
}//fin de namespace