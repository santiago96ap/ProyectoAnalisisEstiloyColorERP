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
    public partial class RegistrarGastoView : System.Web.UI.Page
    {
        private GastoBusiness gb = new GastoBusiness();
        protected void Page_Load(object sender, EventArgs e)
        {

        }//PageLoad
        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            if ( this.gb.insertarGasto(new Gasto(tbFecha.Text, tbHora.Text, tbConcepto.Text, float.Parse(tbTotal.Text), "u","")) == true)
            {
                tbFecha.Text = "";
                tbHora.Text = "";
                tbConcepto.Text = "";
                tbTotal.Text= "";
                ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.success('¡Los datos se han  ingresado correctamente!')", true);
            }
            else
            {   
                ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.error('Error en los datos ingresados')", true);
            }//else-if

        }//btnInsertar_Click
    }//class
}//namespace