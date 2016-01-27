using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoProgV
{
    public partial class Profile : MetroFramework.Forms.MetroForm
    {

        
        string codigo="";
        string cedula="";
        string nombre="";
        string apellido="";
        string direccion="";
        string telefono="";
        string email = "";
        string user="";
        string pass="";
        string tipoUser="";
        string Direccion="";
        string ciudad="";
        bool estado=false;
        

                   
                   

        public Profile()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
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

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
           
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pictureBox1.Width - 3, pictureBox1.Height - 3);
          
            Region rg = new Region(gp);
     
            pictureBox1.Region = rg;
             e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

         

            
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

        private void panelTransparente1_MouseEnter(object sender, EventArgs e)
        {
            Console.WriteLine("entroo");
            panelTransparente1.BackgroundImage = System.Drawing.Image.FromFile("D:\\ingenieria en sistemas\\Fernando sexto semestre\\Programacion 5\\Programas n c# 6to semestre\\ProyectoProgV\\ProyectoProgV\\Resources\\camarita.jpg");
            
           
        }

        private void panelTransparente1_Click(object sender, EventArgs e)
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
            }
        }

        public void cargarDatos()
        {
            using (SqlConnection conexion = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Select * from usuario where user_empleado like '%{0}'", Login.ROL), conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    codigo = reader.GetString(0);
                    cedula = reader.GetString(1);
                    nombre = reader.GetString(2);
                    apellido = reader.GetString(3);
                    direccion= reader.GetString(4);
                   telefono = reader.GetString(5);
                    email= reader.GetString(6);
                    user = reader.GetString(7);
                    pass = reader.GetString(8);
                   tipoUser = reader.GetString(9);
                    Direccion = reader.GetString(10);
                    


                    ciudad = reader.GetString(11);
                  
                   estado = reader.GetBoolean(12);


                   this.pictureBox1.ImageLocation = Direccion;
                   pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;


                }
                conexion.Close();


            }
        }

        private void Profile_Load(object sender, EventArgs e)
        {

            cargarDatos();
           
            lblUser.Text = user;
            lblNombre.Text = nombre;
            lblApellido.Text = apellido;
            lblCedula.Text = cedula;
            lblDireccion.Text = direccion;
            lblTelefono.Text = telefono;
            lblEmail.Text = email;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            VentanaPrincipalNuevo ventana = new VentanaPrincipalNuevo();
            ventana.Show();

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string usuario=txtUsuario.Text;
            string contraA=txtContraAntigua.Text;
            string contraN=txtContraNueva.Text;

            if(usuario.Equals("") || contraA.Equals("") || contraN.Equals("") )
            {
                MessageBox.Show("Algun campo está vacio");


            }
            else
            {
                string contraVieja = MetodosBD.buscarContra(codigo);
                if(contraA.Equals(contraVieja))
                {
                    // se guarda en la BD
                    Login.ROL = usuario;
                    Console.WriteLine(Direccion);
                    int resultado = MetodosBD.ActualizarUsuario2(codigo, Direccion, usuario, contraN);
                    if(resultado >0)
                    {
                        MessageBox.Show("Datos actualizados correctamente");
                        txtUsuario.Text = "";
                        txtContraAntigua.Text = "";
                        txtContraNueva.Text = "";
                        lblUser.Text = usuario;


                    }
                }
                else
                {
                    txtContraAntigua.Text = "";
                    txtContraAntigua.Focus();
                    MessageBox.Show("Las contraseñas no coinciden");
                }
            }
        }

       
    }
}
