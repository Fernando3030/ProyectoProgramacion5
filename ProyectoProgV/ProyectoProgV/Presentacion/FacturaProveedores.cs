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
    public partial class FacturaProveedores : MetroFramework.Forms.MetroForm
    {

        string Direccion = "";
       
        Validaciones validacion = new Validaciones();

        bool banderaModificar = false;
        int contador = 0;
        //bool estado = true;

        DialogResult resultado;

        public FacturaProveedores()
        {
            InitializeComponent();
        }

        private void tabControlCompras_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
                {
                    e.Handled = false;
                }
                else
                {
                    //el resto de teclas pulsadas se desactivan
                    e.Handled = true;
                }
        }

        private void btnCargarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog BuscarImagen = new OpenFileDialog();
            BuscarImagen.Filter = "Archivos de Imagen|*.jpg";
            //Aquí incluiremos los filtros que queramos.
            BuscarImagen.FileName = "";
            BuscarImagen.Title = "Titulo del Dialogo";
            BuscarImagen.InitialDirectory = "C:\\";
            //BuscarImagen.FileName = this.textBox1.Text;
            if (BuscarImagen.ShowDialog() == DialogResult.OK)
            {
                /// Si esto se cumple, capturamos la propiedad File Name y la guardamos en el control
                //  this.textBox1.Text = BuscarImagen.FileName;

                this.pictureBox1.ImageLocation = BuscarImagen.FileName;
                Direccion = pictureBox1.ImageLocation;
                //Pueden usar tambien esta forma para cargar la Imagen solo activenla y comenten la linea donde se cargaba anteriormente 
                //this.pictureBox1.ImageLocation = textBox1.Text;
                Console.Write("Direccion 1 " + Direccion);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            }  
        }

        private void panelTransparente1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (files.Length > 0)
            {

                pictureBox1.ImageLocation = files[0];
                Direccion = pictureBox1.ImageLocation;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                Console.Write(pictureBox1.ImageLocation);
            }          
        }

        private void panelTransparente1_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNroFactP.Text = "";
            txtCantidad.Text = "";
            txtTotalFact.Text = "";
            Direccion = "";
            txtNroFactP.Enabled = true;
            cbProveedor.Enabled = true;
            dateEntrega.Enabled = true;
            txtCantidad.Enabled = true;
            txtTotalFact.Enabled = true;


            pictureNumFact.Image = null;
            pictureProveedor.Image = null;
             pictureFecha.Image = null;
             pictureCantidad.Image = null;
             pictureTotal.Image = null;
            pictureBox1.Image = System.Drawing.Image.FromFile("D:\\ingenieria en sistemas\\Fernando sexto semestre\\Programacion 5\\Programas n c# 6to semestre\\ProyectoProgV\\ProyectoProgV\\Resources\\camarita.jpg");


             btnModificar.Enabled = false;
             btnGuardar.Enabled = true;
             banderaModificar = false;
             btnCargarFoto.Enabled = true;
             btnNuevo.Enabled = false;

             dataGridView.ClearSelection();
             txtNroFactP.Focus();
            
          

        }

        private void FacturaProveedores_Load(object sender, EventArgs e)
        {
            cbProveedor.DisplayMember = "Nombre";  // el Ciud es el get y set de la clase Categoria
            cbProveedor.ValueMember = "Codigo"; // Codigo es el get y set de la clase Categoria
            cbProveedor.DataSource = MetodosBD.cargarProveedor2();

            dataGridView.Rows.Clear();
            dataGridView.DataSource = MetodosBD.cargarControlPagos();



            dataGridView.ClearSelection();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string numFact = "";
            string cantidad = "";
            string total = "";
            string proveedor = cbProveedor.SelectedValue.ToString();
            DateTime fecha = dateEntrega.Value;
            string fechita = fecha.ToString("d");
            string url = Direccion;
            bool banderaNum = false;
            bool banderaCantidad = false;
            bool banderaTotal = false;
            bool banderaUrl = false;

            if (numFact.Equals(""))
            {
                pictureNumFact.Image = System.Drawing.Image.FromFile("D:\\ingenieria en sistemas\\Fernando sexto semestre\\Programacion 5\\Programas n c# 6to semestre\\ProyectoProgV\\ProyectoProgV\\Resources\\error.png");
            }
            else
            {
                banderaNum = true;
                pictureNumFact.Image = System.Drawing.Image.FromFile("D:\\ingenieria en sistemas\\Fernando sexto semestre\\Programacion 5\\Programas n c# 6to semestre\\ProyectoProgV\\ProyectoProgV\\Resources\\aprovado.png");
            }



            if (cantidad.Equals(""))
            {
                pictureCantidad.Image = System.Drawing.Image.FromFile("D:\\ingenieria en sistemas\\Fernando sexto semestre\\Programacion 5\\Programas n c# 6to semestre\\ProyectoProgV\\ProyectoProgV\\Resources\\error.png");
            }
            else
            {
                banderaCantidad = true;
                pictureCantidad.Image = System.Drawing.Image.FromFile("D:\\ingenieria en sistemas\\Fernando sexto semestre\\Programacion 5\\Programas n c# 6to semestre\\ProyectoProgV\\ProyectoProgV\\Resources\\aprovado.png");
            }


            if (total.Equals(""))
            {
                pictureTotal.Image = System.Drawing.Image.FromFile("D:\\ingenieria en sistemas\\Fernando sexto semestre\\Programacion 5\\Programas n c# 6to semestre\\ProyectoProgV\\ProyectoProgV\\Resources\\error.png");
            }
            else
            {
                banderaTotal = true;
                pictureTotal.Image = System.Drawing.Image.FromFile("D:\\ingenieria en sistemas\\Fernando sexto semestre\\Programacion 5\\Programas n c# 6to semestre\\ProyectoProgV\\ProyectoProgV\\Resources\\aprovado.png");
            }


            if (url.Equals(""))
            {
             //   pictureTotal.Image = System.Drawing.Image.FromFile("D:\\ingenieria en sistemas\\Fernando sexto semestre\\Programacion 5\\Programas n c# 6to semestre\\ProyectoProgV\\ProyectoProgV\\Resources\\error.png");
            }
            else
            {
                banderaUrl = true;
               // pictureTotal.Image = System.Drawing.Image.FromFile("D:\\ingenieria en sistemas\\Fernando sexto semestre\\Programacion 5\\Programas n c# 6to semestre\\ProyectoProgV\\ProyectoProgV\\Resources\\aprovado.png");
            }



        
        }
    }
}
