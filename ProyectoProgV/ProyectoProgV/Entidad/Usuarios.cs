using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgV
{
    class Usuarios
    {
        private string codigo;
        bool estado;

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        private string cedula;

        public string Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private string apellido;

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        private string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        private string telefono;

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private string user;

        public string User
        {
            get { return user; }
            set { user = value; }
        }
        private string contra;

        public string Contra
        {
            get { return contra; }
            set { contra = value; }
        }
        private string tipoEmpleado;

        public string TipoEmpleado
        {
            get { return tipoEmpleado; }
            set { tipoEmpleado = value; }
        }
        private string url;

        public string Url
        {
            get { return url; }
            set { url = value; }
        }
        private string codigoCiudad;

        public string CodigoCiudad
        {
            get { return codigoCiudad; }
            set { codigoCiudad = value; }
        }

       

        public Usuarios (string codigo, string cedula, string nombre, string apellido, string direccion, string telefono, string email, string user, string contra, string tipoEmpleado, string url, string codigoC, bool estado)
    {
            this.codigo= codigo;
            this.nombre= nombre;
            this.cedula= cedula;
            this.apellido = apellido;
            this.direccion = direccion;
            this.telefono = telefono;
            this.email = email;
            this.user = user;
            this.contra = contra;
            this.tipoEmpleado = tipoEmpleado;
            this.url = url;
            this.codigoCiudad = codigoC;
            this.estado = estado;

    }

       

    }
}
