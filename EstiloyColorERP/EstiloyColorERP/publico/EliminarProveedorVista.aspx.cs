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
    public partial class EliminarProveedorView : System.Web.UI.Page
    {
        private ProveedorBusiness proveedorbusiness;
        private LinkedList<Proveedor> proveedores;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.proveedorbusiness = new ProveedorBusiness();
            if (!IsPostBack)
            {
                recargarModulo();
            }//saber si es la primera vez de la pagina
        }//Page_Load

        protected void DeleteRowButton_Click(object sender, GridViewDeleteEventArgs e)
        {
            this.myModal.Attributes["class"] = "modal fade in";
            this.myModal.Attributes["style"] = "display: block;";
            Session["id"] = this.gvProveedores.DataKeys[e.RowIndex].Value.ToString();
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
            Proveedor proveedor = new Proveedor();
            proveedor.Email = Session["id"].ToString();
            if (this.proveedorbusiness.eliminarProveedor(proveedor))
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.success('El proveedor se eliminó exitosamente')", true);
            }
            else {
                ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.error('Se ha producido un error al procesar la solicitud')", true);
            }//saber si se elimino correctamente
            recargarModulo();
        }//ConfirmarButton_Click

        protected void cargarTodos()
        {
            this.proveedores = this.proveedorbusiness.obtenerProveedores();
            DataTable table = new DataTable("Ofertas");
            table.Columns.Add(new DataColumn("Email", typeof(string)));
            table.Columns.Add(new DataColumn("Nombre", typeof(string)));
            table.Columns.Add(new DataColumn("Teléfono", typeof(string)));
            table.Columns.Add(new DataColumn("Dirección", typeof(string)));
            table.Columns.Add(new DataColumn("Página Web", typeof(string)));
            foreach (Proveedor proveedorActual in this.proveedores)
            {
                DataRow row = table.NewRow();
                row["Email"] = proveedorActual.Email;
                row["Nombre"] = proveedorActual.Nombre;
                row["Teléfono"] = proveedorActual.Telefono;
                row["Dirección"] = proveedorActual.Direccion;
                row["Página Web"] = proveedorActual.Web;
                table.Rows.Add(row);
            }//foreach para recorrer los clientes que estan en la DB
            this.gvProveedores.DataSource = table;
            this.gvProveedores.DataBind();
        }//cargarTodos
        
        protected void recargarModulo()
        {
            this.gvProveedores.DataSource = null;
            this.gvProveedores.DataBind();
            cargarTodos();
        }//recergarModulo

    }//class
}//namespace