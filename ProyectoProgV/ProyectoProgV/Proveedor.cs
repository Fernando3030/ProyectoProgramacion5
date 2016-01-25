using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgV
{
    class Proveedor
    {
        string codigo;

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        string ruc;

        public string Ruc
        {
            get { return ruc; }
            set { ruc = value; }
        }
        string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        string telefono;

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        string ciudad;

        public string Ciudad
        {
            get { return ciudad; }
            set { ciudad = value; }
        }
        bool estado;

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public Proveedor(string codigo, string nombre, string ruc, string direccion, string telefono, string email, string ciudad, bool estado)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.ruc = ruc;
            this.direccion = direccion;
            this.telefono = telefono;
            this.email = email;
            this.ciudad = ciudad;
            this.estado = estado;

        }

    }
}
