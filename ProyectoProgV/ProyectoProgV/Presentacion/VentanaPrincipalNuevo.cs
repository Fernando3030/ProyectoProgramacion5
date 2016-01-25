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

    public partial class VentanaPrincipalNuevo : DevComponents.DotNetBar.Office2007RibbonForm
    {
        int a = 0;
        int w = 0;
        DialogResult resultado;
        public VentanaPrincipalNuevo()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            this.Close();
            RegistroClientes clientes = new RegistroClientes();
            clientes.Show();

        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            this.Close();
            RegistroProveedores proveedores = new RegistroProveedores();
            proveedores.Show();
        }

        private void menuMercaderia_Click(object sender, EventArgs e)
        {

        }

        private void btnFactProvee_Click(object sender, EventArgs e)
        {
            this.Close();
            FacturaProveedores factP = new FacturaProveedores();
            factP.Show();
        }

        private void btnFactCliente_Click(object sender, EventArgs e)
        {
            this.Close();
            FacturaCliente factC = new FacturaCliente();
            factC.Show();
        }

        private void VentanaPrincipalNuevo_Load(object sender, EventArgs e)
        {
            if (Login.roles == 1) // el 2 indica que se trata de una secretaria
            {
                
                btnFactCliente.Enabled = Login.Activo;
                btnCliente.Enabled = Login.Activo;
                
            }

            if(Login.roles==2) // el 2 indica que se trata de un trabajador
            {
                menuReportes.Enabled = Login.Activo;
                btnFactProvee.Enabled = Login.Activo;
                menuMercaderia.Enabled = Login.Activo;
                btnProveedores.Enabled = Login.Activo;
            }
          
        }

       

       

        private void btnMenu_Click(object sender, EventArgs e)
        {

           
            w = panelMenu.Width;
            for (int i = panelMenu.Width; i < w + 95; i++ )
            {
                panelMenu.Width = i;
                panelMenu.Height = i;
                a = i;


            }
            btnAbrir.Enabled = false;
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {

          //  for (int i = a; i > w; i--)
           // {
                panelMenu.Width = 32;
                panelMenu.Height = 2;
             
            //}
            btnAbrir.Enabled = true;
            
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            resultado = MetroFramework.MetroMessageBox.Show(this, "Seguro que desea salir?", "Mensaje Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resultado.Equals(DialogResult.Yes))
            {
                this.Close();
                Login login = new Login();
                login.Show();
            }
           
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            this.Close();
            Profile perfil = new Profile();
            perfil.Show();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            this.Close();
            RegistrarProducto producto = new RegistrarProducto();
            producto.Show();
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            this.Close();
            RegistrarCategoria categoria = new RegistrarCategoria();
            categoria.Show();
        }

        private void btnEntradaP_Click(object sender, EventArgs e)
        {
            this.Close();
            EntradaProductos entrada = new EntradaProductos();
            entrada.Show();
        }

        private void btnSalidaP_Click(object sender, EventArgs e)
        {
            this.Close();
            SalidaProductos salida = new SalidaProductos();
            salida.Show();
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {

            lectorPDF pdf = new lectorPDF();
            pdf.Show();


        }

        private void btnReportProvee_Click(object sender, EventArgs e)
        {
            
        }

       

    }
}
