using DATA;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BUSINESS
{
    public class IngresoBusiness
    {
        private IngresoData id;


        public IngresoBusiness(String conectionString)
        {
            this.id = new IngresoData(conectionString);
        }//constructor

        public Boolean insertarIngreso(Ingreso ingreso)
        {
            return this.id.insertarIngreso(ingreso);
        }//insertarIngreso

        public Boolean actualizarIngreso(Ingreso ingreso)
        {
            return this.id.actualizarIngreso(ingreso);
        }//actualiazarIngreso

        public Boolean eliminarIngreso(Ingreso ingreso)
        {
            return this.id.eliminarIngreso(ingreso);
        }//eliminarIngreso

        public LinkedList<Ingreso> obtenerIngreso(String fechaI, String fechaF)
        {
            return this.id.obtenerIngreso(fechaI,fechaF);
        }//obtenerIngreso
    }//class
}//namespace