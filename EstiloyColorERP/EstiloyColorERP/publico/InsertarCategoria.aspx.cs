using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DOMAIN;
using BUSINESS;

namespace EstiloyColorERP.publico
{
    public partial class InsertarCategoria : System.Web.UI.Page
    {
        private CategoriaBusiness cb = new CategoriaBusiness();
        protected void Page_Load(object sender, EventArgs e)
        {

        }//Page_Load

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            if(this.cb.insertarCategoria(new Categoria(tbNombre.Text))==true)
            {
                this.tbNombre.Text = " ";
                ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.success('¡Los datos se han  ingresado correctamente!')", true);
            }
            else
            {
                this.tbNombre.Text = " ";
                ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.error('Error en los datos ingresados')", true);
            }//else-if

        }//btnInsertar_Click
    }//class
}//namespace