using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using System.Data.SqlClient;

namespace ProyectoProgV
{
    public partial class RegistroUsuarios : MetroFramework.Forms.MetroForm
    {
        Validaciones validacion = new Validaciones();
        String codigo = "";
        bool banderaModificar = false;
        int contador = 0;
        bool estado = true;
        DialogResult resultado;

        string Direccion="";

      
        public RegistroUsuarios()
        {
            InitializeComponent();
        }

        private void RegistroUsuarios_Load(object sender, EventArgs e)
        {
            cbCiudad.DisplayMember = "Ciud";  // el Ciud es el get y set de la clase Ciudad
            cbCiudad.ValueMember = "Codigo"; // Codigo es el get y set de la clase Ciudad
            cbCiudad.DataSource = MetodosBD.cargarCiudad();
            dataGridView.Rows.Clear();
           
            
           dataGridView.DataSource = MetodosBD.cargarUsuarios2();
         
            dataGridView.ClearSelection();
            txtCodigo.Enabled = false;
            cbTipoUsuario.Items.Add("Administrador");
            cbTipoUsuario.Items.Add("Secretaria");
            cbTipoUsuario.Items.Add("Trabajador");
            cbTipoUsuario.SelectedIndex = 0;
            deshabilitar();

         

         


          
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegistroUsuarios_DragDrop(object sender, DragEventArgs e)
        {

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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Login formulario = new Login();
            formulario.Show();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            habilitar();
            codigo = validacion.generarCodigo();
            pictureCodigo.Image = System.Drawing.Image.FromFile("D:\\ingenieria en sistemas\\Fernando sexto semestre\\Programacion 5\\Programas n c# 6to semestre\\ProyectoProgV\\ProyectoProgV\\Resources\\aprovado.png");
            pictureEstado.Image = System.Drawing.Image.FromFile("D:\\ingenieria en sistemas\\Fernando sexto semestre\\Programacion 5\\Programas n c# 6to semestre\\ProyectoProgV\\ProyectoProgV\\Resources\\aprovado.png");
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            banderaModificar = false;
            txtCodigo.Text = codigo;
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCedula.Text = "";
            txtDireccion.Text = "";
            txtEmail.Text = "";
            pictureBox1.Image = System.Drawing.Image.FromFile("D:\\ingenieria en sistemas\\Fernando sexto semestre\\Programacion 5\\Programas n c# 6to semestre\\ProyectoProgV\\ProyectoProgV\\Resources\\camarita.jpg");
            pictureFoto.Image = System.Drawing.Image.FromFile("D:\\ingenieria en sistemas\\Fernando sexto semestre\\Programacion 5\\Programas n c# 6to semestre\\ProyectoProgV\\ProyectoProgV\\Resources\\updown.png");
            btnCargarFoto.Enabled = true;
            chEstado.Text = "Activo";
            chEstado.Checked = false;
            Direccion = "";
            chEstado.Enabled = true;
            chEstado.ForeColor = Color.Green;
            contador = 0;
            estado = true;

            pictureNombre.Image = null;

            pictureApellido.Image = null;


            pictureDireccion.Image = null;

            pictureCedula.Image = null;

            pictureEmail.Image = null;

            pictureUsuario.Image = null;

            pictureContra.Image = null;

           

            pictureCiudad.Image = null;

            pictureTipo.Image = null;

            pictureTelefono.Image = null;

            txtTelefono.Text = "";
            txtUsuario.Text = "";
            txtPass.Text = "";
            dataGridView.ClearSelection();
            txtNombre.Focus();
        }

        public void habilitar()
        {
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtCedula.Enabled = true;
            txtDireccion.Enabled = true;
            txtEmail.Enabled = true;
            txtPass.Enabled = true;
            txtTelefono.Enabled = true;
            cbTipoUsuario.Enabled = true;
            cbCiudad.Enabled = true;
            txtUsuario.Enabled = true;
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
          
        }

        
        public void deshabilitar()
        {
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtCedula.Enabled = false;
            txtDireccion.Enabled = false;
            txtEmail.Enabled = false;
            txtPass.Enabled = false;
            btnCargarFoto.Enabled = false;
            txtUsuario.Enabled = false;
           
            txtTelefono.Enabled = false;
            cbTipoUsuario.Enabled = false;
            cbCiudad.Enabled = false;

            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;


        }


        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten Letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten Letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            if(email.Equals("")){

            }
            else
            {

                if (banderaModificar == false)
                {

                    if (validacion.validarEmail(email) == false)
                    {
                        txtEmail.Text = "";
                        txtEmail.Focus();
                        MessageBox.Show("Correo electrónico con formato incorrecto!", "Mensaje de Advertencia");
                    }
                }
             
            }
           
        }

       
        private void btnIngresar_Click(object sender, EventArgs e)
        {
          
            VentanaPrincipalNuevo ventana = new VentanaPrincipalNuevo();
            ventana.Show();
            this.Hide();
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
                Direccion = BuscarImagen.FileName;
                this.pictureBox1.ImageLocation = Direccion;
                //Pueden usar tambien esta forma para cargar la Imagen solo activenla y comenten la linea donde se cargaba anteriormente 
                //this.pictureBox1.ImageLocation = textBox1.Text;
                Console.Write("hola");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                Console.Write(Direccion);
            }         
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string codigo= txtCodigo.Text;
            string nombre= txtNombre.Text;
            string apellido= txtApellido.Text;
            string direccion= txtDireccion.Text;
            string telefono= txtTelefono.Text;
            string cedula= txtCedula.Text;
            string email= txtEmail.Text;
            string user= txtUsuario.Text;
            string contra= txtPass.Text;
             string ciudad = cbCiudad.SelectedValue.ToString();
            string comboTipo = cbTipoUsuario.SelectedItem.ToString();
            string url = Direccion;
            bool banderaNombre = false;
            bool banderaApellido = false;
            bool banderaDireccion = false;
            bool banderaCedula = false;
            bool banderaEmail = false;
            bool banderaUser = false;
            bool banderaContra = false;
            bool banderaCiudad= false;
            bool banderaTipo = false;
            bool banderaUrl = false;
            bool banderaTelefono=false;
            if(nombre.Equals(""))
            {
                pictureNombre.Image = System.Drawing.Image.FromFile("D:\\ingenieria en sistemas\\Fernando sexto semestre\\Programacion 5\\Programas n c# 6to semestre\\ProyectoProgV\\ProyectoProgV\\Resources\\error.png");
            }
            else
            {
                banderaNombre = true;
                pictureNombre.Image = System.Drawing.Image.FromFile("D:\\ingenieria en sistemas\\Fernando sexto semestre\\Programacion 5\\Programas n c# 6to semestre\\ProyectoProgV\\ProyectoProgV\\Resources\\aprovado.png");
            }

