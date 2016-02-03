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
using CrystalDecisions.Shared;

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
                DateTime fecha = dateDesde.Value;
                string fechaDesde = fecha.ToString("d");

                DateTime fecha2 = dateHasta.Value;
                string fechaHasta = fecha2.ToString("d");

                FormProveedoresParametros form = new FormProveedoresParametros();



                ReportDocument oRep = new ReportDocument();


                ParameterField pf = new ParameterField();
                ParameterFields pfs = new ParameterFields();
                ParameterDiscreteValue pdv = new ParameterDiscreteValue();
                pf.Name = "@fechaDesde";
                pdv.Value = fechaDesde;
                pf.CurrentValues.Add(pdv);

                pfs.Add(pf);

                pfs.Clear();


                pf.Name = "@fechaHasta";
                pdv.Value = fechaHasta;
                pf.CurrentValues.Add(pdv);

                pfs.Add(pf);




                form.crystalReportViewer1.ParameterFieldInfo = pfs;
                oRep.Load(@"C:\Users\Usuario\Documents\GitHub\ProyectoProgramacion5\ProyectoProgV\ProyectoProgV\Presentacion\reporteUsuariosParametros.rpt");
                form.crystalReportViewer1.ReportSource = oRep;
                form.Show();
            }
        }
    }
}
