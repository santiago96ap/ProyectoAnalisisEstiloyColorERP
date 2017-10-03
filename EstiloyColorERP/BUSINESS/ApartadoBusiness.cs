using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DOMAIN;
using DATA;

namespace BUSINESS
{
    public class ApartadoBusiness
    {
        private ApartadoData apartadoData;

        public ApartadoBusiness()
        {
            this.apartadoData = new ApartadoData();
        }//constructor

        public Boolean insertarApartado(Apartado apartado)
        {
            return this.apartadoData.insertarApartado(apartado);
        }//insertarApartado

        public Boolean eliminarApartado(Apartado apartado)
        {
            return this.apartadoData.eliminarApartado(apartado);
        }//eliminarApartado

        public LinkedList<Agenda> obtenerApartados()
        {
            return this.apartadoData.obtenerApartados();
        }//obtenerApartados

        public Agenda obtenerApartado(Apartado apartado)
        {
            return this.apartadoData.obtenerApartado(apartado);
        }//obtenerApartado

        public Boolean actualizarApartado(Apartado apartado)
        {
            return this.apartadoData.actualizarApartado(apartado);
        }//actualizarApartado

    }//class
}//namespace