using ProyectoProgV.Entidad;
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
            pictureBox1.Image = System.Drawing.Image.FromFile("D:\\ingenieria en sistemas\\Fernando sexto semestre\\Programacion 5\\Programas n c# 6to semestre\\ProyectoProgV\\ProyectoProgV\\Resources\\cameraFinal.jpg");


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
            string numFact = txtNroFactP.Text;
            string cantidad = txtCantidad.Text;
            string total = txtTotalFact.Text;
            string proveedor = cbProveedor.SelectedValue.ToString();
            DateTime fecha = dateEntrega.Value;
            string fechita = fecha.ToString("d");
            string url = Direccion;
            bool banderaNum = false;
            bool banderaCantidad = false;
            bool banderaTotal = false;
            bool banderaUrl = false;
            pictureProveedor.Image = System.Drawing.Image.FromFile("D:\\ingenieria en sistemas\\Fernando sexto semestre\\Programacion 5\\Programas n c# 6to semestre\\ProyectoProgV\\ProyectoProgV\\Resources\\aprovado.png");
            pictureFecha.Image = System.Drawing.Image.FromFile("D:\\ingenieria en sistemas\\Fernando sexto semestre\\Programacion 5\\Programas n c# 6to semestre\\ProyectoProgV\\ProyectoProgV\\Resources\\aprovado.png");
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

            if (banderaNum && banderaCantidad && banderaUrl && banderaTotal)
            {
                int cant = Convert.ToInt32(cantidad);
              //  int num = Convert.ToInt32(numFact);
                decimal t = Convert.ToDecimal(total);
                if (banderaModificar == false)
                {


                    ControlPagos pagos = new ControlPagos(numFact, proveedor, fechita, cant, t, url);
                    int resultado = MetodosBD.InsertarControl(pagos);
                    if (resultado > 0)
                    {

                        MessageBox.Show("Datos guardados correctamente", "Mensaje de confirmación");
                        btnCargarFoto.Enabled = false;
                        pictureBox1.Image = System.Drawing.Image.FromFile("D:\\ingenieria en sistemas\\Fernando sexto semestre\\Programacion 5\\Programas n c# 6to semestre\\ProyectoProgV\\ProyectoProgV\\Resources\\cameraFinal.jpg");
                        pictureNumFact.Image = null;
                        pictureProveedor.Image = null;
                        pictureFecha.Image = null;
                        pictureCantidad.Image = null;
                        pictureTotal.Image = null;

                        txtNroFactP.Text = "";
                        txtCantidad.Text = "";
                        txtTotalFact.Text = "";
                        Direccion = "";
                        txtNroFactP.Enabled = false;
                        cbProveedor.Enabled = false;
                        dateEntrega.Enabled = false;
                        txtCantidad.Enabled = false;
                        txtTotalFact.Enabled = false;
                        btnGuardar.Enabled = false;
                        btnNuevo.Enabled = true;

                    }

                    dataGridView.DataSource = MetodosBD.cargarControlPagos();

                }
                else
                {
                    banderaModificar = false;
                    int resultado = MetodosBD.ActualizarControlP(numFact, proveedor, fechita, cant, t, url);
                         if (resultado > 0)
                         {
                             btnCargarFoto.Enabled = false;
                             pictureBox1.Image = System.Drawing.Image.FromFile("D:\\ingenieria en sistemas\\Fernando sexto semestre\\Programacion 5\\Programas n c# 6to semestre\\ProyectoProgV\\ProyectoProgV\\Resources\\cameraFinal.jpg");
                             pictureNumFact.Image = null;
                             pictureProveedor.Image = null;
                             pictureFecha.Image = null;
                             pictureCantidad.Image = null;
                             pictureTotal.Image = null;

                             txtNroFactP.Text = "";
                             txtCantidad.Text = "";
                             txtTotalFact.Text = "";
                             Direccion = "";
                             txtNroFactP.Enabled = false;
                             cbProveedor.Enabled = false;
                             dateEntrega.Enabled = false;
                             txtCantidad.Enabled = false;
                             txtTotalFact.Enabled = false;
                             btnGuardar.Enabled = false;
                             btnNuevo.Enabled = true;
                             MessageBox.Show("Dato Actualizado Correctamente", "Mensaje de Confirmación");
                             dataGridView.DataSource = MetodosBD.cargarControlPagos();
                         }
                         else
                         {
                             MessageBox.Show("Dato no actualizado", "Mensaje de advertencia");
                         }
                }



            }
            else
            {
                MessageBox.Show("Algún campo esta erróneo o vacío", "Mensaje de Advertencia");
            }



        
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            btnModificar.Enabled = false;
            btnCargarFoto.Enabled = true;
            btnGuardar.Enabled = true;
            banderaModificar = true;
            txtNroFactP.Enabled = false;
            cbProveedor.Enabled = true;
            dateEntrega.Enabled = true;
            txtCantidad.Enabled = true;
            txtTotalFact.Enabled = true;
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string  numF = (string)dataGridView.CurrentRow.Cells["num_factp"].Value;
            btnModificar.Enabled = true;
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            txtNroFactP.Enabled = false;
            cbProveedor.Enabled = false;
            dateEntrega.Enabled = false;
            txtCantidad.Enabled = false;
            txtTotalFact.Enabled = false;
            btnCargarFoto.Enabled = false;

            pictureBox1.Image = null;
            pictureNumFact.Image = null;
            pictureProveedor.Image = null;
            pictureFecha.Image = null;
            pictureCantidad.Image = null;
            pictureTotal.Image = null;

            using (SqlConnection conexion = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Select * from controlPagos where num_factp like '%{0}'", numF), conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    txtNroFactP.Text = reader.GetString(0);
                    string p = MetodosBD.buscarProveedor(reader.GetString(1));
                    cbProveedor.SelectedIndex = cbProveedor.FindString(p);
                    dateEntrega.Value = Convert.ToDateTime(reader.GetString(2));
                    txtCantidad.Text = Convert.ToString(reader.GetInt32(3));
                         txtTotalFact.Text = Convert.ToString(reader.GetDecimal(4));
                    
                    Direccion = reader.GetString(5);

                    pictureBox1.ImageLocation = reader.GetString(5);

                   
                   

                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;


                }
                conexion.Close();


            }

           
        }

        private void txtBusqueda1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = MetodosBD.cargarControlPagos();
            string fieldName = string.Concat("[", dt.Columns[0].ColumnName, "]");
            Console.WriteLine("la columan es " + fieldName);
           
            dt.DefaultView.Sort = fieldName;
            DataView view = dt.DefaultView;
            view.RowFilter = string.Empty;
            if (txtBusqueda1.Text != string.Empty)
                view.RowFilter = fieldName + " like '%" + txtBusqueda1.Text + "%'";
            dataGridView.DataSource = view;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            VentanaPrincipalNuevo ventana = new VentanaPrincipalNuevo();
            ventana.Show();
        }
    }
}
