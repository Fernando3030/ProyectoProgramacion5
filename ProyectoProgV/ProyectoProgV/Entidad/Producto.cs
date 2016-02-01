using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgV
{
    class Producto
    {
        string codigo;

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        string categoria;

        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }
        string proveedor;

        public string Proveedor
        {
            get { return proveedor; }
            set { proveedor = value; }
        }
        string producto;

        public string Producto1
        {
            get { return producto; }
            set { producto = value; }
        }
        string fechaV;

        public string FechaV
        {
            get { return fechaV; }
            set { fechaV = value; }
        }
        int stock;

        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }
        double precioC;

        public double PrecioC
        {
            get { return precioC; }
            set { precioC = value; }
        }




        double precioV;

        public double PrecioV
        {
            get { return precioV; }
            set { precioV = value; }
        }

        

        

        bool estado;

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        

        public Producto(string codigo, string categoria, string proveedor, string producto, string fechaV, int stock, double precioC, double precioV, bool estado)
        {
            this.codigo = codigo;
            this.categoria = categoria;
            this.proveedor = proveedor;
            this.producto = producto;
            this.stock = stock;
            this.fechaV = fechaV;
            this.precioC = precioC;
            this.precioV = precioV;
            this.estado = estado;
           

        }
    }
}
