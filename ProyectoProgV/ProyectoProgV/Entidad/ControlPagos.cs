using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgV.Entidad
{
    class ControlPagos
    {
        string numFact;

        public string NumFact
        {
            get { return numFact; }
            set { numFact = value; }
        }
        string codigoProve;

        public string CodigoProve
        {
            get { return codigoProve; }
            set { codigoProve = value; }
        }
        string fecha;

        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        int cantidad;

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        decimal total;

        public decimal Total
        {
            get { return total; }
            set { total = value; }
        }
        string urlFoto;

        public string UrlFoto
        {
            get { return urlFoto; }
            set { urlFoto = value; }
        }


        public ControlPagos(string numF, string codigoP, string fecha, int cantidad, decimal total, string url)
        {
            this.numFact = numF;
            this.codigoProve = codigoP;
            this.fecha = fecha;
            this.cantidad = cantidad;
            this.total = total;
            this.urlFoto = url;
        }


    }
}