            if (apellido.Equals(""))
            {
                pictureApellido.Image = System.Drawing.Image.FromFile("D:\\ingenieria en sistemas\\Fernando sexto semestre\\Programacion 5\\Programas n c# 6to semestre\\ProyectoProgV\\ProyectoProgV\\Resources\\error.png");
            }
            else
            {
                banderaApellido = true;
                pictureApellido.Image = System.Drawing.Image.FromFile("D:\\ingenieria en sistemas\\Fernando sexto semestre\\Programacion 5\\Programas n c# 6to semestre\\ProyectoProgV\\ProyectoProgV\\Resources\\aprovado.png");
            }

            if (direccion.Equals(""))
            {
                pictureDireccion.Image = System.Drawing.Image.FromFile("D:\\ingenieria en sistemas\\Fernando sexto semestre\\Programacion 5\\Programas n c# 6to semestre\\ProyectoProgV\\ProyectoProgV\\Resources\\error.png");
            }
            else
            {
                banderaDireccion = true;
                pictureDireccion.Image = System.Drawing.Image.FromFile("D:\\ingenieria en sistemas\\Fernando sexto semestre\\Programacion 5\\Programas n c# 6to semestre\\ProyectoProgV\\ProyectoProgV\\Resources\\aprovado.png");
            }

