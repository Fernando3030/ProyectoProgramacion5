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
    public partial class lectorPDF : MetroFramework.Forms.MetroForm
    {
        public lectorPDF()
        {
            InitializeComponent();
        }

        private void lectorPDF_Load(object sender, EventArgs e)
        {
            pdf.LoadFile(@"C:\Users\Usuario\Documents\GitHub\ProyectoProgramacion5\Manual User\Manual.pdf");
        }
    }
}
