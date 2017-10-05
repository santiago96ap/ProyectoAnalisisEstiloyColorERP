using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DATA
{
    public class IngresoData
    {
        private String conectionString;
        public IngresoData(String conectionString)
        {
            this.conectionString = conectionString;
        }//constructor


        public Boolean insertarIngreso(Ingreso ingreso)
        {
            return false;
        }//insertarIngreso

        public Boolean actualizarIngreso(Ingreso ingreso)
        {
            return false;
        }//actualiazarIngreso

        public Boolean eliminarIngreso(Ingreso ingreso)
        {
            return false;
        }//eliminarIngreso

        public LinkedList<Ingreso> obtenerIngreso(String fechaI, String fechaF)
        {
            return null;
        }//obtenerIngreso
    }//class
}//namespace