            if (cedula.Equals(""))
            {
                pictureCedula.Image = System.Drawing.Image.FromFile("D:\\ingenieria en sistemas\\Fernando sexto semestre\\Programacion 5\\Programas n c# 6to semestre\\ProyectoProgV\\ProyectoProgV\\Resources\\error.png");
            }
            else
            {
                banderaCedula = true;
                pictureCedula.Image = System.Drawing.Image.FromFile("D:\\ingenieria en sistemas\\Fernando sexto semestre\\Programacion 5\\Programas n c# 6to semestre\\ProyectoProgV\\ProyectoProgV\\Resources\\aprovado.png");
            }

            if (email.Equals(""))
            {
                pictureEmail.Image = System.Drawing.Image.FromFile("D:\\ingenieria en sistemas\\Fernando sexto semestre\\Programacion 5\\Programas n c# 6to semestre\\ProyectoProgV\\ProyectoProgV\\Resources\\error.png");
            }
            else
            {
                banderaEmail = true;
                pictureEmail.Image = System.Drawing.Image.FromFile("D:\\ingenieria en sistemas\\Fernando sexto semestre\\Programacion 5\\Programas n c# 6to semestre\\ProyectoProgV\\ProyectoProgV\\Resources\\aprovado.png");
            }

            if (user.Equals(""))
            {
                pictureUsuario.Image = System.Drawing.Image.FromFile("D:\\ingenieria en sistemas\\Fernando sexto semestre\\Programacion 5\\Programas n c# 6to semestre\\ProyectoProgV\\ProyectoProgV\\Resources\\error.png");
            }
            else
            {
                banderaUser = true;
                pictureUsuario.Image = System.Drawing.Image.FromFile("D:\\ingenieria en sistemas\\Fernando sexto semestre\\Programacion 5\\Programas n c# 6to semestre\\ProyectoProgV\\ProyectoProgV\\Resources\\aprovado.png");
            }

            if (contra.Equals(""))
            {
                pictureContra.Image = System.Drawing.Image.FromFile("D:\\ingenieria en sistemas\\Fernando sexto semestre\\Programacion 5\\Programas n c# 6to semestre\\ProyectoProgV\\ProyectoProgV\\Resources\\error.png");
            }
            else
            {
                banderaContra = true;
                pictureContra.Image = System.Drawing.Image.FromFile("D:\\ingenieria en sistemas\\Fernando sexto semestre\\Programacion 5\\Programas n c# 6to semestre\\ProyectoProgV\\ProyectoProgV\\Resources\\aprovado.png");
            }

            if (url.Equals(""))
            {
                pictureFoto.Image = System.Drawing.Image.FromFile("D:\\ingenieria en sistemas\\Fernando sexto semestre\\Programacion 5\\Programas n c# 6to semestre\\ProyectoProgV\\ProyectoProgV\\Resources\\error.png");
            }
            else
            {
                banderaUrl = true;
                pictureFoto.Image = System.Drawing.Image.FromFile("D:\\ingenieria en sistemas\\Fernando sexto semestre\\Programacion 5\\Programas n c# 6to semestre\\ProyectoProgV\\ProyectoProgV\\Resources\\aprovado.png");
            }

            if (ciudad.Equals(""))
            {
                pictureCiudad.Image = System.Drawing.Image.FromFile("D:\\ingenieria en sistemas\\Fernando sexto semestre\\Programacion 5\\Programas n c# 6to semestre\\ProyectoProgV\\ProyectoProgV\\Resources\\error.png");
            }
            else
            {
                banderaCiudad = true;
                pictureCiudad.Image = System.Drawing.Image.FromFile("D:\\ingenieria en sistemas\\Fernando sexto semestre\\Programacion 5\\Programas n c# 6to semestre\\ProyectoProgV\\ProyectoProgV\\Resources\\aprovado.png");
            }

            if (comboTipo.Equals(""))
            {
                pictureTipo.Image = System.Drawing.Image.FromFile("D:\\ingenieria en sistemas\\Fernando sexto semestre\\Programacion 5\\Programas n c# 6to semestre\\ProyectoProgV\\ProyectoProgV\\Resources\\error.png");
            }
            else
            {
                banderaTipo = true;
                pictureTipo.Image = System.Drawing.Image.FromFile("D:\\ingenieria en sistemas\\Fernando sexto semestre\\Programacion 5\\Programas n c# 6to semestre\\ProyectoProgV\\ProyectoProgV\\Resources\\aprovado.png");
            }

