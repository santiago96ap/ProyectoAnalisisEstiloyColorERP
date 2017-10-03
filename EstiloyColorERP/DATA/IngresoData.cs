using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DATA
{
    public class IngresoData
    {
        private String stringConeccion;

        public IngresoData(string stringConeccion)
        {
            this.stringConeccion = stringConeccion;
        }//constructor sobreCargado


        public Boolean insertarIngreso(Ingreso ingreso)
        {
            return false;
        }//insertarIngreso

        public Boolean actualizarIngreso(Ingreso ingreso)
        {
            return false;
        }//actualizarIngreso

        public Boolean eliminarIngreso(Ingreso ingreso)
        {
            return false;
        }//eliminarIngreso

        public LinkedList<Ingreso> obtenerIngresos(String fechaInicial, String fechaFinal)
        {
            return null;
        }//obtnerIngresos



    }//class
}//namespace