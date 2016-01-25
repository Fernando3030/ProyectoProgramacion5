using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgV.Entidad
{
    public class Movimiento
    {
        string codigoM;

        public string CodigoM
        {
            get { return codigoM; }
            set { codigoM = value; }
        }
        string codigoP;

        public string CodigoP
        {
            get { return codigoP; }
            set { codigoP = value; }
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
        decimal precioC;

        public decimal PrecioC
        {
            get { return precioC; }
            set { precioC = value; }
        }
        decimal precioV;

        public decimal PrecioV
        {
            get { return precioV; }
            set { precioV = value; }
        }

        public Movimiento(string codigoM, string codigoP, int cantidad, string fecha, decimal precioC, decimal precioV )
        {
            this.codigoM = codigoM;
            this.codigoP = codigoP;
            this.cantidad = cantidad;
            this.fecha = fecha;
            this.precioC = precioC;
            this.precioV = precioV;
        }



    }
}