            if (telefono.Equals(""))
            {
                pictureTelefono.Image = System.Drawing.Image.FromFile("D:\\ingenieria en sistemas\\Fernando sexto semestre\\Programacion 5\\Programas n c# 6to semestre\\ProyectoProgV\\ProyectoProgV\\Resources\\error.png");
            }
            else
            {
                banderaTelefono = true;
                pictureTelefono.Image = System.Drawing.Image.FromFile("D:\\ingenieria en sistemas\\Fernando sexto semestre\\Programacion 5\\Programas n c# 6to semestre\\ProyectoProgV\\ProyectoProgV\\Resources\\aprovado.png");
            }

           
            
            if(banderaNombre && banderaApellido && banderaCedula && banderaCiudad&& banderaContra&& banderaDireccion&&banderaEmail && banderaTipo &&banderaUrl&& banderaUser &&banderaTelefono)
            {

                 if(banderaModificar== false)
                 {
                     Usuarios usuario = new Usuarios(codigo, cedula, nombre, apellido, direccion, telefono, email, user, contra, comboTipo, url, ciudad, estado);
                     int resultado = MetodosBD.InsertarUsuario(usuario);
                     if (resultado > 0)
                     {
                         MessageBox.Show("Datos guardados correctamente", "Mensaje de confirmación");
                         deshabilitar();
                         chEstado.Enabled = false;
                         txtCodigo.Text = "";
                         txtNombre.Text = "";
                         txtApellido.Text = "";
                         txtCedula.Text = "";
                         txtDireccion.Text = "";
                         txtEmail.Text = "";
                         txtTelefono.Text = "";
                         txtUsuario.Text = "";
                         txtPass.Text = "";
                         btnCargarFoto.Enabled = false;
                         pictureNombre.Image = null;

                         pictureApellido.Image = null;
                         pictureEstado.Image = null;
                         pictureCodigo.Image = null;


                         pictureDireccion.Image = null;

                         pictureCedula.Image = null;

                         pictureEmail.Image = null;

                         pictureUsuario.Image = null;

                         pictureContra.Image = null;

                         pictureFoto.Image = null;

                         pictureCiudad.Image = null;

                         pictureTipo.Image = null;

                         pictureTelefono.Image = null;
                         pictureBox1.Image = null;


                     }


                     dataGridView.DataSource = MetodosBD.cargarUsuarios2();
                 }
                 else
                 {
                     banderaModificar = false;
                     int resultado = MetodosBD.ActualizarUsuario(codigo, cedula, nombre, apellido, direccion, telefono, email, user, contra, comboTipo, url, ciudad, estado);
                     if (resultado > 0)
                     {
                         txtCodigo.Text = "";
                         txtNombre.Text = "";
                         txtApellido.Text = "";
                         txtCedula.Text = "";
                         txtDireccion.Text = "";
                         txtEmail.Text = "";
                         deshabilitar();
                         chEstado.Enabled = false;

                         btnCargarFoto.Enabled = false;
                         pictureNombre.Image = null;

                         pictureApellido.Image = null;
                         pictureEstado.Image = null;
                         pictureCodigo.Image = null;


                         pictureDireccion.Image = null;

                         pictureCedula.Image = null;

                         pictureEmail.Image = null;

                         pictureUsuario.Image = null;

                         pictureContra.Image = null;

                         pictureFoto.Image = null;

                         pictureCiudad.Image = null;

                         pictureTipo.Image = null;

                         pictureTelefono.Image = null;
                         pictureBox1.Image = null;

                         txtTelefono.Text = "";
                         txtUsuario.Text = "";
                         txtPass.Text = "";
                         MessageBox.Show("Dato Actualizado Correctamente", "Mensaje de Confirmación");
                         dataGridView.DataSource = MetodosBD.cargarUsuarios2();
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

        private void txtCedula_Leave(object sender, EventArgs e)
        {
            string cedula = txtCedula.Text;
            if(cedula.Equals(""))
            {

            }
            else
            {
                if(banderaModificar== false)
                {
                    if (MetodosBD.buscarCedula(cedula) == true)
                    {
                        txtCedula.Text = "";
                        txtCedula.Focus();
                        MessageBox.Show("La cedula " + cedula + " ya existe en la Base de datos", "Mensaje de Advertencia");
                    }

                    if (validacion.validarCedula(cedula) == false)
                    {
                        txtCedula.Text = "";
                        txtCedula.Focus();
                        MessageBox.Show("La cedula " + cedula + " no es válida", "Mensaje de Advertencia");
                    }
                }
                
                else
                {
                    if (validacion.validarCedula(cedula) == false)
                    {
                        txtCedula.Text = "";
                        txtCedula.Focus();
                        MessageBox.Show("La cedula " + cedula + " no es válida", "Mensaje de Advertencia");
                    }
                }
            }
          
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            string user = txtUsuario.Text;
            if(user.Equals(""))
            {

            }
            else
            {
                if (banderaModificar == false)
                {

                    if (MetodosBD.buscarUser(user) == true)
                    {
                        txtUsuario.Text = "";
                        txtUsuario.Focus();
                        MessageBox.Show("El usuario " + user + " ya existe en la Base de datos", "Mensaje de Advertencia");
                    }
                }
                 
            }
          
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
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

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string codigo = (string)dataGridView.CurrentRow.Cells["cod_empleado"].Value;
            btnModificar.Enabled = true;
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnEliminar.Enabled = true;


            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtCedula.Enabled = false;
            txtDireccion.Enabled = false;
            txtEmail.Enabled = false;
            txtPass.Enabled = false;
            btnCargarFoto.Enabled = false;
            txtUsuario.Enabled = false;

            txtTelefono.Enabled = false;
            cbTipoUsuario.Enabled = false;
            cbCiudad.Enabled = false;

               pictureCodigo.Image = null;
               pictureEstado.Image = null;
            
                pictureNombre.Image = null;
          
                pictureApellido.Image = null;
                pictureBox1.Image = null;



                pictureDireccion.Image = null;

                pictureCedula.Image = null;

                pictureEmail.Image = null;

                pictureUsuario.Image = null;

                pictureContra.Image = null;

                pictureFoto.Image = System.Drawing.Image.FromFile("D:\\ingenieria en sistemas\\Fernando sexto semestre\\Programacion 5\\Programas n c# 6to semestre\\ProyectoProgV\\ProyectoProgV\\Resources\\updown.png");

                pictureCiudad.Image = null;

                pictureTipo.Image = null;

                pictureTelefono.Image = null;
                chEstado.Enabled = false;

                using (SqlConnection conexion = Conexion.obtenerConexion())
                {
                    SqlCommand comando = new SqlCommand(string.Format("Select * from usuario where cod_empleado like '%{0}'", codigo), conexion);
                    SqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        txtCodigo.Text = reader.GetString(0);
                        txtCedula.Text = reader.GetString(1);
                        txtNombre.Text = reader.GetString(2);
                        txtApellido.Text = reader.GetString(3);
                        txtDireccion.Text = reader.GetString(4);
                        txtTelefono.Text = reader.GetString(5);
                        txtEmail.Text = reader.GetString(6);
                        txtUsuario.Text = reader.GetString(7);
                        txtPass.Text = reader.GetString(8);
                        cbTipoUsuario.SelectedItem = reader.GetString(9);
                        Direccion = reader.GetString(10);

                        pictureBox1.ImageLocation = reader.GetString(10);

                        string c = MetodosBD.buscarCiudad(reader.GetString(11));
                        cbCiudad.SelectedIndex = cbCiudad.FindString(c);
                        bool estado2 = reader.GetBoolean(12);
                        if(estado2)
                        {
                            chEstado.Text = "Activo";
                            chEstado.ForeColor = Color.Green;
                            contador = 0;
                            chEstado.Checked = false;
                            btnEliminar.Enabled = true;
                            estado = true;
                        }
                        else
                        {
                            chEstado.Text = "Inactivo";
                            chEstado.ForeColor = Color.Red;
                            chEstado.Checked = true;
                            btnEliminar.Enabled = false;
                            contador = contador + 1;
                            estado = true;
                        }
                        
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                        
                    }
                    conexion.Close();
                   

                }
           
            Console.Write(codigo);
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (rbCodigo.Checked)
            {
                
                DataTable dt = MetodosBD.cargarUsuarios2();
                string fieldName = string.Concat("[", dt.Columns[0].ColumnName, "]");
                dt.DefaultView.Sort = fieldName;
                DataView view = dt.DefaultView;
                view.RowFilter = string.Empty;
                if (txtBusqueda.Text != string.Empty)
                    view.RowFilter = fieldName + " LIKE '%" + txtBusqueda.Text + "%'";
                dataGridView.DataSource = view;
            }
           

            if (rbNombre.Checked)
            {
                
                DataTable dt = MetodosBD.cargarUsuarios2();
                string fieldName = string.Concat("[", dt.Columns[1].ColumnName, "]");
                dt.DefaultView.Sort = fieldName;
                DataView view = dt.DefaultView;
                view.RowFilter = string.Empty;
                if (txtBusqueda.Text != string.Empty)
                    view.RowFilter = fieldName + " LIKE '%" + txtBusqueda.Text + "%'";
                dataGridView.DataSource = view;
            }


            if (rbCedula.Checked)
            {

                DataTable dt = MetodosBD.cargarUsuarios2();
                string fieldName = string.Concat("[", dt.Columns[3].ColumnName, "]");
                dt.DefaultView.Sort = fieldName;
                DataView view = dt.DefaultView;
                view.RowFilter = string.Empty;
                if (txtBusqueda.Text != string.Empty)
                    view.RowFilter = fieldName + " LIKE '%" + txtBusqueda.Text + "%'";
                dataGridView.DataSource = view;
            }
           
           
        }

        private void rbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            txtBusqueda.Enabled = true;
        }

        private void rbNombre_CheckedChanged(object sender, EventArgs e)
        {
            txtBusqueda.Enabled = true;
        }

        private void rbCedula_CheckedChanged(object sender, EventArgs e)
        {
            txtBusqueda.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            banderaModificar = true;
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtCedula.Enabled = true;
            txtDireccion.Enabled = true;
            chEstado.Enabled = true;
            txtEmail.Enabled = true;
            txtPass.Enabled = true;
            txtTelefono.Enabled = true;
            cbTipoUsuario.Enabled = true;
            cbCiudad.Enabled = true;
            txtUsuario.Enabled = true;
            btnCargarFoto.Enabled = true;
        }

        private void dataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int count = 0; count < dataGridView.Rows.Count; count++)
            {
                string codigo = (string)dataGridView.Rows[count].Cells["cod_empleado"].Value;
                bool estado = MetodosBD.buscarEstado(codigo);
                if(estado == false)
                {
                    dataGridView.Rows[count].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

       

        private void chEstado_Click(object sender, EventArgs e)
        {
            
            if(contador==0)
            {
                chEstado.Text = "Inactivo";
                chEstado.ForeColor = Color.Red;
                contador = contador + 1;
                estado = false;

            }
            else
            {
                chEstado.Text = "Activo";
                chEstado.ForeColor = Color.Green;
                contador = 0;
                estado = true;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            resultado = MessageBox.Show("¿Desea dar de baja a este registro?","Mensaje de confimación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado.Equals(DialogResult.Yes))
            {
                string codigo = (string)dataGridView.CurrentRow.Cells["cod_empleado"].Value;
                int resultado2 = MetodosBD.ActualizarEstadoUsuario(codigo, false);
                if (resultado2 > 0)
                {

                    MessageBox.Show("Registro dado de baja exitosamente¡¡", "Mensaje de Confirmación");
                    chEstado.Text = "Inactivo";
                    chEstado.ForeColor = Color.Red;
                    btnEliminar.Enabled = false;
                    dataGridView.DataSource = MetodosBD.cargarUsuarios2();
                }
            }
            else
            {
                
            }
        }

        

    }
}
