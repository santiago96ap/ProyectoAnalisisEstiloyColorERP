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

        public Boolean insertarOfertaProducto(Oferta oferta)//Producto producto,
        {
            return this.ofertaData.insertarOfertaProducto(oferta);//producto,
        }//insertarOfertaProducto

        public Boolean eliminarOferta(Oferta oferta)
        {
            return this.ofertaData.eliminarOferta(oferta);
        }//eliminarOferta

        public Boolean editarOferta(Oferta oferta)
        {
            return this.ofertaData.editarOferta(oferta);
        }//editarOferta

        public Oferta obtenerOferta()
        {
            return this.ofertaData.obtenerOferta();
        }//obtenerOferta

        public LinkedList<Oferta> obtenerOfertas()
        {
            return this.ofertaData.obtenerOfertas();
        }//obtenerOfertas

    }//fin de clase OfertaBusiness
}//fin de namespace