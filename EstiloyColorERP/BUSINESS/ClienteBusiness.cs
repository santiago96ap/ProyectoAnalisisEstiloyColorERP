using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DOMAIN;
using DATA;

namespace BUSINESS
{
    public class ClienteBusiness
    {
        private ClienteData clienteData;

        public ClienteBusiness()
        {
            this.clienteData = new ClienteData();
        }//constructor

        public Boolean insertarCliente(Cliente cliente)
        {
            return this.clienteData.insertarCliente(cliente);
        }//insertarCliente

        public Boolean actualizarCliente(Cliente cliente)
        {
            return this.clienteData.actualizarCliente(cliente);
        }//actualizarCliente

        public LinkedList<Cliente> obtenerClientes()
        {
            return this.clienteData.obtenerClientes();
        }//obtenerClientes

        public Venta obtenerCliente(Cliente cliente)
        {
            return this.clienteData.obtenerCliente(cliente);
        }//obtenerCliente

    }//class
}//namespace