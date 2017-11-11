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
    public partial class ObtenerProveedorView : System.Web.UI.Page
    {
        private ProveedorBusiness proveedorBusiness;
        private LinkedList<Proveedor> proveedores;

        protected void Page_Load(object sender, EventArgs e)
        {
            //cargar clientes en dropdown
            this.proveedorBusiness = new ProveedorBusiness();
            this.proveedores = this.proveedorBusiness.obtenerProveedores();
            if (this.ddlProveedores != null)
            {
                if (!IsPostBack)
                {
                    this.ddlProveedores.Items.Add("---Proveedores---");
                    foreach (Proveedor proveedorActual in this.proveedores)
                    {
                        this.ddlProveedores.Items.Add(new System.Web.UI.WebControls.ListItem(proveedorActual.Nombre));
                    }//llenar el listbox con los proveedores de la DB
                    this.btnExportarExcel.Visible = false;
                    this.btnExportarPdf.Visible = false;
                }//if para ver si es la primera vez que se carga el modulo
            }//if para ver si el listbox esta vacio
        }//pageload

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(this.tbBuscar.Text))
            {
                cargarTabla(this.tbBuscar.Text);
            }
            else if (!this.ddlProveedores.SelectedItem.Text.Equals("---Proveedores---"))
            {
                cargarTabla(this.ddlProveedores.SelectedItem.Value);
            }
            else
            {
                cargarTodos();
            }//opciones de busqueda
            this.tbBuscar.Text = "";
            this.ddlProveedores.SelectedIndex = 0;
            this.btnExportarExcel.Visible = true;
            this.btnExportarPdf.Visible = true;
        }//btnBuscar_Click

        protected void cargarTabla(String proveedor)
        {
            DataTable table = new DataTable("Proveedores");
            table.Columns.Add(new DataColumn("Nombre", typeof(string)));
            table.Columns.Add(new DataColumn("Página Web", typeof(string)));
            table.Columns.Add(new DataColumn("Dirección", typeof(string)));
            table.Columns.Add(new DataColumn("Correo", typeof(string)));
            table.Columns.Add(new DataColumn("Teléfono", typeof(string)));
            foreach (Proveedor proveedorActual in this.proveedores)
            {
                if (proveedor.Equals(proveedorActual.Nombre))
                {
                    DataRow row = table.NewRow();
                    row["Nombre"] = proveedorActual.Nombre;
                    row["Página Web"] = proveedorActual.Web;
                    row["Dirección"] = proveedorActual.Direccion;
                    row["Correo"] = proveedorActual.Email;
                    row["Teléfono"] = proveedorActual.Telefono;                    
                    table.Rows.Add(row);

                }//if para mostrar el proveedores especifico
            }//foreach para recorrer los proveedores que estan en la DB
            this.gvProveedores.DataSource = table;
            this.gvProveedores.DataBind();
        }//cargarTabla

        protected void cargarTodos()
        {
            DataTable table = new DataTable("Proveedores");
            table.Columns.Add(new DataColumn("Nombre", typeof(string)));
            table.Columns.Add(new DataColumn("Página Web", typeof(string)));
            table.Columns.Add(new DataColumn("Dirección", typeof(string)));
            table.Columns.Add(new DataColumn("Correo", typeof(string)));
            table.Columns.Add(new DataColumn("Teléfono", typeof(string)));
            foreach (Proveedor proveedorActual in this.proveedores)
            {
                DataRow row = table.NewRow();
                row["Nombre"] = proveedorActual.Nombre;
                row["Página Web"] = proveedorActual.Web;
                row["Dirección"] = proveedorActual.Direccion;
                row["Correo"] = proveedorActual.Email;
                row["Teléfono"] = proveedorActual.Telefono;
                table.Rows.Add(row);
            }//foreach para recorrer los proveedores que estan en la DB
            this.gvProveedores.DataSource = table;
            this.gvProveedores.DataBind();
        }//cargarTodos

        protected void btnExportarExcel_Click(object sender, ImageClickEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter(sb);
            HtmlTextWriter htw = new HtmlTextWriter(sw);

            Page page = new Page();
            HtmlForm form = new HtmlForm();

            //Color de las columnas-headers
            gvProveedores.HeaderRow.Style.Add("background-color", "#10C7BF");

            gvProveedores.EnableViewState = false;

            // Deshabilitar la validación de eventos, sólo asp.net 2
            page.EnableEventValidation = false;

            // Realiza las inicializaciones de la instancia de la clase Page que requieran los diseñadores RAD.
            page.DesignerInitialize();

            page.Controls.Add(form);
            form.Controls.Add(lblTitulo);
            form.Controls.Add(gvProveedores);

            page.RenderControl(htw);

            Response.Clear();
            Response.Buffer = true;
            Response.ContentType = "application/vnd.ms-excel";
            Response.AddHeader("Content-Disposition", "attachment;filename=Proveedores.xls");
            Response.Charset = "UTF-8";
            Response.ContentEncoding = Encoding.Default;
            Response.Write(sb.ToString());
            Response.End();
        }//btnExportarExcel_Click

        protected void btnExportarPdf_Click(object sender, ImageClickEventArgs e)
        {
            using (StringWriter sw = new StringWriter())
            {
                using (HtmlTextWriter hw = new HtmlTextWriter(sw))
                {
                    lblTitulo.RenderControl(hw);
                    gvProveedores.RenderControl(hw);
                    StringReader sr = new StringReader(sw.ToString());
                    Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                    HTMLWorker htmlparser = new HTMLWorker(pdfDoc);
                    PdfWriter.GetInstance(pdfDoc, Response.OutputStream);
                    pdfDoc.Open();
                    htmlparser.Parse(sr);
                    pdfDoc.Close();

                    Response.ContentType = "application/pdf";
                    Response.AddHeader("content-disposition", "attachment;filename=Proveedores.pdf");
                    Response.Cache.SetCacheability(HttpCacheability.NoCache);
                    Response.Write(pdfDoc);
                    Response.End();
                }
            }
        }//btnExportarPdf_Click

        public override void VerifyRenderingInServerForm(Control control)
        {
            /* Verifies that the control is rendered */
        }

    }//class
}//namespace