using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoProgV
{
    public partial class VentanaPrincipal : MetroFramework.Forms.MetroForm
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuClientes_Click(object sender, EventArgs e)
        {
            
            RegistroClientes clientes = new RegistroClientes();
            clientes.Show();
            this.Close();
        }

        private void menuProveedores_Click(object sender, EventArgs e)
        {
            RegistroProveedores proveedor = new RegistroProveedores();
            proveedor.Show();
            this.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "Seguro que desea salir?", "Mensaje de Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            this.Close();
            Login ventana = new Login();
            ventana.Show();
        }

        private void registrarMercaderiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            RegistrarProducto producto = new RegistrarProducto();
            producto.Show();
        }

        private void registrarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            RegistrarCategoria categoria = new RegistrarCategoria();
            categoria.Show();
        }

        private void entradaDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            EntradaProductos entrada = new EntradaProductos();
      
            entrada.Show();
           
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            ReporteProveedores provee = new ReporteProveedores();
            provee.Show();
        }

        private void facturaProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            FacturaProveedores facturaP = new FacturaProveedores();
            facturaP.Show();
        }

        private void facturaClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            FacturaCliente cliente = new FacturaCliente();
            cliente.Show();
        }
    }
}
