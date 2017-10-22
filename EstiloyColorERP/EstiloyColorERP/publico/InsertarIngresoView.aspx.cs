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
    public partial class InsertarIngresoView : System.Web.UI.Page
    {
        private IngresoBusiness ib;
        private String connString = WebConfigurationManager.ConnectionStrings["baseDatos"].ToString();

        protected void Page_Load(object sender, EventArgs e)
        {
            this.ib = new IngresoBusiness(this.connString);
        }//Page_Load
        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            this.ib.insertarIngreso(new Ingreso(this.tbFecha.Text, this.tbHora.Text, this.tbConcepto.Text, float.Parse(this.tbTotal.Text), "usuario"));
        }//btnInsertar_Click1

        protected void btnInsertar_Click1(object sender, EventArgs e)
        {
            this.ib.insertarIngreso(new Ingreso(this.tbFecha.Text, this.tbHora.Text, this.tbConcepto.Text, float.Parse(this.tbTotal.Text), "usuario"));

        }
    }//class
}//namespace