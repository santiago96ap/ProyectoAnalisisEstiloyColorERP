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
    public partial class MostrarUsuario : System.Web.UI.Page
    {
        UsuarioBusiness usuarioBusiness;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }//pageload

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            String mostrar = ddlRol.SelectedItem.Value.ToString();//item seleccionado en el ddl para que se haga un criterio de visualización
            
            this.usuarioBusiness = new UsuarioBusiness();
            LinkedList<Usuario> usuarios;
            usuarios = this.usuarioBusiness.obtenerUsuarios();
            DataTable table = new DataTable("Usarios");
            table.Columns.Add(new DataColumn("ID", typeof(string)));
            table.Columns.Add(new DataColumn("Nombre", typeof(string)));
            table.Columns.Add(new DataColumn("Rol", typeof(string)));
            table.Columns.Add(new DataColumn("Correo", typeof(string)));
            table.Columns.Add(new DataColumn("Teléfono", typeof(string)));
            foreach (Usuario usuarioActual in usuarios)
                
            {
                DataRow row = table.NewRow();
                if (mostrar.Equals("todos"))
                {//si seleccionan todos los usuarios en el sistema
                    

                    row["ID"] = usuarioActual.Id;
                    row["Nombre"] = usuarioActual.Nombre;
                    row["Rol"] = usuarioActual.Rol;
                    row["Correo"] = usuarioActual.Correo;
                    row["Teléfono"] = usuarioActual.Telefono;

                    table.Rows.Add(row);
                }
                else { //si no se seleccionan todos los usuarios
                if (mostrar.Equals(usuarioActual.Rol))                        
                    {

                        row["ID"] = usuarioActual.Id;
                        row["Nombre"] = usuarioActual.Nombre;
                        row["Rol"] = usuarioActual.Rol;
                        row["Correo"] = usuarioActual.Correo;
                        row["Teléfono"] = usuarioActual.Telefono;

                        table.Rows.Add(row);
                    }//if
            }//else
                
            }//foreach
            this.gvUsuarios.DataSource = table;
            this.gvUsuarios.DataBind();

        }//btnBuscar
    }
}