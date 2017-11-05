﻿using System;
using System.Collections.Generic;
using DOMAIN;
using BUSINESS;
using System.Data;
using System.Web.UI.WebControls;

namespace EstiloyColorERP
{
    public partial class InsertarVentaView : System.Web.UI.Page
    {
        private VentaBusiness ventaBuisiness = new VentaBusiness();
        private ProductoBusiness productoBusiness = new ProductoBusiness();
        private static LinkedList<Producto> productos = new LinkedList<Producto>();
        private DataTable table;

        protected void Page_Load(object sender, EventArgs e)
        {
        }//load


        private float sumarPrecios(LinkedList<Producto> p)
        {
            float total = 0;

            foreach (Producto pActual in p)
            {
                total += pActual.Precio;
            }//foreach

            return total;
        }//sumarPrecios

        private void agregarGridView()
        {
            table = new DataTable("Producto");
            table.Columns.Add(new DataColumn("Código", typeof(int)));
            table.Columns.Add(new DataColumn("Nombre", typeof(string)));
            table.Columns.Add(new DataColumn("Precio", typeof(float)));
            foreach (Producto p in productos)

            {
                DataRow row = table.NewRow();
                row["Código"] = p.IdProct;
                row["Nombre"] = p.Nombre;
                row["Precio"] = p.Precio;
                table.Rows.Add(row);

            }//for
            this.gvProductos.DataSource = table;
            this.gvProductos.DataBind();
        }//agregarGridView

        private Producto obtenerproducto(int codigo)
        {
            return this.productoBusiness.obtenerProductoPorID(codigo);
        }//obtenerproducto

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Producto p = obtenerproducto(int.Parse(TbCodigoProducto.Text));
            productos.AddLast(p);
            agregarGridView();

        }//btnAgregar_Click
        protected void btnInsertar_Click(object sender, EventArgs e)
        {

        }//btnAgregar_Click

        protected void DeleteRowButton_Click(object sender, GridViewDeleteEventArgs e)
        {
        }


        }//class
}//class