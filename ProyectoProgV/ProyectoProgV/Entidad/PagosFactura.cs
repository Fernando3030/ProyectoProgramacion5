using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgV.Entidad
{
    class PagosFactura
    {

        string codigo;

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        string numFactP;

        public string NumFactP
        {
            get { return numFactP; }
            set { numFactP = value; }
        }
        string fecha;

        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        int nroCuenta;

        public int NroCuenta
        {
            get { return nroCuenta; }
            set { nroCuenta = value; }
        }
        decimal monto;

        public decimal Monto
        {
            get { return monto; }
            set { monto = value; }
        }
        string banco;

        public string Banco
        {
            get { return banco; }
            set { banco = value; }
        }


        public PagosFactura (string codigo, string numF, string fecha, int nroCuenta, decimal monto, string banco)
        {
            this.codigo = codigo;
            this.numFactP = numF;
            this.fecha = fecha;
            this.nroCuenta = nroCuenta;
            this.monto = monto;
            this.banco = banco;
        }
    }
}
