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

        }//btnActualizar

        protected void cargarInformacion()
        {
            this.proveedorBusiness = new ProveedorBusiness();
            LinkedList<Proveedor> proveedores;
            proveedores = this.proveedorBusiness.obtenerProveedores();
            DataTable table = new DataTable("Proveedores");

            table.Columns.Add(new DataColumn("Email", typeof(string)));
            table.Columns.Add(new DataColumn("Nombre", typeof(string)));
            table.Columns.Add(new DataColumn("Telefono", typeof(string)));
            table.Columns.Add(new DataColumn("Direccion", typeof(string)));
            
            foreach (Proveedor proveedorActual in proveedores)

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
            this.tbDireccion.Text = this.gvProveedores.DataKeys[e.RowIndex].Value.ToString();
        }//btnBuscar_Click
    }//class
}//namespace