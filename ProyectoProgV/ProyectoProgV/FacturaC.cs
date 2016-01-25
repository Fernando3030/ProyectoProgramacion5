using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgV
{
    class FacturaC
    {
        string numF;

        public string NumF
        {
            get { return numF; }
            set { numF = value; }
        }
        string cedulaC;

        public string CedulaC
        {
            get { return cedulaC; }
            set { cedulaC = value; }
        }
        string cedulaE;

        public string CedulaE
        {
            get { return cedulaE; }
            set { cedulaE = value; }
        }
        string fecha;

        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        decimal subTotal;

        public decimal SubTotal
        {
            get { return subTotal; }
            set { subTotal = value; }
        }
        decimal iva;

        public decimal Iva
        {
            get { return iva; }
            set { iva = value; }
        }
        decimal total;

        public decimal Total
        {
            get { return total; }
            set { total = value; }
        }

        bool anulado;

        public bool Anulado
        {
            get { return anulado; }
            set { anulado = value; }
        }

        public FacturaC(string numF, string cedulaC, string cedulaE, string fecha, decimal subT, decimal iva, decimal total, bool anulado)
        {
            this.numF = numF;
            this.cedulaC = cedulaC;
            this.cedulaE = cedulaE;
            this.fecha= fecha;
            this.subTotal = subT;
            this.iva = iva;
            this.total = total;
            this.anulado = anulado;
        }

    }
}
