﻿using BUSINESS;
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
    
        protected void Page_Load(object sender, EventArgs e)
        {
            this.ib = new IngresoBusiness();
        }//Page_Load
        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            this.ib.insertarIngreso(new Ingreso(this.tbFecha.Text, this.tbHora.Text, this.tbConcepto.Text, float.Parse(this.tbTotal.Text), "usuario"));
        }//btnInsertar_Click
    }//class
}//namespace