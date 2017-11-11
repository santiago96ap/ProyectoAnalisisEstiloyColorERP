using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DOMAIN;
using BUSINESS;
using System.Data;

namespace EstiloyColorERP.publico
{
    public partial class EliminarProductoVista : System.Web.UI.Page
    {
        private ProductoBusiness productobusiness;
        private LinkedList<Producto> productos;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.productobusiness = new ProductoBusiness();
        }//Page_Load

        protected void DeleteRowButton_Click(object sender, GridViewDeleteEventArgs e)
        {
            this.myModal.Attributes["class"] = "modal fade in";
            this.myModal.Attributes["style"] = "display: block;";
            Session["id"] = this.gvProductos.DataKeys[e.RowIndex].Value.ToString();
        }//btnBuscar_Click

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            this.myModal.Attributes["class"] = "modal fade";
            this.myModal.Attributes["style"] = "display: none;";
            ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.error('Se canceló la eliminación')", true);
        }//CancelarButton_Click

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            this.myModal.Attributes["class"] = "modal fade";
            this.myModal.Attributes["style"] = "display: none;";
            Producto producto = new Producto();
            producto.IdProct = int.Parse(Session["id"].ToString());
            if (this.productobusiness.eliminarProducto(producto))
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.success('El producto se eliminó exitosamente')", true);
            }
            else {
                ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.error('Se ha producido un error al procesar la solicitud')", true);
            }//saber si se elimino correctamente
            reiniciarModulo();
        }//ConfirmarButton_Click

        protected void cargarTodos(String producto)
        {
            this.productos = this.productobusiness.obtenerTodosProductos();
            DataTable table = new DataTable("Productos");
            table.Columns.Add(new DataColumn("Id", typeof(string)));
            table.Columns.Add(new DataColumn("Nombre", typeof(string)));
            table.Columns.Add(new DataColumn("Descripción", typeof(string)));
            table.Columns.Add(new DataColumn("Costo", typeof(string)));
            table.Columns.Add(new DataColumn("Precio", typeof(string)));
            table.Columns.Add(new DataColumn("Cantidad", typeof(string)));
            table.Columns.Add(new DataColumn("Proveedor", typeof(string)));
            table.Columns.Add(new DataColumn("Categoría", typeof(string)));
            foreach (Producto productoActual in this.productos)
            {
                if (productoActual.IdProct == int.Parse(producto))
                {
                    DataRow row = table.NewRow();
                    row["Id"] = productoActual.IdProct;
                    row["Nombre"] = productoActual.Nombre;
                    row["Descripción"] = productoActual.Descripcion;
                    row["Costo"] = productoActual.Costo;
                    row["Precio"] = productoActual.Precio;
                    row["Cantidad"] = productoActual.Cantidad;
                    row["Proveedor"] = productoActual.IdProveedor;
                    row["Categoría"] = productoActual.IdCategoria;
                    table.Rows.Add(row);
                }//Validar apartados del cliente indicado
            }//foreach para recorrer los clientes que estan en la DB
            this.gvProductos.DataSource = table;
            this.gvProductos.DataBind();
        }//cargarTodos

        protected void reiniciarModulo()
        {
            this.tbProducto.Text = "";
            this.gvProductos.DataSource = null;
            this.gvProductos.DataBind();
        }//reiniciarModulo

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            cargarTodos(this.tbProducto.Text);
        }//btnBuscar_Click
    }//class
}//namespace