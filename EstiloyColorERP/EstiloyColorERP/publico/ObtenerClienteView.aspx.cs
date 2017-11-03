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
            //cargar clientes en dropdown
            this.clientebusiness = new ClienteBusiness();
            this.clientes = this.clientebusiness.obtenerClientes();
            if (this.ddlClientes != null)
            {
                if (!IsPostBack)
                {
                    this.ddlClientes.Items.Add("---Clientes---");
                    foreach (Cliente clienteActual in this.clientes)
                    {
                        this.ddlClientes.Items.Add(new ListItem(clienteActual.Nombre + " " + clienteActual.Apellidos, clienteActual.Telefono));
                    }//llenar el listbox con los clientes de la DB
                    this.btnExportarExcel.Visible = false;
                    this.btnExportarPdf.Visible = false;
                }//if para ver si es la primera vez que se carga el modulo
            }//if para ver si el listbox esta vacio
        }//cargar el modulo de obtener

        protected void btnBuscar_Click(object sender, EventArgs e){
            if (!String.IsNullOrWhiteSpace(this.tbBuscar.Text))
            {
                cargarTabla(this.tbBuscar.Text);
            }else if (!this.ddlClientes.SelectedItem.Text.Equals("---Clientes---")){
                cargarTabla(this.ddlClientes.SelectedItem.Value);
            }else {
                cargarTodos();
            }//opciones de busqueda
            this.tbBuscar.Text = "";
            this.ddlClientes.SelectedIndex = 0;
            this.btnExportarExcel.Visible = true;
            this.btnExportarPdf.Visible = true;
        }//btnBuscar_Click

        protected void cargarTabla(String cliente){
            DataTable table = new DataTable("Clientes");
            table.Columns.Add(new DataColumn("Nombre", typeof(string)));
            table.Columns.Add(new DataColumn("Teléfono", typeof(string)));
            table.Columns.Add(new DataColumn("Dirección", typeof(string)));
            table.Columns.Add(new DataColumn("Correo", typeof(string)));
            foreach (Cliente clienteActual in this.clientes)
            {
                if (cliente.Equals(clienteActual.Telefono)){
                    DataRow row = table.NewRow();
                    row["Nombre"] = clienteActual.Nombre + " " + clienteActual.Apellidos;
                    row["Teléfono"] = clienteActual.Telefono;
                    row["Dirección"] = clienteActual.Direccion;
                    row["Correo"] = clienteActual.Correo;
                    table.Rows.Add(row);
                }//if para mostrar el cliente especifico
            }//foreach para recorrer los clientes que estan en la DB
            this.gvClientes.DataSource = table;
            this.gvClientes.DataBind();
        }//cargarTabla

        protected void cargarTodos()
        {
            DataTable table = new DataTable("Clientes");
            table.Columns.Add(new DataColumn("Nombre", typeof(string)));
            table.Columns.Add(new DataColumn("Teléfono", typeof(string)));
            table.Columns.Add(new DataColumn("Dirección", typeof(string)));
            table.Columns.Add(new DataColumn("Correo", typeof(string)));
            foreach (Cliente clienteActual in this.clientes)
            {
                    DataRow row = table.NewRow();
                    row["Nombre"] = clienteActual.Nombre + " " + clienteActual.Apellidos;
                    row["Teléfono"] = clienteActual.Telefono;
                    row["Dirección"] = clienteActual.Direccion;
                    row["Correo"] = clienteActual.Correo;
                    table.Rows.Add(row);
            }//foreach para recorrer los clientes que estan en la DB
            this.gvClientes.DataSource = table;
            this.gvClientes.DataBind();
        }//cargarTodos

        protected void btnExportarExcel_Click(object sender, ImageClickEventArgs e)
        {

        }//btnExportarExcel_Click

        protected void btnExportarPdf_Click(object sender, ImageClickEventArgs e)
        {

        }//btnExportarPdf_Click
    }//class
}//namespace