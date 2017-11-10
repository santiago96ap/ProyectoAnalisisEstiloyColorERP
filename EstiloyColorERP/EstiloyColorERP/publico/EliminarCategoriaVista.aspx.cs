using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DOMAIN;
using BUSINESS;
using System.Data;

namespace EstiloyColorERP.publico
{
    public partial class EliminarCategoriaView : System.Web.UI.Page
    {
        private CategoriaBusiness categoriabusiness;
        private LinkedList<Categoria> categorias;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.categoriabusiness = new CategoriaBusiness();
            cargarTodos();
        }//Page_Load

        protected void DeleteRowButton_Click(object sender, GridViewDeleteEventArgs e)
        {
            this.myModal.Attributes["class"] = "modal fade in";
            this.myModal.Attributes["style"] = "display: block;";
            Session["id"] = this.gvCategorias.DataKeys[e.RowIndex].Value.ToString();
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
            Categoria categoria = new Categoria();
            categoria.Codigo = int.Parse(Session["id"].ToString());
            if (this.categoriabusiness.eliminarCategoria(categoria))
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.success('La categoría se eliminó exitosamente')", true);
            }
            else {
                ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.error('Se ha producido un error al procesar la solicitud')", true);
            }//saber si se elimino correctamente
            cargarTodos();
        }//ConfirmarButton_Click

        protected void cargarTodos()
        {
            this.categorias = this.categoriabusiness.obtenerCategorias();
            DataTable table = new DataTable("Categorias");
            table.Columns.Add(new DataColumn("Código", typeof(string)));
            table.Columns.Add(new DataColumn("Categoría", typeof(string)));
            foreach (Categoria categoriaActual in this.categorias)
            {
                DataRow row = table.NewRow();
                row["Código"] = categoriaActual.Codigo;
                row["Categoría"] = categoriaActual.Nombre;
                table.Rows.Add(row);
            }//foreach para recorrer los clientes que estan en la DB
            this.gvCategorias.DataSource = table;
            this.gvCategorias.DataBind();
        }//cargarTodos
    }//class
}//namespace