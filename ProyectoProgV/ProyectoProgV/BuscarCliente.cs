using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoProgV
{
    public partial class BuscarCliente : MetroFramework.Forms.MetroForm
    {
        public static bool banderaCliente = false;
        static string nombreCompleto = "";
        static string cedula = "";
        static string direccion = "";
        static string telefono = "";
        
        
        public BuscarCliente()
        {
            InitializeComponent();
        }

       

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            banderaCliente = true;
            this.Close();
            RegistroClientes clientes = new RegistroClientes();
            clientes.Show();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            banderaCliente = false;
            FacturaCliente factCliente = new FacturaCliente();
            factCliente.txtCliente.Text = nombreCompleto;
            factCliente.txtRUC.Text = cedula;
            factCliente.txtDireccion.Text = direccion;
            factCliente.txtTelefono.Text = telefono;
            FacturaCliente.guardar = true;
            FacturaCliente.rbConsu = true;
            FacturaCliente.rbFact = true;
           
            FacturaCliente.rbCod = true;
            FacturaCliente.rbProdu = true;
            FacturaCliente.txtBusq = true;
            FacturaCliente.dataGridPro = true;

            FacturaCliente.txtCant = true;
            FacturaCliente.btnA = true;
            factCliente.Show();
        }

     

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (rbNombre.Checked)
            {

                DataTable dt = MetodosBD.cargarClientes();
                string fieldName = string.Concat("[", dt.Columns[2].ColumnName, "]");
                dt.DefaultView.Sort = fieldName;
                DataView view = dt.DefaultView;
                view.RowFilter = string.Empty;
                if (txtBusqueda.Text != string.Empty)
                    view.RowFilter = fieldName + " LIKE '%" + txtBusqueda.Text + "%'";
                dataGridView2.DataSource = view;
            }


            if (rbCedula.Checked)
            {

                DataTable dt = MetodosBD.cargarClientes();
                string fieldName = string.Concat("[", dt.Columns[1].ColumnName, "]");
                dt.DefaultView.Sort = fieldName;
                DataView view = dt.DefaultView;
                view.RowFilter = string.Empty;
                if (txtBusqueda.Text != string.Empty)
                    view.RowFilter = fieldName + " LIKE '%" + txtBusqueda.Text + "%'";
                dataGridView2.DataSource = view;
            }
        }

        private void rbCedula_CheckedChanged(object sender, EventArgs e)
        {
            txtBusqueda.Enabled = true;
        }

        private void rbNombre_CheckedChanged(object sender, EventArgs e)
        {
            txtBusqueda.Enabled = true;
        }

       


        private void BuscarCliente_Load_1(object sender, EventArgs e)
        {
            txtBusqueda.Focus();
            //dataGridView.Rows.Clear();
            dataGridView2.DataSource = MetodosBD.cargarClientes();
            dataGridView2.ClearSelection();
        }

        private void dataGridView2_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int count = 0; count < dataGridView2.Rows.Count; count++)
            {
                string codigo = (string)dataGridView2.Rows[count].Cells["cod_cliente"].Value;
                bool estado = MetodosBD.buscarEstadoCliente(codigo);
                if (estado == false)
                {
                    dataGridView2.Rows[count].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string codigo = (string)dataGridView2.CurrentRow.Cells["cod_cliente"].Value;
           
            bool estado = MetodosBD.buscarEstadoCliente(codigo);
            if (estado == false)
            {
                MessageBox.Show("No puede ingresar a este cliente a la factura", "Mensaje de Advertencia");
            }
            else
            {
                using (SqlConnection conexion = Conexion.obtenerConexion())
                {
                    SqlCommand comando = new SqlCommand(string.Format("Select ced_cliente, nom_cliente, ape_cliente, dir_cliente, telf_cliente from cliente where cod_cliente like '%{0}'", codigo), conexion);
                    SqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                       
                        cedula = reader.GetString(0);
                        nombreCompleto = reader.GetString(1) + " " + reader.GetString(2);
                    
                        direccion = reader.GetString(3);
                        telefono = reader.GetString(4);
                       

                    }
                    conexion.Close();
                    this.Close();
                    FacturaCliente fact = new FacturaCliente();
                    fact.txtCliente.Text = nombreCompleto;
                    fact.txtRUC.Text = cedula;
                    fact.txtDireccion.Text = direccion;
                    fact.txtTelefono.Text = telefono;
                    FacturaCliente.guardar = true;
                    
                    FacturaCliente.rbConsu = true;
                    FacturaCliente.rbFact = true;

                    FacturaCliente.rbCod = true;
                    FacturaCliente.rbProdu = true;
                    FacturaCliente.txtBusq = true;
                    FacturaCliente.dataGridPro = true;

                    FacturaCliente.txtCant = true;
                    FacturaCliente.btnA = true;

                    //fact.btnBuscarCliente.Enabled = false;
                    fact.Show();


                }
            }
        }
    }
}
