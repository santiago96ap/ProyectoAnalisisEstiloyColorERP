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
    public partial class ObtenerIngresosView : System.Web.UI.Page
    {
        private IngresoBusiness ib = new IngresoBusiness();
        private LinkedList<Ingreso> ingresos;
        protected void Page_Load(object sender, EventArgs e)
        {

        }//Page_Load

        protected void Button1_Click(object sender, EventArgs e)
        {
            this.ingresos = this.ib.obtenerIngreso(TbFechaInicio.Text, TbFechaFinal.Text);
            DataTable table = new DataTable("Tabla1");
            table.Columns.Add(new DataColumn("ID", typeof(int)));
            table.Columns.Add(new DataColumn("Fecha", typeof(string)));
            table.Columns.Add(new DataColumn("Hora", typeof(string)));
            table.Columns.Add(new DataColumn("Concepto", typeof(string)));
            table.Columns.Add(new DataColumn("Monto", typeof(float)));
            table.Columns.Add(new DataColumn("Usuario", typeof(string)));
            foreach (var item in ingresos)
            {
                DataRow row = table.NewRow();
                row["ID"] = item.Id;
                row["Fecha"] = item.Fecha;
                row["Hora"] = item.Hora;
                row["Concepto"] = item.Concepto;
                row["Monto"] = item.Total;
                row["Usuario"] = item.Usuario;
                table.Rows.Add(row);
            }//foreach
            GridView1.DataSource = table;
            GridView1.DataBind();

        }//Button1_Click

        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }
    }//class
}//namespace