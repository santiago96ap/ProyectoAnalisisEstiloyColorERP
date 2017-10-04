using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DOMAIN;

namespace DATA
{
    public class ApartadoData
    {

        private String stringConeccion;

        public ApartadoData(string stringConeccion)
        {
            this.stringConeccion = stringConeccion;
        }//constructor

        public Boolean insertarApartado(Apartado apartado)
        {
            return false;
        }//insertarApartado

        public Boolean eliminarApartado(Apartado apartado)
        {
            return false;
        }//eliminarApartado

        public LinkedList<Agenda> obtenerApartados()
        {
            return null;
        }//obtenerApartados

        public Apartado obtenerApartado(Apartado apartado)
        {
            return null;
        }//obtenerApartado

        public Boolean actualizarApartado(Apartado apartado)
        {
            return false;
        }//actualizarApartado

    }//class
}//namespace