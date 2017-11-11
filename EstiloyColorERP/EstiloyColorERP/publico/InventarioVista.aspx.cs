using BUSINESS;
using DOMAIN;
using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace EstiloyColorERP.publico
{
    public partial class InventarioVista : System.Web.UI.Page
    {
        private CategoriaBusiness categoriaBusniess;
        private LinkedList<Categoria> categorias;
        ProductoBusiness productoBusiness;
        LinkedList<Producto> productos;
        protected void Page_Load(object sender, EventArgs e)
        {
            //cargar categorias en dropdown
            this.categoriaBusniess = new CategoriaBusiness();
            this.categorias = this.categoriaBusniess.obtenerCategorias();
            if (this.ddlCategorias != null)
            {
                if (!IsPostBack)
                {
                    foreach (Categoria categoriaActual in this.categorias)
                    {
                        this.ddlCategorias.Items.Add(new System.Web.UI.WebControls.ListItem(categoriaActual.Nombre, categoriaActual.Codigo+""));
                    }//llenar el listbox con los clientes de la DB
                    
                }//if para ver si es la primera vez que se carga el modulo
            }//if para ver si el listbox esta vacio
        }//pageload

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            int mostrar = int.Parse(ddlCategorias.SelectedItem.Value.ToString());//item seleccionado en el ddl para que se haga un criterio de visualización
            
            this.productoBusiness = new ProductoBusiness();
            productos = this.productoBusiness.obtenerTodosProductos();
            DataTable table = new DataTable("Ventas");

            table.Columns.Add(new DataColumn("ID", typeof(int)));
            table.Columns.Add(new DataColumn("Nombre", typeof(string)));
            table.Columns.Add(new DataColumn("Descripcion", typeof(string)));
            table.Columns.Add(new DataColumn("Costo", typeof(float)));
            table.Columns.Add(new DataColumn("Precio", typeof(float)));
            table.Columns.Add(new DataColumn("Cantidad", typeof(string)));
            table.Columns.Add(new DataColumn("Proveedor", typeof(string)));
            table.Columns.Add(new DataColumn("Categoría", typeof(string)));
            foreach (Producto productoActual in productos)
            {
                DataRow row = table.NewRow();
                if (productoActual.IdCategoria.Equals(mostrar))
                {//selecciona productos pro categoría antes cargada                    
                    row["ID"] = productoActual.IdProct;
                    row["Nombre"] = productoActual.Nombre;
                    row["Descripcion"] = productoActual.Descripcion;
                    row["Costo"] = productoActual.Costo;
                    row["Precio"] = productoActual.Precio;
                    row["Cantidad"] = productoActual.Cantidad;
                    row["Proveedor"] = productoActual.IdProveedor;
                    row["Categoría"] = mostrar;
                    table.Rows.Add(row);
                }//if

            }//foreach
            this.gvProductos.DataSource = table;
            this.gvProductos.DataBind();
        }//buscar Click

        protected void btnExportarExcel_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter(sb);
            HtmlTextWriter htw = new HtmlTextWriter(sw);

            Page page = new Page();
            HtmlForm form = new HtmlForm();

            //Color de las columnas-headers
            gvProductos.HeaderRow.Style.Add("background-color", "#10C7BF");

            gvProductos.EnableViewState = false;

            // Deshabilitar la validación de eventos, sólo asp.net 2
            page.EnableEventValidation = false;

            // Realiza las inicializaciones de la instancia de la clase Page que requieran los diseñadores RAD.
            page.DesignerInitialize();

            page.Controls.Add(form);
            form.Controls.Add(lblTitulo);
            form.Controls.Add(gvProductos);

            page.RenderControl(htw);

            Response.Clear();
            Response.Buffer = true;
            Response.ContentType = "application/vnd.ms-excel";
            Response.AddHeader("Content-Disposition", "attachment;filename=Inventario.xls");
            Response.Charset = "UTF-8";
            Response.ContentEncoding = Encoding.Default;
            Response.Write(sb.ToString());
            Response.End();
        }//BTN EXCEL

        protected void btnExportarPdf_Click(object sender, EventArgs e)
        {
            using (StringWriter sw = new StringWriter())
            {
                using (HtmlTextWriter hw = new HtmlTextWriter(sw))
                {
                    lblTitulo.RenderControl(hw);
                    gvProductos.RenderControl(hw);
                    StringReader sr = new StringReader(sw.ToString());
                    Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                    HTMLWorker htmlparser = new HTMLWorker(pdfDoc);
                    PdfWriter.GetInstance(pdfDoc, Response.OutputStream);
                    pdfDoc.Open();
                    htmlparser.Parse(sr);
                    pdfDoc.Close();

                    Response.ContentType = "application/pdf";
                    Response.AddHeader("content-disposition", "attachment;filename=Inventario.pdf");
                    Response.Cache.SetCacheability(HttpCacheability.NoCache);
                    Response.Write(pdfDoc);
                    Response.End();
                }
            }
        }//BTN PDF

        public override void VerifyRenderingInServerForm(Control control)
        {
            /* Verifies that the control is rendered */
        }

    }//class

}//namespace