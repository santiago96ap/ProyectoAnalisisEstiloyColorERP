using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOMAIN
{
    public class Apartado
    {
        private int id;
        private String idCliente;
        private LinkedList<String> productos;
        private float monto;
        private float abono;
        private String fechaInicio;
        private String fechaFinal;
        private String estado;
        private int numFactura;

        public Apartado()
        {
            this.idCliente = "";
            this.productos = new LinkedList<String>();
            this.monto = 0;
            this.abono= 0;
            this.fechaInicio = "";
            this.fechaFinal = "";
        }//constructor

        public Apartado(String idCliente, LinkedList<String> productos, float monto, float abono, String fechaInicio, String fechaFinal)
        {
            this.idCliente = idCliente;
            this.productos = productos;
            this.monto = monto;
            this.abono = abono;
            this.fechaInicio = fechaInicio;
            this.fechaFinal = fechaFinal;
        }//constructor sobrecargado

        public Apartado(int id, String idCliente, LinkedList<String> productos, float monto, float abono, String fechaInicio, String fechaFinal)
        {
            this.id = id;
            this.idCliente = idCliente;
            this.productos = productos;
            this.monto = monto;
            this.abono = abono;
            this.fechaInicio = fechaInicio;
            this.fechaFinal = fechaFinal;
        }//constructor sobrecargado1

        public String Estado
        {
            get
            {
                return estado;
            }//get estado

            set
            {
                estado = value;
            }//set estado
        }//Estado

        public int NumFactura
        {
            get
            {
                return numFactura;
            }//get estado

            set
            {
                numFactura = value;
            }//set estado
        }//NumFactura

        public int Id
        {
            get
            {
                return id;
            }//get id

            set
            {
                id = value;
            }//set id
        }//Id

        public string IdCliente
        {
            get
            {
                return idCliente;
            }//get idCliente

            set
            {
                idCliente = value;
            }//set idCliente
        }//IdCliente

        public LinkedList<string> Productos
        {
            get
            {
                return productos;
            }//get productos

            set
            {
                productos = value;
            }//set productos
        }//Productos

        public float Monto
        {
            get
            {
                return monto;
            }//get monto

            set
            {
                monto = value;
            }//set monto
        }//Monto

        public float Abono
        {
            get
            {
                return abono;
            }//get abono

            set
            {
                abono = value;
            }//set abono
        }//Abono

        public string FechaInicio
        {
            get
            {
                return fechaInicio;
            }//get fechaInicio

            set
            {
                fechaInicio = value;
            }//set fechaInicio
        }//FechaInicio

        public string FechaFinal
        {
            get
            {
                return fechaFinal;
            }//get fechaFinal

            set
            {
                fechaFinal = value;
            }//set fechaFinal
        }//FechaFinal
    }//class
}//namespace