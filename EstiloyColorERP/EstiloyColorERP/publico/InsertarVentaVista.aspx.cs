using System;
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
            if (!IsPostBack)
            {
                productos = new LinkedList<Producto>();
            }

            this.tbSubtotal.Enabled = false;
            this.tbTotal.Enabled = false;

            String fechaSistema = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            String[] fecha = fechaSistema.ToString().Split(' ');
            this.tbFecha.Text = fecha[0];
            this.tbHora.Text = fecha[1];

            //Establecer los campos de fecha y hora inmodificables
            this.tbFecha.Enabled = false;
            this.tbHora.Enabled = false;
        }//load


        private float sumarPrecios()
        {
            float total = 0;

            foreach (Producto pActual in productos)///recorrer la lista de productos
            {
                for (int i = 1; i <= pActual.Cantidad; i++)///recorrer la cantidad de un producto
                {
                    total += pActual.Precio;
                }

                //total += pActual.Precio;
            }//foreach

            return total;
        }//sumarPrecios

        private void agregarGridView()
        {
            table = new DataTable("Producto");
            table.Columns.Add(new DataColumn("Código", typeof(int)));
            table.Columns.Add(new DataColumn("Nombre", typeof(string)));
            table.Columns.Add(new DataColumn("Precio", typeof(string)));
            foreach (Producto p in productos)

            {
                DataRow row = table.NewRow();
                row["Código"] = p.IdProct;
                row["Nombre"] = p.Nombre;
                row["Precio"] = "¢" + p.Precio;
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
            this.tbSubtotal.Text = sumarPrecios().ToString();
        }//btnAgregar_Click
        protected void btnInsertar_Click(object sender, EventArgs e)
        {
           
            if(this.ventaBuisiness.insertarVenta(new Venta(tbFecha.Text, tbHora.Text, tbTelefono.Text, "u", ddTipoServicio.SelectedItem.Value,
                float.Parse(tbSubtotal.Text), float.Parse(tbTotal.Text), ddTipoPago.SelectedItem.Value)) == true)
            {
                insertarProductos();
                limpiarTexto();
                ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.success('¡Se ha insertado correctamente!')", true);
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.error('Ha ocurrido un error!')", true);

            }//else-if

        }//btnAgregar_Click

        protected void DeleteRowButton_Click(object sender, GridViewDeleteEventArgs e)
        {
        }//DeleteRowButton_Click

        private void limpiarTexto()
        {
            this.tbDatos.Text = " ";
            this.tbFecha.Text = " ";
            this.tbHora.Text = " ";
            this.tbSubtotal.Text = " ";
            this.tbTelefono.Text = " ";
            this.tbTotal.Text = " ";
        }//limpiarTexto

        private void insertarProductos()
        {
            foreach (Producto p in productos)

            {
                if(this.ventaBuisiness.insertarVentaProducto(new VentaProducto(p.IdProct, p.IdCategoria,
                    float.Parse(tbTotal.Text), tbFecha.Text, tbHora.Text, tbTelefono.Text))== false)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.error('Ha ocurrido un error en la inserción de los productos')", true);
                }

            }//for

        }//insertarProductos

        protected void ddTipoVenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.tbDatos.Text = ddTipoVenta.SelectedValue.ToString();
            if (ddTipoVenta.SelectedValue.ToString().Equals("producto"))// si la venta será de productos 
            {
                this.lblIndicador.Text = "Código producto";
                this.gvProductos.Visible = true;
                this.btnAgregar.Visible = true;
                this.tbSubtotal.Enabled = false;
                this.tbCantidad.Visible = true;
                this.lblCantidad.Visible = true;
                this.tbTotal.Enabled = false;
            }
            else if (ddTipoVenta.SelectedValue.ToString().Equals("servicio"))
            {
                this.lblIndicador.Text = "Servicio";
                this.gvProductos.Visible = false;
                this.btnAgregar.Visible = false;
                this.tbCantidad.Visible = false;
                this.lblCantidad.Visible = false;
                this.tbSubtotal.Enabled = true;
                this.tbTotal.Enabled = true;
            }
            else if (ddTipoVenta.SelectedValue.ToString().Equals("otro"))
            {
                this.lblIndicador.Text = "Otro";
                this.gvProductos.Visible = false;
                this.btnAgregar.Visible = false;
                this.tbSubtotal.Enabled = true;
                this.tbCantidad.Visible = false;
                this.lblCantidad.Visible = false;
                this.tbTotal.Enabled = true;
            }
        }
    }//class
}//class