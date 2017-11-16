using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOMAIN
{
    public class Cliente
    {
        /// <summary>
        /// La clase más importante del sistema. Representa a los clientes físicos de la empresa, se identifícan por el número de télefono
        /// </summary>

        private String id;
        private String nombre;
        private String apellidos;
        private String telefono;
        private String direccion;
        private String correo;

        public Cliente()
        {
            this.id = "";
            this.nombre = "";
            this.apellidos = "";
            this.telefono = "";
            this.direccion = "";
            this.correo = "";
        }//constructor

        public Cliente(String id, String nombre, String apellidos, String telefono, String direccion, String correo)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.telefono = telefono;
            this.direccion = direccion;
            this.correo = correo;
        }//constructor sobrecargado

        public Cliente(String nombre, String apellidos, String telefono, String direccion, String correo)
        {
            this.id = "";
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.telefono = telefono;
            this.direccion = direccion;
            this.correo = correo;
        }//constructor sobrecargado

        public string Id
        {
            get
            {
                return id;
            }//get id

            set
            {
                id = value;
            }//set id
        }//Id

        public string Nombre
        {
            get
            {
                return nombre;
            }//get nombre

            set
            {
                nombre = value;
            }//set nombre
        }//Nombre

        public string Apellidos
        {
            get
            {
                return apellidos;
            }//get apellidos

            set
            {
                apellidos = value;
            }//set apellidos
        }//Apellidos

        public string Telefono
        {
            get
            {
                return telefono;
            }//get telefono

            set
            {
                telefono = value;
            }//set telefono
        }//Telefono

        public string Direccion
        {
            get
            {
                return direccion;
            }//get direccion

            set
            {
                direccion = value;
            }//set direccion
        }//Direccion

        public string Correo
        {
            get
            {
                return correo;
            }//get correo

            set
            {
                correo = value;
            }//set correo
        }//Correo
    }//class
}//namespace