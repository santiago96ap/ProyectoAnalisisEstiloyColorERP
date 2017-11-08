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
    public partial class ActualizarProveedorView : System.Web.UI.Page
    {
        
        private ProveedorBusiness proveedorBusiness;
        private LinkedList<Proveedor> proveedores;
//        private String clienteV;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack){
                cargarInformacion();
               }//if para ver si es la primera vez que se carga el modulo
            }//pageload

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(this.tbNombre.Text) || String.IsNullOrWhiteSpace(this.tbDireccion.Text) || String.IsNullOrWhiteSpace(this.tbTelefono.Text) || String.IsNullOrWhiteSpace(this.tbDireccion.Text) || String.IsNullOrWhiteSpace(this.tbEmail.Text))
            {//si existe un tb en blanco se indica al usuario y no se aplica ningún cambio
                ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.error('Error en los datos ingresados')", true);
            }
            else
            {   
                this.proveedorBusiness = new ProveedorBusiness();

                Proveedor proveedorNuevo = new Proveedor(tbNombre.Text.ToString(), tbTelefono.Text.ToString(), tbDireccion.Text.ToString(), tbEmail.Text.ToString());

                bool respuesta = this.proveedorBusiness.actualizarProveedor(proveedorNuevo);

                if (respuesta)// Si se actualiza el usuario se recargan los datos y se dejan los tb en blanco
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.success('El proveedor se actualizó exitosamente')", true);
                    //dejar los campos de texto en blanco
                    this.tbEmail.Text = " ";
                    this.tbDireccion.Text = " ";
                    this.tbNombre.Text = " ";
                    this.tbTelefono.Text = " ";

                    cargarInformacion();//recargar el gridview
                }//if
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.error('Se ha producido un error al procesar la solicitud')", true);
                }//else
                
            }//else - no hay datos en blanco

        }//btnActualizar

        protected void cargarInformacion()
        {
            this.proveedorBusiness = new ProveedorBusiness();
            this.proveedores = this.proveedorBusiness.obtenerProveedores();
            DataTable table = new DataTable("Proveedores");

            table.Columns.Add(new DataColumn("Email", typeof(string)));
            table.Columns.Add(new DataColumn("Nombre", typeof(string)));
            table.Columns.Add(new DataColumn("Telefono", typeof(string)));
            table.Columns.Add(new DataColumn("Direccion", typeof(string)));
                        
            
            foreach (Proveedor proveedorActual in this.proveedores)

            {
                DataRow row = table.NewRow();
                
                row["Email"] = proveedorActual.Email;
                row["Nombre"] = proveedorActual.Nombre;
                row["Telefono"] = proveedorActual.Telefono;
                row["Direccion"] = proveedorActual.Direccion;
                
                table.Rows.Add(row);              
            }//foreach
            
            this.gvProveedores.DataSource = table;
            this.gvProveedores.DataBind();
        }//cargarInformacion

        protected void DeleteRowButton_Click(object sender, GridViewDeleteEventArgs e)
        {
            String email = this.gvProveedores.DataKeys[e.RowIndex].Value.ToString();//email (id) del proveedor por el cual se cargarán y modificarán los datos
            this.tbEmail.Enabled = false;
            this.tbEmail.Text = email;

            this.proveedorBusiness = new ProveedorBusiness();
            this.proveedores = this.proveedorBusiness.obtenerProveedores();

            foreach (Proveedor proveedorActual in this.proveedores) //buscar los datos del proveedor seleccionado y mostrarlos en los campos de texto
            {
                if (proveedorActual.Email.Equals(email))//se buscan los datos
                {
                    this.tbNombre.Text = proveedorActual.Nombre;
                    this.tbTelefono.Text = proveedorActual.Telefono;
                    this.tbDireccion.Text = proveedorActual.Direccion;
                }
            }//foreach

            }//btnBuscar_Click
    }//class
}//namespace