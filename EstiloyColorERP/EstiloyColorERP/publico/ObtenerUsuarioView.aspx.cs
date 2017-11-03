using BUSINESS;
using DOMAIN;
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

using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;

namespace EstiloyColorERP.publico
{
    public partial class MostrarUsuario : System.Web.UI.Page
    {
        UsuarioBusiness usuarioBusiness;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }//pageload

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            String mostrar = ddlRol.SelectedItem.Value.ToString();//item seleccionado en el ddl para que se haga un criterio de visualización
            
            this.usuarioBusiness = new UsuarioBusiness();
            LinkedList<Usuario> usuarios;
            usuarios = this.usuarioBusiness.obtenerUsuarios();
            DataTable table = new DataTable("Usarios");

            table.Columns.Add(new DataColumn("ID", typeof(string)));
            table.Columns.Add(new DataColumn("Nombre", typeof(string)));
            table.Columns.Add(new DataColumn("Rol", typeof(string)));
            table.Columns.Add(new DataColumn("Correo", typeof(string)));
            table.Columns.Add(new DataColumn("Teléfono", typeof(string)));
            foreach (Usuario usuarioActual in usuarios)
                
            {
                DataRow row = table.NewRow();
                if (mostrar.Equals("todos"))
                {//si seleccionan todos los usuarios en el sistema
                    

                    row["ID"] = usuarioActual.Id;
                    row["Nombre"] = usuarioActual.Nombre;
                    row["Rol"] = usuarioActual.Rol;
                    row["Correo"] = usuarioActual.Correo;
                    row["Teléfono"] = usuarioActual.Telefono;

                    table.Rows.Add(row);
                }
                else { //si no se seleccionan todos los usuarios
                if (mostrar.Equals(usuarioActual.Rol))                        
                    {

                        row["ID"] = usuarioActual.Id;
                        row["Nombre"] = usuarioActual.Nombre;
                        row["Rol"] = usuarioActual.Rol;
                        row["Correo"] = usuarioActual.Correo;
                        row["Teléfono"] = usuarioActual.Telefono;

                        table.Rows.Add(row);
                    }//if
            }//else
                
            }//foreach
            gvUsuarios.RowHeaderColumn = "Hola";
            this.gvUsuarios.DataSource = table;
            this.gvUsuarios.DataBind();

        }//btnBuscar

        protected void btnExcel_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter(sb);
            HtmlTextWriter htw = new HtmlTextWriter(sw);

            Page page = new Page();
            HtmlForm form = new HtmlForm();

            //Color de las columnas-headers
            gvUsuarios.HeaderRow.Style.Add("background-color", "#10C7BF");

            gvUsuarios.EnableViewState = false;

            // Deshabilitar la validación de eventos, sólo asp.net 2
            page.EnableEventValidation = false;

            // Realiza las inicializaciones de la instancia de la clase Page que requieran los diseñadores RAD.
            page.DesignerInitialize();

            page.Controls.Add(form);
            form.Controls.Add(lblTitulo);
            form.Controls.Add(gvUsuarios);

            page.RenderControl(htw);

            Response.Clear();
            Response.Buffer = true;
            Response.ContentType = "application/vnd.ms-excel";
            Response.AddHeader("Content-Disposition", "attachment;filename=Usuarios.xls");
            Response.Charset = "UTF-8";
            Response.ContentEncoding = Encoding.Default;
            Response.Write(sb.ToString());
            Response.End();
        }//BTN EXCEL

        protected void pdf_Click(object sender, EventArgs e)
        {
            using (StringWriter sw = new StringWriter())
            {
                using (HtmlTextWriter hw = new HtmlTextWriter(sw))
                {
                    lblTitulo.RenderControl(hw);
                    gvUsuarios.RenderControl(hw);
                    StringReader sr = new StringReader(sw.ToString());
                    Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                    HTMLWorker htmlparser = new HTMLWorker(pdfDoc);
                    PdfWriter.GetInstance(pdfDoc, Response.OutputStream);
                    pdfDoc.Open();
                    htmlparser.Parse(sr);
                    pdfDoc.Close();

                    Response.ContentType = "application/pdf";
                    Response.AddHeader("content-disposition", "attachment;filename=Usuarios.pdf");
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
    }
}