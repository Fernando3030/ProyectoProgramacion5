﻿using ProyectoProgV.Presentacion;
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

            pictureProfile.Image = System.Drawing.Image.FromFile(MetodosBD.buscarImagen(Login.ROL));
            pictureProfile.SizeMode = PictureBoxSizeMode.StretchImage;
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
            for (int i = panelMenu.Width; i < w + 110; i++ )
            {
                panelMenu.Width = i;
                panelMenu.Height = i;
                a = i;


            }
            btnAbrir.Enabled = false;
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            // 32, 2
          //  for (int i = a; i > w; i--)
           // {
               
             
            //}
            panelMenu.Width = 32;
            panelMenu.Height = 2;
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
            
        }

        private void btnSalidaP_Click(object sender, EventArgs e)
        {
            
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {
            panelMenu.Width = 32;
            panelMenu.Height = 2;
            btnAbrir.Enabled = true;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            panelMenu.Width = 32;
            panelMenu.Height = 2;
            btnAbrir.Enabled = true;
            lectorPDF pdf = new lectorPDF();
            pdf.Show();


        }

        private void btnReportProvee_Click(object sender, EventArgs e)
        {
            this.Close();
            ReporteProveedores reporteP = new ReporteProveedores();
            reporteP.Show();
        }

        private void btnMovimiento_Click(object sender, EventArgs e)
        {
            this.Close();
            EntradaProductos entrada = new EntradaProductos();
            entrada.Show();
        }

        private void btnReportCliente_Click(object sender, EventArgs e)
        {
            this.Close();
            ReporteClientes reportC = new ReporteClientes();
            reportC.Show();

        }

        private void btnReportUsuarios_Click(object sender, EventArgs e)
        {
            this.Close();
            ReporteUsuarios reportU = new ReporteUsuarios();
            reportU.Show();
        }

        private void btnReportFactClient_Click(object sender, EventArgs e)
        {
            this.Close();
            reporteFacturaCliente reportC = new reporteFacturaCliente();
            reportC.Show();
        }

        private void VentanaPrincipalNuevo_Click(object sender, EventArgs e)
        {
            panelMenu.Width = 32;
            panelMenu.Height = 2;
            btnAbrir.Enabled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panelMenu.Width = 32;
            panelMenu.Height = 2;
            btnAbrir.Enabled = true;
        }

        private void ribbonPanel1_Click(object sender, EventArgs e)
        {
            panelMenu.Width = 32;
            panelMenu.Height = 2;
            btnAbrir.Enabled = true;
        }

        private void menuRegistros_Click(object sender, EventArgs e)
        {
            panelMenu.Width = 32;
            panelMenu.Height = 2;
            btnAbrir.Enabled = true;
        }

        private void menuMercaderia_Click_1(object sender, EventArgs e)
        {
            panelMenu.Width = 32;
            panelMenu.Height = 2;
            btnAbrir.Enabled = true;
        }

        private void menuFacturas_Click(object sender, EventArgs e)
        {
            panelMenu.Width = 32;
            panelMenu.Height = 2;
            btnAbrir.Enabled = true;
        }

        private void menuReportes_Click(object sender, EventArgs e)
        {
            panelMenu.Width = 32;
            panelMenu.Height = 2;
            btnAbrir.Enabled = true;
        }

       

    }
}
