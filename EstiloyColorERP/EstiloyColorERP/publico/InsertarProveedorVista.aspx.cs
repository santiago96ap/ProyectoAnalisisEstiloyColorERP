using BUSINESS;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EstiloyColorERP.publico
{
    public partial class AgregarProveedorView : System.Web.UI.Page
    {
        private ProveedorBusiness pb = new ProveedorBusiness();
        protected void Page_Load(object sender, EventArgs e)
        {

        }//Page_load
        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            if (this.pb.insertarProveedor(new Proveedor(tbNombre.Text, tbTelefono.Text, TbDireccion.Text, tbEmail.Text,tbPagina.Text)) == true)
            {
                this.tbNombre.Text = " ";
                this.tbTelefono.Text = " ";
                this.TbDireccion.Text = " ";
                this.tbEmail.Text = " ";
                this.tbPagina.Text = " ";
                ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.success('¡Los datos se han  ingresado correctamente!')", true);
            }
            else
            {
                this.tbNombre.Text = " ";
                this.tbTelefono.Text = " ";
                this.TbDireccion.Text = " ";
                this.tbEmail.Text = " ";
                this.tbPagina.Text = " ";
                ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.error('Error en los datos ingresados')", true);
            }//else-if

        }//btnInsertar_Click
    }//class
}//namespace