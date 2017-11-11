using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DOMAIN;
using BUSINESS;
using System.Data;

namespace EstiloyColorERP
{
    public partial class EliminarOferta : System.Web.UI.Page
    {
        private OfertaBusiness ofertabusiness;
        private LinkedList<Oferta> ofertas;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.ofertabusiness = new OfertaBusiness();
        }//Page_Load

        protected void DeleteRowButton_Click(object sender, GridViewDeleteEventArgs e)
        {
            this.myModal.Attributes["class"] = "modal fade in";
            this.myModal.Attributes["style"] = "display: block;";
            Session["id"] = this.gvOferta.DataKeys[e.RowIndex].Value.ToString();
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
            Oferta oferta = new Oferta();
            oferta.Id = int.Parse(Session["id"].ToString());
            if (this.ofertabusiness.eliminarOferta(oferta))
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.success('La oferta se eliminó exitosamente')", true);
            }
            else {
                ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.error('Se ha producido un error al procesar la solicitud')", true);
            }//saber si se elimino correctamente
            reiniciarModulo();
        }//ConfirmarButton_Click

        protected void cargarTodos(String producto)
        {
            this.ofertas = this.ofertabusiness.obtenerOfertas();
            DataTable table = new DataTable("Ofertas");
            table.Columns.Add(new DataColumn("Id", typeof(string)));
            table.Columns.Add(new DataColumn("Fecha Inicio", typeof(string)));
            table.Columns.Add(new DataColumn("Fecha Fin", typeof(string)));
            table.Columns.Add(new DataColumn("Descuento", typeof(string)));
            table.Columns.Add(new DataColumn("Precio con descuento", typeof(string)));
            foreach (Oferta ofertaActual in this.ofertas)
            {
                if (ofertaActual.IdProducto == int.Parse(producto))
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
            this.gvOferta.DataSource = table;
            this.gvOferta.DataBind();
        }//cargarTodos

        protected void reiniciarModulo()
        {
            this.tbProducto.Text = "";
            this.gvOferta.DataSource = null;
            this.gvOferta.DataBind();
        }//reiniciarModulo

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            cargarTodos(this.tbProducto.Text);
        }//btnBuscar_Click
    }//class
}//namespace