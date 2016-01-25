using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgV
{
    class DetalleFactura
    {
        string codProducto;

        public string CodProducto
        {
            get { return codProducto; }
            set { codProducto = value; }
        }
        int cantidad;

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        decimal precio;

        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        decimal total;

        public decimal Total
        {
            get { return total; }
            set { total = value; }
        }

        public DetalleFactura(string codP, int cantidad, decimal precio, decimal total)
        {
            this.codProducto = codP;
            this.cantidad = cantidad;
            this.precio = precio;
            this.total = total;
        }
        
    }
}
