using BUSINESS;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EstiloyColorERP.publico
{
    public partial class ActualizarUsuario : System.Web.UI.Page
    {
        private UsuarioBusiness usuarioBusiness;
        private LinkedList<Usuario> usuarios;
        private static String usuarioSeleccionado;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarInformacion();
                this.ddTipoRol.Items.Add(new ListItem("Administrador", "administrador"));
                this.ddTipoRol.Items.Add(new ListItem("Vendedor", "vendedor"));
            }
        }//Page_Load
        protected void cargarInformacion()
        {
            this.usuarioBusiness = new UsuarioBusiness();
            this.usuarios = this.usuarioBusiness.obtenerUsuarios();
            DataTable table = new DataTable("Usuarios");

            table.Columns.Add(new DataColumn("Usuario", typeof(string)));
            table.Columns.Add(new DataColumn("Nombre", typeof(string)));
            table.Columns.Add(new DataColumn("Apellidos", typeof(string)));
            table.Columns.Add(new DataColumn("e-mail", typeof(string)));
            table.Columns.Add(new DataColumn("Rol", typeof(string)));
            table.Columns.Add(new DataColumn("Contraseña", typeof(string)));
            table.Columns.Add(new DataColumn("Teléfono", typeof(string)));


            foreach (Usuario usuariorActual in this.usuarios)
            {
                DataRow row = table.NewRow();

                row["Usuario"] = usuariorActual.NombreUsuario;
                row["Nombre"] = usuariorActual.Nombre;
                row["Apellidos"] = usuariorActual.Apellido;
                row["e-mail"] = usuariorActual.Correo;
                row["Rol"] = usuariorActual.Rol;
                row["Contraseña"] = usuariorActual.Contrsena;
                row["Teléfono"] = usuariorActual.Telefono;

                table.Rows.Add(row);
            }//foreach

            this.gvUsuarios.DataSource = table;
            this.gvUsuarios.DataBind();
        }//cargarInformacion


        protected void gvGastos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        protected void btnActualizar_Click1(object sender, EventArgs e)
        {

            if (String.IsNullOrWhiteSpace(this.tbNombre.Text) || String.IsNullOrWhiteSpace(this.tbEmail.Text) || String.IsNullOrWhiteSpace(this.tbApellidos.Text) || String.IsNullOrWhiteSpace(this.tbPass.Text) || String.IsNullOrWhiteSpace(this.tbUsuario.Text))
            {//si existe un tb en blanco se indica al usuario y no se aplica ningún cambio
                ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.error('Error en los datos ingresados')", true);
            }
            else
            {
                this.usuarioBusiness = new UsuarioBusiness();

                Usuario uNuevo = new Usuario(usuarioSeleccionado,tbUsuario.Text, tbNombre.Text, tbApellidos.Text, tbEmail.Text, ddTipoRol.SelectedItem.Value, tbPass.Text, tbTelefono.Text);
                    
                bool respuesta = this.usuarioBusiness.editarUsuario(uNuevo);

                if (respuesta)// Si se actualiza el usuario se recargan los datos y se dejan los tb en blanco
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.success('El usuario se actualizó exitosamente')", true);
                    //dejar los campos de texto en blanco
                    this.tbUsuario.Text = " ";
                    this.tbNombre.Text = " ";
                    this.tbApellidos.Text = " ";
                    this.tbPass.Text = "";
                    this.tbTelefono.Text = " ";
                    this.tbEmail.Text = " ";

                    cargarInformacion();//recargar el gridview
                }//if
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.error('Se ha producido un error al procesar la solicitud')", true);
                }//else

            }//else - no hay datos en blanco

        }

        protected void DeleteRowButton_Click(object sender, GridViewDeleteEventArgs e)
        {
            usuarioSeleccionado = this.gvUsuarios.DataKeys[e.RowIndex].Value.ToString();//email (id) del proveedor por el cual se cargarán y modificarán los datos
            this.tbUsuario.Text = usuarioSeleccionado;
            tbUsuario.Enabled = false;
            this.lblID.Text = usuarioSeleccionado;
            this.usuarioBusiness = new UsuarioBusiness();
            this.usuarios = this.usuarioBusiness.obtenerUsuarios();
            foreach (Usuario usuaririoActual in this.usuarios) //buscar los datos del proveedor seleccionado y mostrarlos en los campos de texto
            {
                if (usuaririoActual.NombreUsuario.Equals(usuarioSeleccionado))//se buscan los datos
                {
                    this.tbNombre.Text = usuaririoActual.Nombre;
                    this.tbTelefono.Text = usuaririoActual.Telefono;
                    this.tbPass.Text = usuaririoActual.Contrsena;
                    this.tbApellidos.Text = usuaririoActual.Apellido;
                    this.tbEmail.Text = usuaririoActual.Correo;
                }//if 
            }//foreach

        }//DeleteRowButton_Click

    }//class
}//namespace