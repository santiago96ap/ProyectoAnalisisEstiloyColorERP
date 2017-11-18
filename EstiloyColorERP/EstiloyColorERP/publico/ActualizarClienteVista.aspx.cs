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
        private String clienteV;
        protected void Page_Load(object sender, EventArgs e){
            this.clienteBusiness = new ClienteBusiness();
            this.clientes = this.clienteBusiness.obtenerClientes();
            if (this.ddlClientes != null){
                if (!IsPostBack){
                    cargarClientes();
                    deshabilitarModulo();
                }//if para ver si es la primera vez que se carga el modulo
            }//if para ver si el listbox esta vacio
        }//cargar el modulo de actualizar

        /// <summary>
        /// Este método busca la información del cliente y la muestra en el gridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        protected void btnBuscar_Click(object sender, EventArgs e){
            if (!String.IsNullOrWhiteSpace(this.tbBuscar.Text)){
                foreach (Cliente clienteActual in this.clientes){
                    if (clienteActual.Telefono.Equals(this.tbBuscar.Text)){
                        this.tbNombre.Text = clienteActual.Nombre;
                        this.tbApellidos.Text = clienteActual.Apellidos;
                        this.tbTelefono.Text = clienteActual.Telefono;
                        this.tbDireccion.Text = clienteActual.Direccion;
                        this.tbCorreo.Text = clienteActual.Correo;
                        this.clienteV = this.tbBuscar.Text;
                    }//if para ver si se encontro el cliente
                }//buscar el cliente a actualizar
                if (String.IsNullOrWhiteSpace(this.tbNombre.Text))
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.error('El cliente no existe en el sistema')", true);
                }
                else
                {
                    habilitarModulo();
                }//validar si se encontro el cliente
                
            }
            else if (!this.ddlClientes.SelectedItem.Text.Equals("---Clientes---")){
                foreach (Cliente clienteActual in this.clientes){
                    if (clienteActual.Telefono.Equals(this.ddlClientes.SelectedItem.Value)){
                        this.tbNombre.Text = clienteActual.Nombre;
                        this.tbApellidos.Text = clienteActual.Apellidos;
                        this.tbTelefono.Text = clienteActual.Telefono;
                        this.tbDireccion.Text = clienteActual.Direccion;
                        this.tbCorreo.Text = clienteActual.Correo;
                        this.clienteV = this.ddlClientes.SelectedItem.Value;
                    }//if para ver si se encontro el cliente
                    habilitarModulo();
                }//buscar el cliente a actualizar
            }else{
                ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.error('Debe indicar el cliente')", true);
            }//opciones de busqueda
        }//btnBuscar_Click

        /// <summary>
        /// Este método actualiza los datos necesarios que se encuentran en el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        protected void btnInsertar_Click(object sender, EventArgs e){
            if (!String.IsNullOrWhiteSpace(this.tbBuscar.Text)){
                this.clienteV = this.tbBuscar.Text;
            }
            else if (!this.ddlClientes.SelectedItem.Text.Equals("---Clientes---")){
                        this.clienteV = this.ddlClientes.SelectedItem.Value;
            }//if recuperar el cliente viejo
            if (!String.IsNullOrWhiteSpace(this.tbNombre.Text) && !String.IsNullOrWhiteSpace(this.tbApellidos.Text) && !String.IsNullOrWhiteSpace(this.tbTelefono.Text) && !String.IsNullOrWhiteSpace(this.tbDireccion.Text) && !String.IsNullOrWhiteSpace(this.tbCorreo.Text)){
                Cliente cliente = new Cliente(this.tbNombre.Text, this.tbApellidos.Text, this.tbTelefono.Text, this.tbDireccion.Text, this.tbCorreo.Text);
                if (this.clienteBusiness.actualizarCliente(cliente, this.clienteV)){
                    this.tbNombre.Text = "";
                    this.tbApellidos.Text = "";
                    this.tbTelefono.Text = "";
                    this.tbDireccion.Text = "";
                    this.tbCorreo.Text = "";
                    this.tbBuscar.Text = "";
                    this.ddlClientes.SelectedIndex = 0;
                    deshabilitarModulo();
                    cargarClientes();
                    deshabilitarModulo();
                    ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.success('El cliente se actualizó exitosamente')", true);
                }
                else{
                    ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.error('Error en los datos ingresados')", true);
                }//if si se actualizo correctamente
            } else {
                ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.error('Error, campos en blanco')", true);
            }//if validacion
        }//btnInsertar_Click


        /// <summary>
        /// Este método habilita los campos de texto para que puedan ser editables
        /// </summary>

        protected void habilitarModulo(){
            this.tbNombre.Enabled = true;
            this.tbApellidos.Enabled = true;
            this.tbTelefono.Enabled = false;
            this.tbDireccion.Enabled = true;
            this.tbCorreo.Enabled = true;
            this.btnInsertar.Enabled = true;
        }//habilitarModulo


        /// <summary>
        /// Este método desabilita los campos de texto para que no puedan ser editados
        /// </summary>
        protected void deshabilitarModulo()
        {
            this.tbNombre.Enabled = false;
            this.tbApellidos.Enabled = false;
            this.tbTelefono.Enabled = false;
            this.tbDireccion.Enabled = false;
            this.tbCorreo.Enabled = false;
            this.btnInsertar.Enabled = false;
            this.clienteV = "";
        }//deshabilitarModulo

        /// <summary>
        /// Cargan los clientes en lo que es el componente gráfico
        /// </summary>
        protected void cargarClientes(){
            this.clientes = this.clienteBusiness.obtenerClientes();
            this.ddlClientes.Items.Clear();
            this.ddlClientes.Items.Add("---Clientes---");
            foreach (Cliente clienteActual in this.clientes)
            {
                this.ddlClientes.Items.Add(new ListItem(clienteActual.Nombre + " " + clienteActual.Apellidos, clienteActual.Telefono));
            }//llenar el listbox con los clientes de la DB
        }//cargarClientes
    }//class
}//namespace