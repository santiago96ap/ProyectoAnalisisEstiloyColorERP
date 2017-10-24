using DATA;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace BUSINESS
{
    public class IngresoBusiness
    {
        private IngresoData id;
        private String connString = WebConfigurationManager.ConnectionStrings["baseDatos"].ToString();

        public IngresoBusiness()
        {
            this.id = new IngresoData(connString);
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