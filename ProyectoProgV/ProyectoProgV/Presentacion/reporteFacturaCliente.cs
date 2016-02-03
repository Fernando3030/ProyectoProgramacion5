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

namespace ProyectoProgV.Presentacion
{
    public partial class reporteFacturaCliente : MetroFramework.Forms.MetroForm
    {
        public reporteFacturaCliente()
        {
            InitializeComponent();
        }

        private void reporteFacturaCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            FormFacturaC form = new FormFacturaC();


           
            ReportDocument oRep = new ReportDocument();
            ParameterField pf = new ParameterField();
            ParameterFields pfs = new ParameterFields();
            ParameterDiscreteValue pdv = new ParameterDiscreteValue();
            pf.Name = "@numFact";
            pdv.Value = txtNumFact.Text;
            pf.CurrentValues.Add(pdv);
            pfs.Add(pf);
            form.crystalReportViewer1.ParameterFieldInfo = pfs;
            oRep.Load(@"C:\Users\Usuario\Documents\GitHub\ProyectoProgramacion5\ProyectoProgV\ProyectoProgV\Presentacion\reporteFacturaCliente2.rpt");
            form.crystalReportViewer1.ReportSource = oRep;
            form.Show();
            
          
        
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            VentanaPrincipalNuevo ventana = new VentanaPrincipalNuevo();
            ventana.Show();
        }
    }
}
