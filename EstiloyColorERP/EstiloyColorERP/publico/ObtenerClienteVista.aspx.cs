using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DOMAIN;
using BUSINESS;

using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using System.Text;
using System.IO;
using System.Web.UI.HtmlControls;

namespace EstiloyColorERP{
    public partial class ObtenerCliente : System.Web.UI.Page{

        private ClienteBusiness clientebusiness;
        private LinkedList<Cliente> clientes;
        protected void Page_Load(object sender, EventArgs e){
            //cargar clientes en dropdown
            this.clientebusiness = new ClienteBusiness();
            this.clientes = this.clientebusiness.obtenerClientes();
            if (this.ddlClientes != null)
            {
                if (!IsPostBack)
                {
                    this.ddlClientes.Items.Add("---Clientes---");
                    foreach (Cliente clienteActual in this.clientes)
                    {
                        this.ddlClientes.Items.Add(new System.Web.UI.WebControls.ListItem(clienteActual.Nombre + " " + clienteActual.Apellidos, clienteActual.Telefono));
                    }//llenar el listbox con los clientes de la DB
                    this.btnExportarExcel.Visible = false;
                    this.btnExportarPdf.Visible = false;
                }//if para ver si es la primera vez que se carga el modulo
            }//if para ver si el listbox esta vacio
        }//cargar el modulo de obtener

        protected void btnBuscar_Click(object sender, EventArgs e){
            if (!String.IsNullOrWhiteSpace(this.tbBuscar.Text))
            {
                cargarTabla(this.tbBuscar.Text);
            }else if (!this.ddlClientes.SelectedItem.Text.Equals("---Clientes---")){
                cargarTabla(this.ddlClientes.SelectedItem.Value);
            }else {
                cargarTodos();
            }//opciones de busqueda
            this.tbBuscar.Text = "";
            this.ddlClientes.SelectedIndex = 0;
            this.btnExportarExcel.Visible = true;
            this.btnExportarPdf.Visible = true;
        }//btnBuscar_Click

        protected void cargarTabla(String cliente){
            DataTable table = new DataTable("Clientes");
            table.Columns.Add(new DataColumn("Nombre", typeof(string)));
            table.Columns.Add(new DataColumn("Teléfono", typeof(string)));
            table.Columns.Add(new DataColumn("Dirección", typeof(string)));
            table.Columns.Add(new DataColumn("Correo", typeof(string)));
            foreach (Cliente clienteActual in this.clientes)
            {
                if (cliente.Equals(clienteActual.Telefono)){
                    DataRow row = table.NewRow();
                    row["Nombre"] = clienteActual.Nombre + " " + clienteActual.Apellidos;
                    row["Teléfono"] = clienteActual.Telefono;
                    row["Dirección"] = clienteActual.Direccion;
                    row["Correo"] = clienteActual.Correo;
                    table.Rows.Add(row);
                }//if para mostrar el cliente especifico
            }//foreach para recorrer los clientes que estan en la DB
            this.gvClientes.DataSource = table;
            this.gvClientes.DataBind();
        }//cargarTabla

        protected void cargarTodos()
        {
            DataTable table = new DataTable("Clientes");
            table.Columns.Add(new DataColumn("Nombre", typeof(string)));
            table.Columns.Add(new DataColumn("Teléfono", typeof(string)));
            table.Columns.Add(new DataColumn("Dirección", typeof(string)));
            table.Columns.Add(new DataColumn("Correo", typeof(string)));
            foreach (Cliente clienteActual in this.clientes)
            {
                    DataRow row = table.NewRow();
                    row["Nombre"] = clienteActual.Nombre + " " + clienteActual.Apellidos;
                    row["Teléfono"] = clienteActual.Telefono;
                    row["Dirección"] = clienteActual.Direccion;
                    row["Correo"] = clienteActual.Correo;
                    table.Rows.Add(row);
            }//foreach para recorrer los clientes que estan en la DB
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
            Response.AddHeader("Content-Disposition", "attachment;filename=Clientes.xls");
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
                    Response.AddHeader("content-disposition", "attachment;filename=Clientes.pdf");
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