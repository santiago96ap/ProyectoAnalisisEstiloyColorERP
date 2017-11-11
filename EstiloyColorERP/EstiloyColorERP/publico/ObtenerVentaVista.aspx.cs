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
    public partial class ObtenerVentaView : System.Web.UI.Page
    {
        VentaBusiness ventaBusiness;
        LinkedList<Venta> ventas;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ventas = new LinkedList<Venta>();
            }
        }//pageload

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            String mostrar = ddlProveedores.SelectedItem.Value.ToString();//item seleccionado en el ddl para que se haga un criterio de visualización
            
            this.ventaBusiness = new VentaBusiness();
            ventas = this.ventaBusiness.obtenerVentas();
            DataTable table = new DataTable("Ventas");

            table.Columns.Add(new DataColumn("ID", typeof(int)));
            table.Columns.Add(new DataColumn("Fecha", typeof(string)));
            table.Columns.Add(new DataColumn("Hora", typeof(string)));
            table.Columns.Add(new DataColumn("Cliente", typeof(int)));
            table.Columns.Add(new DataColumn("Servicio", typeof(string)));
            table.Columns.Add(new DataColumn("Pago", typeof(string)));
            table.Columns.Add(new DataColumn("Vendedor", typeof(string)));
            table.Columns.Add(new DataColumn("SubTotal", typeof(float)));
            table.Columns.Add(new DataColumn("Total", typeof(float)));
            foreach (Venta ventaActual in ventas)
            {
                DataRow row = table.NewRow();
                if (mostrar.Equals("cliente"))
                {//si seleccionan todos los usuarios en el sistema
                    if (ventaActual.Cliente.Equals(tbBuscar.Text))
                    {
                        row["ID"] = ventaActual.Id;
                        row["Fecha"] = ventaActual.Fecha;
                        row["Hora"] = ventaActual.Hora;
                        row["Cliente"] = ventaActual.Cliente;
                        row["Servicio"] = ventaActual.TipoServicio;
                        row["Pago"] = ventaActual.TipoPago;
                        row["Vendedor"] = ventaActual.Vendedor;
                        row["SubTotal"] = ventaActual.SubTotal;
                        row["Total"] = ventaActual.Total;
                        table.Rows.Add(row);
                    }    //if cliente
                    
                }
                else
                { //si no se seleccionan todos los usuarios
                    if (ventaActual.Vendedor.Equals(tbBuscar.Text))
                    {
                        row["ID"] = ventaActual.Id;
                        row["Fecha"] = ventaActual.Fecha;
                        row["Hora"] = ventaActual.Hora;
                        row["Cliente"] = ventaActual.Cliente;
                        row["Servicio"] = ventaActual.TipoServicio;
                        row["Pago"] = ventaActual.TipoPago;
                        row["Vendedor"] = ventaActual.Vendedor;
                        row["SubTotal"] = ventaActual.SubTotal;
                        row["Total"] = ventaActual.Total; ;
                        table.Rows.Add(row);
                    }//if
                    
                }//else

            }//foreach
            this.gvVentas.DataSource = table;
            this.gvVentas.DataBind();
        }//buscar

        protected void btnExportarExcel_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter(sb);
            HtmlTextWriter htw = new HtmlTextWriter(sw);

            Page page = new Page();
            HtmlForm form = new HtmlForm();

            //Color de las columnas-headers
            gvVentas.HeaderRow.Style.Add("background-color", "#10C7BF");

            gvVentas.EnableViewState = false;

            // Deshabilitar la validación de eventos, sólo asp.net 2
            page.EnableEventValidation = false;

            // Realiza las inicializaciones de la instancia de la clase Page que requieran los diseñadores RAD.
            page.DesignerInitialize();

            page.Controls.Add(form);
            form.Controls.Add(lblTitulo);
            form.Controls.Add(gvVentas);

            page.RenderControl(htw);

            Response.Clear();
            Response.Buffer = true;
            Response.ContentType = "application/vnd.ms-excel";
            Response.AddHeader("Content-Disposition", "attachment;filename=Ventas.xls");
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
                    gvVentas.RenderControl(hw);
                    StringReader sr = new StringReader(sw.ToString());
                    Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                    HTMLWorker htmlparser = new HTMLWorker(pdfDoc);
                    PdfWriter.GetInstance(pdfDoc, Response.OutputStream);
                    pdfDoc.Open();
                    htmlparser.Parse(sr);
                    pdfDoc.Close();

                    Response.ContentType = "application/pdf";
                    Response.AddHeader("content-disposition", "attachment;filename=Ventas.pdf");
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

        protected void ddlProveedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlProveedores.SelectedValue.Equals("cliente"))
            {
                this.lblInfo.Text = "Telefono";
            }else
            {
                this.lblInfo.Text = "Usuario";
            }
        }//ddlIndexChanged
    }//class
}//namespace