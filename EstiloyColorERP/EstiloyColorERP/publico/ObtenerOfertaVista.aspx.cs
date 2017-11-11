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
    public partial class ObtenerOferta : System.Web.UI.Page
    {
        private OfertaBusiness ofertabusiness = new OfertaBusiness();
        private LinkedList<Oferta> ofertas;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }//pageload

        protected void btnExportarExcel_Click(object sender, ImageClickEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter(sb);
            HtmlTextWriter htw = new HtmlTextWriter(sw);

            Page page = new Page();
            HtmlForm form = new HtmlForm();

            //Color de las columnas-headers
            gvOfertas.HeaderRow.Style.Add("background-color", "#10C7BF");

            gvOfertas.EnableViewState = false;

            // Deshabilitar la validación de eventos, sólo asp.net 2
            page.EnableEventValidation = false;

            // Realiza las inicializaciones de la instancia de la clase Page que requieran los diseñadores RAD.
            page.DesignerInitialize();

            page.Controls.Add(form);
            form.Controls.Add(lblTitulo);
            form.Controls.Add(gvOfertas);

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
                    gvOfertas.RenderControl(hw);
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



        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            cargarTodos();
        }//btnBuscar

        protected void cargarTodos()
        {
            this.ofertas = this.ofertabusiness.obtenerOfertas();
            DataTable table = new DataTable("Ofertas");
            table.Columns.Add(new DataColumn("Id", typeof(string)));
            table.Columns.Add(new DataColumn("Fecha Inicio", typeof(string)));
            table.Columns.Add(new DataColumn("Fecha Fin", typeof(string)));
            table.Columns.Add(new DataColumn("Descuento", typeof(string)));
            table.Columns.Add(new DataColumn("Precio con descuento", typeof(string)));

            String[] fechaFin = tbFechaFinal.Text.ToString().Split(' ');
            String[] datosFecha = fechaFin[0].Split('-');
            String fechaFinal = datosFecha[2] + '/' + datosFecha[1] + '/' + datosFecha[0];

            String[] fechaIni = tbFechaInicio.Text.ToString().Split(' ');
            String[] datosFechaI = fechaIni[0].Split('-');
            String fechaInicial = datosFechaI[2] + '/' + datosFechaI[1] + '/' + datosFechaI[0];


            foreach (Oferta ofertaActual in this.ofertas)
            {

                if (ofertaActual.FechaInicio.Equals(tbFechaInicio.Equals(fechaInicial)) || ofertaActual.FechaFinal.Equals(fechaFinal))
                {
                    DataRow row = table.NewRow();
                    row["Id"] = ofertaActual.Id;
                    row["Fecha Inicio"] = ofertaActual.FechaInicio;
                    row["Fecha Fin"] = ofertaActual.FechaFinal;
                    row["Descuento"] = ofertaActual.Descuento;
                    row["Precio con descuento"] = ofertaActual.PrecioDescuento;
                    table.Rows.Add(row);
                }//Validar apartados del cliente indicado
            }//foreach para recorrer los clientes que estan en la DB
            this.gvOfertas.DataSource = table;
            this.gvOfertas.DataBind();
        }//cargarTodos

    }//class
}//namespace