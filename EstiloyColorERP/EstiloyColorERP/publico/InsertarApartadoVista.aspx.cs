using BUSINESS;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EstiloyColorERP.publico
{
    public partial class InsertarApartadoView : System.Web.UI.Page
    {

        private ProductoBusiness productoBusiness = new ProductoBusiness();
        private CategoriaBusiness categoriaBusiness = new CategoriaBusiness();
        private ApartadoBusiness apartadoBusiness = new ApartadoBusiness();
        private static LinkedList<Producto> productos = new LinkedList<Producto>();
        private DataTable table;

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                productos = new LinkedList<Producto>();
            }

            String fechaSistema = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            String[] fecha = fechaSistema.ToString().Split(' ');
            this.tbFechaInicio.Text = fecha[0];
            
        }//pageload
        
            private float sumarPrecios()
        {
            float total = 0;

            foreach (Producto pActual in productos)///recorrer la lista de productos
            {
                for (int i = 1; i <= pActual.Cantidad; i++)///recorrer la cantidad de un producto
                {
                    total += pActual.Precio;
                }//for i

            }//foreach

            return total;
        }//sumarPrecios

        private void agregarGridView()
        {
            table = new DataTable("Producto");
            table.Columns.Add(new DataColumn("Código", typeof(int)));
            table.Columns.Add(new DataColumn("Nombre", typeof(string)));
            table.Columns.Add(new DataColumn("Precio", typeof(string)));
            table.Columns.Add(new DataColumn("Cantidad", typeof(int)));
            foreach (Producto p in productos)

            {
                DataRow row = table.NewRow();
                row["Código"] = p.IdProct;
                row["Nombre"] = p.Nombre;
                row["Precio"] = "¢" + p.Precio;
                row["Cantidad"] = p.Cantidad;
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
            Producto p = obtenerproducto(int.Parse(tbDatos.Text));

            //agregar la cantidad de productos por la compra
            p.Cantidad = int.Parse(tbCantidad.Text.ToString());

            productos.AddLast(p);
            agregarGridView();
            this.tbDatos.Text = " ";
            this.tbTotal.Text = sumarPrecios().ToString();
        }//btnAgregar_Click

        protected void DeleteRowButton_Click(object sender, GridViewDeleteEventArgs e)
        {
            String llave = this.gvProductos.DataKeys[e.RowIndex].Value.ToString();
            foreach (Producto productoActual in productos)
            {
                if (productoActual.IdProct == int.Parse(llave))
                {
                    productos.Remove(productoActual);
                    break;
                }
            }
            agregarGridView();
        }//DeleteRowButton_Click

        private void limpiarTexto()
        {
            this.tbDatos.Text = " ";
            this.tbFechaFin.Text = " ";
            this.tbTotal.Text = " ";
            this.tbCantidad.Text = 1 + "";

            this.gvProductos.DataSource = null;
            this.gvProductos.DataBind();
        }//limpiarTexto

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
           

        }//btnAgregar_Click

        private void insertarProductos()
        {

           

        }//insertarProductos

        
    }//class
}//namespace