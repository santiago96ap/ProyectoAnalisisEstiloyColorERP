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

namespace EstiloyColorERP
{
    public partial class ObtenerAgendaView : System.Web.UI.Page
    {
        private AgendaBusiness agendaBusiness = new AgendaBusiness();
        private LinkedList<Agenda> actividades;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.btnExportarExcel.Visible = true;
                this.btnExportarPdf.Visible = true;
            }
            this.btnExportarExcel.Visible = false;
            this.btnExportarPdf.Visible = false;
        }//page_Load

        private void cargarTabla()
        {
            this.actividades = this.agendaBusiness.obtenerAgendasFecha(this.tbFecha.Text.ToString());
            DataTable table = new DataTable("Actividades");
            table.Columns.Add(new DataColumn("Fecha", typeof(string)));
            table.Columns.Add(new DataColumn("Hora", typeof(string)));
            table.Columns.Add(new DataColumn("Actividad", typeof(string)));
            table.Columns.Add(new DataColumn("Dirección", typeof(string)));
            table.Columns.Add(new DataColumn("Cliente", typeof(string)));
            foreach (Agenda actividadActual in this.actividades)
            {

                DataRow row = table.NewRow();
                row["Fecha"] = actividadActual.Fecha;
                row["Hora"] = actividadActual.Hora;
                row["Actividad"] = actividadActual.Actividad;
                row["Dirección"] = actividadActual.Direccion;
                row["Cliente"] = actividadActual.Cliente;
                table.Rows.Add(row);
            }//foreach para recorrer los categorias que estan en la DB
            this.gvActividades.DataSource = table;
            this.gvActividades.DataBind();
        }//cargarTabla

        protected void btnExportarExcel_Click(object sender, ImageClickEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter(sb);
            HtmlTextWriter htw = new HtmlTextWriter(sw);

            Page page = new Page();
            HtmlForm form = new HtmlForm();

            //Color de las columnas-headers
            gvActividades.HeaderRow.Style.Add("background-color", "#10C7BF");

            gvActividades.EnableViewState = false;

            // Deshabilitar la validación de eventos, sólo asp.net 2
            page.EnableEventValidation = false;

            // Realiza las inicializaciones de la instancia de la clase Page que requieran los diseñadores RAD.
            page.DesignerInitialize();

            page.Controls.Add(form);
            form.Controls.Add(lblTitulo);
            form.Controls.Add(gvActividades);

            page.RenderControl(htw);

            Response.Clear();
            Response.Buffer = true;
            Response.ContentType = "application/vnd.ms-excel";
            Response.AddHeader("Content-Disposition", "attachment;filename=ReporteActividadesEstiloyColor.xls");
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
                    gvActividades.RenderControl(hw);
                    StringReader sr = new StringReader(sw.ToString());
                    Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                    HTMLWorker htmlparser = new HTMLWorker(pdfDoc);
                    PdfWriter.GetInstance(pdfDoc, Response.OutputStream);
                    pdfDoc.Open();
                    htmlparser.Parse(sr);
                    pdfDoc.Close();

                    Response.ContentType = "application/pdf";
                    Response.AddHeader("content-disposition", "attachment;filename=ReporteActividadesEstiloyColor.pdf");
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

        protected void tbFecha_TextChanged(object sender, EventArgs e)
        {

            cargarTabla();

        }//fecha changed

    }//class

}//namespace