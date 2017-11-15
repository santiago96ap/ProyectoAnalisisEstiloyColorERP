using BUSINESS;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EstiloyColorERP
{
    public partial class AgendaView : System.Web.UI.Page
    {
        AgendaBusiness ab = new AgendaBusiness();
        ClienteBusiness cb = new ClienteBusiness();
        LinkedList<Cliente> clientes;
        protected void Page_Load(object sender, EventArgs e)
        {
             if (this.ddClientes != null)
             {
                if (!IsPostBack)
                 {
                   cargarListaDeClientes();
                 }//if (!IsPostBack)
             }// if (this.ddTipoUsuario != null)
                   
        }//page_load

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            if (this.ab.insertarAgenda(new Agenda(tbFecha.Text, tbHora.Text, tbActividad.Text, tbDireccion.Text, ddClientes.SelectedItem.Value))== true)
            {
                tbFecha.Text = " ";
                tbHora.Text = " ";
                tbActividad.Text = " ";
                tbDireccion.Text = " ";
                ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.success('¡Se ha insertado correctamente!')", true);
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.error('¡Ha ocurrido un error!')", true);

            }//else-if

        }//btnInsertar_Click
        private void cargarListaDeClientes()
        {
            this.clientes = this.cb.obtenerClientes();
            foreach (Cliente cActual in this.clientes)
            {
                this.ddClientes.Items.Add(new ListItem(cActual.Nombre +" " + cActual.Apellidos, cActual.Telefono));
            }//llenar el listbox con los clientes de la DB
        }//cargarListadeClientes
    }//class
}//namespace