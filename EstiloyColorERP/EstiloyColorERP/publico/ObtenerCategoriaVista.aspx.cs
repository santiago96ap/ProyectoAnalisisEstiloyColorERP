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
    public partial class ObtenerCategoria : System.Web.UI.Page
    {
        private CategoriaBusiness cb = new CategoriaBusiness();
        private LinkedList<Categoria> categorias;
        protected void Page_Load(object sender, EventArgs e)
        {
            cargarTodos();
        }//page_load

        protected void cargarTodos()
        {
            this.categorias = this.cb.obtenerCategorias();
            DataTable table = new DataTable("Categoria");
            table.Columns.Add(new DataColumn("ID", typeof(int)));
            table.Columns.Add(new DataColumn("Nombre", typeof(string)));
            foreach (Categoria clienteActual in this.categorias)
            {
                DataRow row = table.NewRow();
                row["ID"] = clienteActual.Codigo;
                row["Nombre"] = clienteActual.Nombre;
                table.Rows.Add(row);
            }//foreach para recorrer los categorias que estan en la DB
            this.gvClientes.DataSource = table;
            this.gvClientes.DataBind();
        }//cargarTodos

        protected void btnExportarExcel_Click(object sender, ImageClickEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter(sb);
            HtmlTextWriter htw = new HtmlTextWriter(sw);

            Page page = new Page();
            HtmlForm form = new HtmlForm();

            //Color de las columnas-headers
            gvClientes.HeaderRow.Style.Add("background-color", "#10C7BF");

            gvClientes.EnableViewState = false;

            // Deshabilitar la validación de eventos, sólo asp.net 2
            page.EnableEventValidation = false;

            // Realiza las inicializaciones de la instancia de la clase Page que requieran los diseñadores RAD.
            page.DesignerInitialize();

            page.Controls.Add(form);
            form.Controls.Add(lblTitulo);
            form.Controls.Add(gvClientes);

            page.RenderControl(htw);

            Response.Clear();
            Response.Buffer = true;
            Response.ContentType = "application/vnd.ms-excel";
            Response.AddHeader("Content-Disposition", "attachment;filename=ReporteCategoríasEstiloyColor.xls");
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
                    gvClientes.RenderControl(hw);
                    StringReader sr = new StringReader(sw.ToString());
                    Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                    HTMLWorker htmlparser = new HTMLWorker(pdfDoc);
                    PdfWriter.GetInstance(pdfDoc, Response.OutputStream);
                    pdfDoc.Open();
                    htmlparser.Parse(sr);
                    pdfDoc.Close();

                    Response.ContentType = "application/pdf";
                    Response.AddHeader("content-disposition", "attachment;filename=ReporteCategoriasEstiloyColor.pdf");
                    Response.Cache.SetCacheability(HttpCacheability.NoCache);
                    Response.Write(pdfDoc);
                    Response.End();
                }// using (StringWriter sw = new StringWriter())
            }//using (HtmlTextWriter hw = new HtmlTextWriter(sw))
        }//btnExportarPdf_Click

        public override void VerifyRenderingInServerForm(Control control)
        {
            /* Verifies that the control is rendered */
        }//VerifyRenderingInServerForm
    }//class
}//nameSpace