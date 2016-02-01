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
    public partial class ReporteUsuarios : MetroFramework.Forms.MetroForm

    {
        bool todos = false;
        bool estado = true;
        int contador = 0;
        public ReporteUsuarios()
        {
            InitializeComponent();
        }

        private void ReporteUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void rbTodos_CheckedChanged(object sender, EventArgs e)
        {
            todos = true;
            dateDesde.Enabled = false;
            dateHasta.Enabled = false;
            chEstado.Enabled = false;
            btnGenerar.Enabled = true;
        }

        private void rbFecha_CheckedChanged(object sender, EventArgs e)
        {
            todos = false;
            dateDesde.Enabled = true;
            dateHasta.Enabled = true;
            chEstado.Enabled = true;
            btnGenerar.Enabled = true;
        }

        private void chEstado_CheckedChanged(object sender, EventArgs e)
        {
            if (chEstado.Checked)
            {
                chEstado.Text = "Inactivo";
                chEstado.ForeColor = Color.Red;
                contador = contador + 1;
                estado = false;

            }
            else
            {

                chEstado.Text = "Activo";
                chEstado.ForeColor = Color.Green;
                contador = 0;
                estado = true;

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            VentanaPrincipalNuevo ventana = new VentanaPrincipalNuevo();
            ventana.Show();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (todos)
            {
                //C:\Users\Usuario\Documents\GitHub\ProyectoProgramacion5\ProyectoProgV\ProyectoProgV\Presentacion\reporteProveedor.rpt
                FormFacturaCliente formulario = new FormFacturaCliente();
                ReportDocument crystalrpt = new ReportDocument();
                crystalrpt.Load(@"C:\Users\Usuario\Documents\GitHub\ProyectoProgramacion5\ProyectoProgV\ProyectoProgV\Presentacion\reporteUser.rpt");
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
    }
}
