using DATA;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Web.Configuration;
using System.Linq;
using System.Web;

namespace BUSINESS
{
    public class GastoBusiness
    {
        //Atributos
        private GastoData gastoData;
        private string stringConeccion;

        public GastoBusiness()
        {
            this.stringConeccion = WebConfigurationManager.ConnectionStrings["BaseDatos"].ToString();
            this.gastoData = new GastoData(this.stringConeccion);
        }//constructor

        public Boolean insertarGasto(Gasto gasto)//, Vendedor venedor
        {
            return this.gastoData.insertarGasto(gasto);//, venedor
        }//insertarGasto

        public Boolean eliminarGasto(Gasto gasto)
        {
            return this.gastoData.eliminarGasto(gasto);
        }//eliminarGasto

        public Boolean editarGasto(Gasto gasto)
        {
            return this.gastoData.editarGasto(gasto);          
        }//editarGasto

        public Gasto obtenerGasto()
        {
            return this.gastoData.obtenerGasto();
        }//obtenerGasto

        public LinkedList<Gasto> obtenerGastos(String fechaIni, String fechaFin)
        {
            return this.gastoData.obtenerGastos(fechaIni, fechaFin);
        }//obtenerGastos

    }//fin de la clase
}//fin del namespace