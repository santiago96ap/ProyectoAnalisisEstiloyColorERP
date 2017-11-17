using System;
using System.Collections.Generic;
using System.Web.Configuration;
using System.Linq;
using System.Web;
using DOMAIN;
using DATA;

namespace BUSINESS{
    public class ClienteBusiness{
        /// <summary>
        /// Clase encargadad de las reglas de negocios para acceder a la base de datos
        /// </summary>

        //Atributos
        private ClienteData clienteData;
        private string stringConeccion;

        /// <summary>
        /// Método constructor de la clase
        /// </summary>
        public ClienteBusiness(){
            this.stringConeccion = WebConfigurationManager.ConnectionStrings["BaseDatos"].ToString();
            this.clienteData = new ClienteData(this.stringConeccion);
        }//constructor

        /// <summary>
        /// Método dedicado a insertar un cliente nuevo en el sistema
        /// </summary>
        /// <param name="cliente">Cliente creado por un usuario</param>
        /// <returns>1 si se pudo completar la acción o 0 si hubo un error</returns>
        public Boolean insertarCliente(Cliente cliente){
            return this.clienteData.insertarCliente(cliente);
        }//insertarCliente

        /// <summary>
        /// Método que actualiza los datos de un cliente en la base de datos
        /// </summary>
        /// <param name="cliente">Cliente original</param>
        /// <param name="clienteV">Cliente con datos modificados</param>
        /// <returns>1 si se pudo completar la acción o 0 si hubo un error</returns>
        public Boolean actualizarCliente(Cliente cliente, String clienteV){
            return this.clienteData.actualizarCliente(cliente, clienteV);
        }//actualizarCliente

        /// <summary>
        /// Método encargado de obtener todos los clientes existentes en la base de datos
        /// </summary>
        /// <returns>Lista con todos los clientes existentes en la base de datos</returns>
        public LinkedList<Cliente> obtenerClientes(){
            return this.clienteData.obtenerClientes();
        }//obtenerClientes

        /// <summary>
        /// Método para obtener un cliente en específico 
        /// </summary>
        /// <param name="cliente">Cliente al que se quiere conocer los datos</param>
        /// <returns>Cliente en la base de datos</returns>
        public Cliente obtenerCliente(Cliente cliente){
            return this.clienteData.obtenerCliente(cliente);
        }//obtenerCliente
    }//class
}//namespace