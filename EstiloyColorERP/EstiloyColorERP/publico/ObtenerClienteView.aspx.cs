using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DOMAIN;
using BUSINESS;

namespace EstiloyColorERP{
    public partial class ObtenerCliente : System.Web.UI.Page{

        private ClienteBusiness clientebusiness;
        private LinkedList<Cliente> clientes;
        protected void Page_Load(object sender, EventArgs e){
            this.clientebusiness = new ClienteBusiness();
            this.clientes = this.clientebusiness.obtenerClientes();
            DataTable table = new DataTable("Clientes");
            table.Columns.Add(new DataColumn("Nombre", typeof(string)));
            table.Columns.Add(new DataColumn("Teléfono", typeof(string)));
            table.Columns.Add(new DataColumn("Dirección", typeof(string)));
            table.Columns.Add(new DataColumn("Correo", typeof(string)));
            foreach (Cliente clienteActual in this.clientes)
            {
                DataRow row = table.NewRow();
                row["Nombre"] = clienteActual.Nombre +" "+ clienteActual.Apellidos;
                row["Teléfono"] = clienteActual.Telefono;
                row["Dirección"] = clienteActual.Direccion;
                row["Correo"] = clienteActual.Correo;
                table.Rows.Add(row);
            }//foreach
            this.gvClientes.DataSource = table;
            this.gvClientes.DataBind();
        }//cargar el modulo de obtener
    }//class
}//namespace