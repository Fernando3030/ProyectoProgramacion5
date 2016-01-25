using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgV
{
    class Ciudad
    {
        string codigo;

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        string ciud;

        public string Ciud
        {
            get { return ciud; }
            set { ciud = value; }
        }

        public Ciudad(string codigo, string ciudad)
        {
            this.codigo = codigo;
            this.ciud = ciudad;
        }
    }
}
