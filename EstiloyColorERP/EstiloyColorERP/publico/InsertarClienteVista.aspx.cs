using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DOMAIN;
using BUSINESS;

namespace EstiloyColorERP{
    public partial class InsertarCliente : System.Web.UI.Page{

        private ClienteBusiness clienteBusiness;//Instacia de las
        protected void Page_Load(object sender, EventArgs e){

        }//Carga el modulo de insertar

        protected void btnInsertar_Click(object sender, EventArgs e){
            if (!String.IsNullOrWhiteSpace(this.tbNombre.Text) || !String.IsNullOrWhiteSpace(this.tbApellidos.Text) || !String.IsNullOrWhiteSpace(this.tbTelefono.Text) || !String.IsNullOrWhiteSpace(this.tbDireccion.Text) || !String.IsNullOrWhiteSpace(this.tbCorreo.Text)){
                this.clienteBusiness = new ClienteBusiness();
                Cliente cliente = new Cliente(this.tbNombre.Text, this.tbApellidos.Text, this.tbTelefono.Text, this.tbDireccion.Text, this.tbCorreo.Text);
                if (this.clienteBusiness.insertarCliente(cliente))
                {
                    this.tbNombre.Text = "";
                    this.tbApellidos.Text = "";
                    this.tbTelefono.Text = "";
                    this.tbDireccion.Text = "";
                    this.tbCorreo.Text = "";
                    ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.success('El cliente se insertó exitosamente')", true);
                }else{
                    ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.error('Se ha producido un error al procesar la solicitud')", true);
                }//if si se actualizo correctamente
            } else {
                ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.error('Error en los datos ingresados')", true);
            }//if validacion
        }//btnInsertar_Click
    }//class
}//namespace