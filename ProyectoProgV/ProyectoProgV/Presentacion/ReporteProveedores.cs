using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CrystalDecisions.CrystalReports.Engine;  //importante esta libreria para que funcione
using CrystalDecisions.Shared;
using ProyectoProgV.Presentacion;

namespace ProyectoProgV
{
    public partial class ReporteProveedores : MetroFramework.Forms.MetroForm
    {

        bool todos = false;
        bool estado = true;
        int contador = 0;
        public ReporteProveedores()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            VentanaPrincipalNuevo ventana = new VentanaPrincipalNuevo();
            ventana.Show();
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

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if(todos)
            {
                //C:\Users\Usuario\Documents\GitHub\ProyectoProgramacion5\ProyectoProgV\ProyectoProgV\Presentacion\reporteProveedor.rpt
                FormProveedor formulario = new FormProveedor();
                ReportDocument crystalrpt = new ReportDocument();
                crystalrpt.Load(@"C:\Users\Usuario\Documents\GitHub\ProyectoProgramacion5\ProyectoProgV\ProyectoProgV\Presentacion\reporteProveedor.rpt");
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
                oRep.Load(@"C:\Users\Usuario\Documents\GitHub\ProyectoProgramacion5\ProyectoProgV\ProyectoProgV\Presentacion\reporteProveedoresParametros.rpt");
                form.crystalReportViewer1.ReportSource = oRep;
                form.Show();
            }
           
        
        }

        private void ReporteProveedores_Load(object sender, EventArgs e)
        {
            dateDesde.MaxDate = DateTime.Today;
            dateHasta.MaxDate = DateTime.Today;
        }

      

     
    }
}
