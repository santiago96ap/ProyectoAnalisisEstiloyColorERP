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
            this.gastoData.insertarGasto(gasto, venedor);
        }//insertarGasto

        public Boolean eliminarGasto(Gasto gasto)
        {
            this.gastoData.eliminarGasto(gasto);
        }//eliminarGasto

        public Boolean editarGasto(Gasto gasto)
        {
            this.gastoData.editarGasto(gasto);          
        }//editarGasto

        public Boolean obtenerGasto()
        {
            this.gastoData.obtenerGasto();
        }//obtenerGasto

        public Boolean obtenerGastos()
        {
            this.gastoData.obtenerGastos();
        }//obtenerGastos

    }//fin de la clase
}//fin del namespace