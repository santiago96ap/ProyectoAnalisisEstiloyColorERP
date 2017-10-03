using DATA;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BUSINESS
{
    public class GastoBusiness
    {
        //Atributos
        GastoData gastoData;

        public GastoBusiness()
        {
            gastoData = new GastoData();
        }//constructor

        public Boolean insertarGasto(Gasto gasto, Vendedor venedor)
        {
            return this.gastoData.insertarGasto(gasto, venedor);
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

        public LinkedList<Gasto> obtenerGastos(String fechaFin, String fechaInicio)
        {
            return this.gastoData.obtenerGastos();
        }//obtenerGastos

    }//fin de la clase
}//fin del namespace