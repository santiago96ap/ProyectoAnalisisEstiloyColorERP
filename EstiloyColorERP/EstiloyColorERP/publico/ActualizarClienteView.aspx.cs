using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DOMAIN;
using BUSINESS;

namespace EstiloyColorERP{
    public partial class ActualizarCliente : System.Web.UI.Page{

        private ClienteBusiness clienteBusiness;
        private LinkedList<Cliente> clientes;
        protected void Page_Load(object sender, EventArgs e){
            this.clienteBusiness = new ClienteBusiness();
            this.clientes = this.clienteBusiness.obtenerClientes();
            if (this.lbClientes != null){
                if (!IsPostBack){
                    this.lbClientes.Items.Add("---Clientes---");
                    foreach (Cliente clienteActual in this.clientes){
                        this.lbClientes.Items.Add(new ListItem(clienteActual.Nombre+" "+ clienteActual.Apellidos, clienteActual.Telefono));
                    }//llenar el listbox con los clientes de la DB
                }//if para ver si es la primera vez que se carga el modula
            }//if para ver si el listbox esta vacio
        }//cargar el modulo de actualizar

        protected void btnBuscar_Click(object sender, EventArgs e){
            if (!String.IsNullOrWhiteSpace(this.tbBuscar.Text)){
                foreach (Cliente clienteActual in this.clientes)
                {
                    if (clienteActual.Telefono.Equals(this.tbBuscar.Text)){
                        this.tbNombre.Text = clienteActual.Nombre;
                        this.tbApellidos.Text = clienteActual.Apellidos;
                        this.tbTelefono.Text = clienteActual.Telefono;
                        this.tbDireccion.Text = clienteActual.Direccion;
                        this.tbCorreo.Text = clienteActual.Correo;
                    }//if para ver si se encontro el cliente
                }//buscar el cliente a actualizar
            }else if (!this.lbClientes.SelectedItem.Text.Equals("---Clientes---")){
                foreach (Cliente clienteActual in this.clientes)
                {
                    if (clienteActual.Telefono.Equals(this.lbClientes.SelectedItem.Value))
                    {
                        this.tbNombre.Text = clienteActual.Nombre;
                        this.tbApellidos.Text = clienteActual.Apellidos;
                        this.tbTelefono.Text = clienteActual.Telefono;
                        this.tbDireccion.Text = clienteActual.Direccion;
                        this.tbCorreo.Text = clienteActual.Correo;
                    }//if para ver si se encontro el cliente
                }//buscar el cliente a actualizar
            }else{
                //mensaje de que tiene que seleccionar algo del listbox o ingreasar en el textbox
            }//opciones de busqueda
        }//btnBuscar_Click

        protected void btnInsertar_Click(object sender, EventArgs e){
            if (!String.IsNullOrWhiteSpace(this.tbNombre.Text) || !String.IsNullOrWhiteSpace(this.tbApellidos.Text) || !String.IsNullOrWhiteSpace(this.tbTelefono.Text) || !String.IsNullOrWhiteSpace(this.tbDireccion.Text) || !String.IsNullOrWhiteSpace(this.tbCorreo.Text)){
                Cliente cliente = new Cliente(this.tbNombre.Text, this.tbApellidos.Text, this.tbTelefono.Text, this.tbDireccion.Text, this.tbCorreo.Text);
                this.clienteBusiness.actualizarCliente(cliente);
                this.tbNombre.Text = "";
                this.tbApellidos.Text = "";
                this.tbTelefono.Text = "";
                this.tbDireccion.Text = "";
                this.tbCorreo.Text = "";
                this.tbBuscar.Text = "";
                this.lbClientes.SelectedIndex = 0;
                //mensaje de exito
            }
            else {
                //mensaje de error
            }//if validacion
        }//btnInsertar_Click
    }//class
}//namespace