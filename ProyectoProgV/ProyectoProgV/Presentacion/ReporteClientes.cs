using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace ProyectoProgV.Presentacion
{
    public partial class ReporteClientes : MetroFramework.Forms.MetroForm
    {
        bool todos = false;
        bool estado = true;
        int contador = 0;
        public ReporteClientes()
        {
            InitializeComponent();
        }

        private void ReporteClientes_Load(object sender, EventArgs e)
        {
            dateDesde.MaxDate = DateTime.Today;
            dateHasta.MaxDate = DateTime.Today;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (todos)
            {
                //C:\Users\Usuario\Documents\GitHub\ProyectoProgramacion5\ProyectoProgV\ProyectoProgV\Presentacion\reporteProveedor.rpt
                FormClientes formulario = new FormClientes();
                ReportDocument crystalrpt = new ReportDocument();
                crystalrpt.Load(@"C:\Users\Usuario\Documents\GitHub\ProyectoProgramacion5\ProyectoProgV\ProyectoProgV\Presentacion\reportCliente.rpt");
                formulario.crystalReportViewer1.ReportSource = crystalrpt;
                formulario.crystalReportViewer1.Refresh();
                formulario.Show();
            }
            else
            {
                MessageBox.Show("Aun falta esto");
                // aqui va si elije la opcion de fecha
            }
        }

        private void rbTodos_CheckedChanged(object sender, EventArgs e)
        {
            todos = true;
            dateDesde.Enabled = false;
            dateHasta.Enabled = false;
           
            btnGenerar.Enabled = true;
        }

        private void rbFecha_CheckedChanged(object sender, EventArgs e)
        {
            todos = false;
            dateDesde.Enabled = true;
            dateHasta.Enabled = true;
          
            btnGenerar.Enabled = true;

        }

      
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            VentanaPrincipalNuevo ventana = new VentanaPrincipalNuevo();
            ventana.Show();
        }

        private void panelOpciones_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
