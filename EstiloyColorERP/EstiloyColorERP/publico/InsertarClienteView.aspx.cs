using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DOMAIN;
using BUSINESS;

namespace EstiloyColorERP
{
    public partial class InsertarCliente : System.Web.UI.Page
    {
        private ClienteBusiness clienteBusiness;
        protected void Page_Load(object sender, EventArgs e)
        {

        }//Carga el modulo de insertar

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            //clienteBusiness = new ClienteBusiness();
            //Cliente cliente = new Cliente(tbNombre.Text, tbApellidos.Text, tbTelefono.Text, tbDireccion.Text, tbCorreo.Text);
            //clienteBusiness.insertarCliente(cliente);
            lblNombre.Text = tbNombre.Text;
        }
    }
}//namespace