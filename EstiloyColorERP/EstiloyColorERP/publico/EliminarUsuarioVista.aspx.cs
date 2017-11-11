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
    public partial class Eliminar : System.Web.UI.Page
    {
        private UsuarioBusiness usuariobusiness;
        private LinkedList<Usuario> usuario;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.usuariobusiness = new UsuarioBusiness();
        }//Page_Load

        protected void DeleteRowButton_Click(object sender, GridViewDeleteEventArgs e)
        {
            this.myModal.Attributes["class"] = "modal fade in";
            this.myModal.Attributes["style"] = "display: block;";
            Session["id"] = this.gvUsuarios.DataKeys[e.RowIndex].Value.ToString();
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
            Usuario usuario = new Usuario();
            usuario.NombreUsuario = Session["id"].ToString();
            if (this.usuariobusiness.eliminarUsuario(usuario))
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.success('El usuario se eliminó exitosamente')", true);
            }
            else {
                ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.error('Se ha producido un error al procesar la solicitud')", true);
            }//saber si se elimino correctamente
            reiniciarModulo();
        }//ConfirmarButton_Click

        protected void cargarTodos(String rol)
        {
            this.usuario = this.usuariobusiness.obtenerUsuarios();
            DataTable table = new DataTable("Usuarios");
            table.Columns.Add(new DataColumn("Nombre Usuario", typeof(string)));
            table.Columns.Add(new DataColumn("Nombre", typeof(string)));
            table.Columns.Add(new DataColumn("Apellidos", typeof(string)));
            table.Columns.Add(new DataColumn("Correo", typeof(string)));
            table.Columns.Add(new DataColumn("Teléfono", typeof(string)));
            table.Columns.Add(new DataColumn("Rol", typeof(string)));
            foreach (Usuario usuarioActual in this.usuario)
            {
                if (usuarioActual.Rol.Equals(rol))
                {
                    DataRow row = table.NewRow();
                    row["Nombre Usuario"] = usuarioActual.NombreUsuario;
                    row["Nombre"] = usuarioActual.Nombre;
                    row["Apellidos"] = usuarioActual.Apellido;
                    row["Correo"] = usuarioActual.Correo;
                    row["Teléfono"] = usuarioActual.Telefono;
                    row["Rol"] = usuarioActual.Rol;
                    table.Rows.Add(row);
                }//Validar apartados del cliente indicado
            }//foreach para recorrer los clientes que estan en la DB
            this.gvUsuarios.DataSource = table;
            this.gvUsuarios.DataBind();
        }//cargarTodos

        protected void reiniciarModulo()
        {
            this.tbUsuario.Text = "";
            this.gvUsuarios.DataSource = null;
            this.gvUsuarios.DataBind();
        }//reiniciarModulo

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            cargarTodos(this.tbUsuario.Text);
        }//btnBuscar_Click
    }//class
}//namespace