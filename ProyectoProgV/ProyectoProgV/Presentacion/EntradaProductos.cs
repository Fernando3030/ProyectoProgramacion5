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
    public partial class EntradaProductos : MetroFramework.Forms.MetroForm
    {
        public EntradaProductos()
        {
            InitializeComponent();
        }

        private void EntradaProductos_Load(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
            dataGridView.DataSource = MetodosBD.cargarProductos3();



            dataGridView.ClearSelection();
        }
    }
}
