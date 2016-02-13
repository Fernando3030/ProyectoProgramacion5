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
        bool todos = false;
        bool fecha = false;
        bool estado = true;
        int contador = 0;
        public reporteFacturaCliente()
        {
            InitializeComponent();
        }

        private void reporteFacturaCliente_Load(object sender, EventArgs e)
        {
            dateDesde.MaxDate = DateTime.Today;
            dateHasta.MaxDate = DateTime.Today;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            FormFacturaC form = new FormFacturaC();

            if(todos)
            {
                ReportDocument crystalrpt = new ReportDocument();
                crystalrpt.Load(@"C:\Users\Usuario\Documents\GitHub\ProyectoProgramacion5\ProyectoProgV\ProyectoProgV\Presentacion\reporteTodosFacturasClientes.rpt");
                form.crystalReportViewer1.ReportSource = crystalrpt;
                form.crystalReportViewer1.Refresh();
                form.Show();
            }
            else
                if(fecha)
                {
                    DateTime fecha1 = dateDesde.Value;
                    string fechaDesde = fecha1.ToString("d");

                    DateTime fecha2 = dateHasta.Value;
                    string fechaHasta = fecha2.ToString("d");

                    



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
                    oRep.Load(@"C:\Users\Usuario\Documents\GitHub\ProyectoProgramacion5\ProyectoProgV\ProyectoProgV\Presentacion\reporteFacturaClientePorFecha.rpt");
                    form.crystalReportViewer1.ReportSource = oRep;
                    form.Show();
                }
                else
             {
                

                if(txtNumFact.Text.Equals(""))
                {
                    MessageBox.Show("Debe ingresar un Nro de Factura");
                }
                else
                {
                    bool numFactura = MetodosBD.buscarNumFactCliente(txtNumFact.Text);
                    if(numFactura)
                    {
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
                    else
                    {
                        MessageBox.Show("Número de Factura No existe");
                    }
                 
                }

              
            }
           
            
          
        
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            VentanaPrincipalNuevo ventana = new VentanaPrincipalNuevo();
            ventana.Show();
        }

        private void rbFecha_CheckedChanged(object sender, EventArgs e)
        {
            todos = false;
            fecha = false;
            txtNumFact.Enabled = true;
            dateDesde.Enabled = false;
            dateHasta.Enabled = false;
      
            btnGenerar.Enabled = true;
        }

        private void rbTodos_CheckedChanged(object sender, EventArgs e)
        {
            todos = true;
            fecha = false;
            txtNumFact.Enabled = false;
            dateDesde.Enabled = false;
            dateHasta.Enabled = false;
 

            btnGenerar.Enabled = true;
        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            todos = false;
            fecha = true;
            txtNumFact.Enabled = false;

            dateDesde.Enabled = true;
            dateHasta.Enabled = true;
 
            btnGenerar.Enabled = true;
        }
    }
}
