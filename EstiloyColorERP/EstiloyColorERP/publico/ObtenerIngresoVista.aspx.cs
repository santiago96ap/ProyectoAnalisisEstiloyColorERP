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
    public partial class ObtenerIngresosView : System.Web.UI.Page
    {
        private IngresoBusiness ib = new IngresoBusiness();
        private LinkedList<Ingreso> ingresos;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.btnExportarExcel.Visible = false;
            this.btnExportarPdf.Visible = false;
        }//Page_Load

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            this.ingresos = this.ib.obtenerIngreso(tbFechaInicio.Text, tbFechaFinal.Text);
            
            DataTable table = new DataTable("Tabla1");
            table.Columns.Add(new DataColumn("ID", typeof(int)));
            table.Columns.Add(new DataColumn("Fecha", typeof(string)));
            table.Columns.Add(new DataColumn("Hora", typeof(string)));
            table.Columns.Add(new DataColumn("Concepto", typeof(string)));
            table.Columns.Add(new DataColumn("Monto", typeof(float)));
            table.Columns.Add(new DataColumn("Usuario", typeof(string)));
            foreach (var item in ingresos)
            {
                DataRow row = table.NewRow();
                row["ID"] = item.Id;
                row["Fecha"] = item.Fecha;
                row["Hora"] = item.Hora;
                row["Concepto"] = item.Concepto;
                row["Monto"] = item.Total;
                row["Usuario"] = item.Usuario;
                table.Rows.Add(row);
            }//foreach
            gvIngresos.DataSource = table;
            gvIngresos.DataBind();

            this.btnExportarPdf.Visible = true;
            this.btnExportarExcel.Visible = true;
        }//Button1_Click

        protected void btnExportarExcel_Click(object sender, ImageClickEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter(sb);
            HtmlTextWriter htw = new HtmlTextWriter(sw);

            Page page = new Page();
            HtmlForm form = new HtmlForm();

            //Color de las columnas-headers
            gvIngresos.HeaderRow.Style.Add("background-color", "#10C7BF");

            gvIngresos.EnableViewState = false;

            // Deshabilitar la validación de eventos, sólo asp.net 2
            page.EnableEventValidation = false;

            // Realiza las inicializaciones de la instancia de la clase Page que requieran los diseñadores RAD.
            page.DesignerInitialize();

            page.Controls.Add(form);
            form.Controls.Add(lblTitulo);
            form.Controls.Add(gvIngresos);

            page.RenderControl(htw);

            Response.Clear();
            Response.Buffer = true;
            Response.ContentType = "application/vnd.ms-excel";
            Response.AddHeader("Content-Disposition", "attachment;filename=ReporteIngresosEstiloyColor.xls");
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
                    gvIngresos.RenderControl(hw);
                    StringReader sr = new StringReader(sw.ToString());
                    Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                    HTMLWorker htmlparser = new HTMLWorker(pdfDoc);
                    PdfWriter.GetInstance(pdfDoc, Response.OutputStream);
                    pdfDoc.Open();
                    htmlparser.Parse(sr);
                    pdfDoc.Close();

                    Response.ContentType = "application/pdf";
                    Response.AddHeader("content-disposition", "attachment;filename=ReporteIngresosEstiloyColor.pdf");
                    Response.Cache.SetCacheability(HttpCacheability.NoCache);
                    Response.Write(pdfDoc);
                    Response.End();
                }// using (StringWriter sw = new StringWriter())
            }//using (HtmlTextWriter hw = new HtmlTextWriter(sw))

        }//btnExportarPdf_Click
        public override void VerifyRenderingInServerForm(Control control)
        {
            /* Verifies that the control is rendered */
        }

    }//class
}//namespace