using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgV
{
    class Categoria
    {

        string codigo;

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        string categoria;

        public string Categoria1
        {
            get { return categoria; }
            set { categoria = value; }
        }
        bool estado;

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }


        public Categoria(string codigo, string categoria, bool estado)
        {
            this.codigo = codigo;
            this.categoria = categoria;
            this.estado = estado;
        }


    }
}
