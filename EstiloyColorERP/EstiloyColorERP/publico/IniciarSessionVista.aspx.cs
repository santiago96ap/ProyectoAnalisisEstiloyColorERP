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
    public partial class IniciarSessionView : System.Web.UI.Page
    {
        private UsuarioBusiness usuarioBusiness;
        private LinkedList<Usuario> usuarios;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Session["login"].Equals("N"))
            {
                Session["login"] = "N";
                Session["usuario"] = "N";
            }//if cerrar sesion
        }//Page_Load

        protected void btnIniciarSession_Click(object sender, EventArgs e)
        {
            this.usuarioBusiness = new UsuarioBusiness();
            this.usuarios = this.usuarioBusiness.obtenerUsuarios();
            foreach (Usuario usuarioActual in usuarios)
            {
                if (usuarioActual.Correo == this.tbCorreo.Text && usuarioActual.Contrsena == this.tbContrasenna.Text)
                {
                    Session["login"] = usuarioActual.Rol;
                    Session["usuario"] = usuarioActual.NombreUsuario;
                    string url = HttpContext.Current.Request.Url.AbsoluteUri.Replace(HttpContext.Current.Request.Url.AbsolutePath, "");
                    Response.BufferOutput = true;
                    Response.Redirect(url + "/publico/Default.aspx");
                }//if llenar datos
            }//foreach
        }//btnIniciarSession_Click
    }//class
}//namespace