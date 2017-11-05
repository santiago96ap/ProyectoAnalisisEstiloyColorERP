using BUSINESS;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EstiloyColorERP.publico
{
    public partial class InsertarUsuario : System.Web.UI.Page
    {
        private UsuarioBusiness ub = new UsuarioBusiness();
        protected void Page_Load(object sender, EventArgs e)
        {
            this.ddTipoUsuario.Items.Add(new ListItem("Administrador", "administrador"));
            this.ddTipoUsuario.Items.Add(new ListItem("Vendedor", "vendedor"));

        }//pageload
        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            if (this.ub.registrarUsuario(new Usuario(tbUsuario.Text, tbNombreP.Text, tbApellidos.Text, tbEmail.Text, ddTipoUsuario.SelectedItem.Value, tbPass.Text, tbTelefono.Text)) == true)
            {
                tbUsuario.Text = " ";
                tbNombreP.Text = " ";
                tbApellidos.Text = " ";
                tbEmail.Text = " ";
                tbPass.Text = " ";
                tbTelefono.Text = " ";
                ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.success('¡Se ha insertado correctamente!')", true);
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.error('¡Ha ocurrido un error!')", true);
            }//else-if


        }//btnInsertar_Click
    }//class
}//namespace