﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOMAIN
{
    public class Venta
    {
        private String fecha;
        private String hora;
        private String cliente;
        private String vendedor;
        private String tipoServicio;
        private LinkedList<int> articuloComprado;
        private float subTotal;
        private float total;
        private String tipoPago;
        public Venta(){
            this.fecha = "";
            this.hora= "";
            this.cliente = "";
            this.vendedor = "";
            this.tipoServicio = "";
            this.articuloComprado = new LinkedList<int>();
            this.subTotal = 0;
            this.total = 0;
            this.tipoPago = "";
        }//constructor

        public Venta(String fecha, String hora, String cliente, String vendedor, String tipoServicio, LinkedList<int> articuloComprado, int subTotal, int total, String tipoPago){
            this.fecha = fecha;
            this.hora = hora;
            this.cliente = cliente;
            this.vendedor = vendedor;
            this.tipoServicio = tipoServicio;
            this.articuloComprado = articuloComprado;
            this.subTotal = subTotal;
            this.total = total;
            this.tipoPago = tipoPago;
        }//constructor sobrecargado
        public string Fecha
        {
            get
            {
                return fecha;
            }//get fecha

            set
            {
                fecha = value;
            }//set fecha
        }//set y get fecha

        public string Hora
        {
            get
            {
                return hora;
            }//get hora

            set
            {
                hora = value;
            }//set hora
        }//set y get hora

        public String Cliente
        {
            get
            {
                return cliente;
            }//get cliente

            set
            {
                cliente = value;
            }//set cliente
        }//set y get cliente

        public String Vendedor
        {
            get
            {
                return vendedor;
            }//get vendedor

            set
            {
                vendedor = value;
            }//set vendedor
        }//set y get vendedor

        public string TipoServicio
        {
            get
            {
                return tipoServicio;
            }//get tipoServicio

            set
            {
                tipoServicio = value;
            }//set tipoServicio
        }//set y get tipoServicio

        public LinkedList<int> ArticuloComprado
        {
            get
            {
                return articuloComprado;
            }//get articulo comprado

            set
            {
                articuloComprado = value;
            }//set articulo comprado
        }//set y get articuloComprado

        public float SubTotal
        {
            get
            {
                return subTotal;
            }//get subtotal

            set
            {
                subTotal = value;
            }//set subtotal
        }//set y get sub total

        public float Total
        {
            get
            {
                return total;
            }//get total

            set
            {
                total = value;
            }//set total
        }//set y get total

        public string TipoPago
        {
            get
            {
                return tipoPago;
            }//get tipo de pago

            set
            {
                tipoPago = value;
            }//set tipo de pago
        }//set y get tipo de pago
    }//class
}//namespace