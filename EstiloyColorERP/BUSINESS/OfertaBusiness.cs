using DATA;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace BUSINESS
{
    public class OfertaBusiness
    {
        //Atributos
        private OfertaData ofertaData;
        private String stringConeccion;

        public OfertaBusiness()
        {
            this.stringConeccion = WebConfigurationManager.ConnectionStrings["BaseDatos"].ToString();
            this.ofertaData = new OfertaData(this.stringConeccion);
        }//constructor

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

        public LinkedList<Oferta> obtenerOfertas()
        {
            return this.ofertaData.obtenerOfertas();
        }//obtenerOfertas

        public LinkedList<Oferta> obtenerOfertaFecha(String fechaI, String fechaF)
        {
            return this.ofertaData.obtenerOfertaFecha(fechaI, fechaF);
        }//obtenerOfertaFecha

    }//fin de clase OfertaBusiness
}//fin de namespace