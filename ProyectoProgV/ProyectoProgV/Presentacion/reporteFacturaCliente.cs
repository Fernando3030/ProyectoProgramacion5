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
            
            /*
            OleDbConnection conexion = new OleDbConnection("Provider=SQLOLEDB;" + "Data source=PC; Initial Catalog=BDNutril; Integrated Security=SSPI");
            reportFacturaC opt = new reportFacturaC(); //nombre del crystal "Provider=SQLOLEDB;Data Source=(local);Integrated Security=SSPI"
            //Creo el objeto e instancio el objeto DataSet


            DataSet objDataSet = new DataSet();
            string numFact = txtNumFact.Text;


            //Establezcon la seleccion de Datos
            string cedulaCliente = MetodosBD.buscarCedula2(numFact);
            string producto = MetodosBD.buscarCodigoProducto5(numFact);

            OleDbDataAdapter objAdap = new OleDbDataAdapter("Select ced_cliente, nom_cliente, ape_cliente, dir_cliente From cliente where ced_cliente like '" + cedulaCliente +"'", conexion);//consulta

            OleDbDataAdapter objAdap2 = new OleDbDataAdapter("Select numFact_cliente, fecha_facturaC, subTotal, iva, totalFact, anulado From facturaCliente where numFact_cliente like '" + numFact + "'", conexion);//consulta
            OleDbDataAdapter objAdap3 = new OleDbDataAdapter("Select producto From producto where cod_producto like '" + producto + "'", conexion);//consulta
            OleDbDataAdapter objAdap4 = new OleDbDataAdapter("Select cantidad, precio_unitario, total From detalleFacturaCliente where numFact_cliente like '" + numFact + "'", conexion);//consulta


            //Cargo el Repositorio de Datos


            objAdap.Fill(objDataSet, "cliente");//aqui tu tabla 
            objAdap2.Fill(objDataSet, "facturaCliente");//aqui tu tabla 
            objAdap3.Fill(objDataSet, "producto");//aqui tu tabla 
            objAdap4.Fill(objDataSet, "detalleFacturaCliente");//aqui tu tabla 


            //Muestro los datos en el reporte


            opt.SetDataSource(objDataSet);

            FormFacturaC form = new FormFacturaC();
            

            form.crystalReportViewer1.ReportSource = opt;
            form.Show();
             * */
        
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            VentanaPrincipalNuevo ventana = new VentanaPrincipalNuevo();
            ventana.Show();
        }
    }
}
