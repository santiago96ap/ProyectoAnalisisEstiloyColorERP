using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DOMAIN;

namespace DATA
{
    public class ClienteData
    {

        private String stringConeccion;

        public ClienteData(string stringConeccion)
        {
            this.stringConeccion = stringConeccion;
        }//constructor

        public Boolean insertarCliente(Cliente cliente)
        {
            return false;
        }//insertarCliente

        public Boolean actualizarCliente(Cliente cliente)
        {
            return false;
        }//actualizarCliente

        public LinkedList<Cliente> obtenerClientes()
        {
            return null;
        }//obtenerClientes

        public Cliente obtenerCliente(Cliente cliente)
        {
            return null;
        }//obtenerCliente

    }//class
}//namespace