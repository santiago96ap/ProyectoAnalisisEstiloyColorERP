using BUSINESS;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EstiloyColorERP.publico
{
    
	public partial class InsertarProductoView : System.Web.UI.Page
	{
        private ProductoBusiness productoBusiness = new ProductoBusiness();
        private CategoriaBusiness categoriaBusiness = new CategoriaBusiness();
        private ProveedorBusiness proveedorBusiness = new ProveedorBusiness();
        private LinkedList<Categoria> categorias;
        private LinkedList<Proveedor> proveedores;
        protected void Page_Load(object sender, EventArgs e)
		{
            if (this.ddCategoria != null && this.ddlProveedor != null)
            {
                if (!IsPostBack)
                {
                    cargarListaCategorias();
                    cargarListaProveedores();
                   
                }//if para ver si es la primera vez que se carga el modula
            }//if para ver si el listbox esta vacio

        }//page_load

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            if (this.productoBusiness.insertarProducto(new Producto(int.Parse(tbCodigo.Text), tbNombreP.Text, tbDescrpciom.Text, float.Parse(tbCosto.Text), float.Parse(tbPrecio.Text), int.Parse(tbCant.Text), ddlProveedor.SelectedItem.Value, int.Parse(ddCategoria.SelectedItem.Value)))== true){

                tbCodigo.Text = " ";
                tbNombreP.Text = " ";
                tbDescrpciom.Text = " ";
                tbCosto.Text = " ";
                tbPrecio.Text = " ";
                tbCant.Text = " ";
                ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.success('¡Se ha insertado correctamente!')", true);
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alertify", "alertify.error('¡Ha ocurrido un error!')", true);
            }//else-if


        }//btnInsertar_Click

        private void cargarListaProveedores()
        {
            this.proveedores = this.proveedorBusiness.obtenerProveedores();
            foreach (Proveedor pActual in this.proveedores)
            {
                this.ddlProveedor.Items.Add(new ListItem(pActual.Nombre, pActual.Email));
            }//llenar el listbox con los proveedores de la DB

        }//cargarListaProveedores

        private void cargarListaCategorias()
        {
            this.categorias = this.categoriaBusiness.obtenerCategorias();
            foreach (Categoria cActual in this.categorias)
            {
                this.ddCategoria.Items.Add(new ListItem(cActual.Nombre, cActual.Codigo.ToString()));
            }//llenar el listbox con los categorias de la DB

        }//cargarListaCategorias


    }//class
}//namespace