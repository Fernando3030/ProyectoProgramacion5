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

namespace ProyectoProgV
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public static string ROL = "";
        public static bool Activo = false;
        public static int roles = 0;
        string user;
        string contra;
        DialogResult resultado;
        public Login()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            resultado = MetroFramework.MetroMessageBox.Show(this, "Seguro que desea salir?", "Mensaje Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resultado.Equals(DialogResult.Yes))
            {
                this.Close();
            }
            
    
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            user = txtUser.Text;
            contra = txtPassword.Text;
            Console.Write("la contra es " + contra );
            bool resultado = MetodosBD.buscarUsuario(user, contra);
            if(user.Equals("") || contra.Equals(""))
            {
                MessageBox.Show("debe llenar todos los campos");
            }
            else
            {
                if (resultado)
                {
                    ROL = user;
                    bool estado = MetodosBD.buscarEstadoTrabajador(user);
                    if(estado)
                    {
                        if (MetodosBD.tipoUser.Equals("Administrador"))
                        {
                            Console.Write("es un administrador");
                            RegistroUsuarios usuarios = new RegistroUsuarios();
                            usuarios.Show();
                            this.Hide();
                            Activo = true;
                            roles = 0;

                        }
                        else
                        {
                            if (MetodosBD.tipoUser.Equals("Secretaria"))
                            {
                                Console.Write("es una secretaria");
                                roles = 1;
                                Activo = false;
                                VentanaPrincipalNuevo ventana = new VentanaPrincipalNuevo();
                                ventana.Show();
                                this.Hide();
                               

                            }
                            else
                            {
                                Console.Write("es un empleado");
                                roles = 2;
                                Activo = false;
                                VentanaPrincipalNuevo ventana = new VentanaPrincipalNuevo();
                                ventana.Show();
                                this.Hide();
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Usted esta inactivo dentro del sistema", "Mensaje de advertencia");
                        txtUser.Text = "";
                        txtPassword.Text = "";
                        txtUser.Focus();
                    
                    }
                    
                   
                   
                }
                else
                {
                    MessageBox.Show("Usuario no registrado");
                }

            }
           

           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtUser.Focus();
            this.ActiveControl = txtUser;
            double x = 117;
            double y =117;
            double z = x - y;
            Console.Write(z);
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                user = txtUser.Text;
                contra = txtPassword.Text;
                Console.Write("la contra es " + contra);
                bool resultado = MetodosBD.buscarUsuario(user, contra);
                if (user.Equals("") || contra.Equals(""))
                {
                    MessageBox.Show("debe llenar todos los campos");
                }
                else
                {
                    if (resultado)
                    {
                        ROL = user;
                        bool estado = MetodosBD.buscarEstadoTrabajador(user);
                        if (estado)
                        {
                            if (MetodosBD.tipoUser.Equals("Administrador"))
                            {
                                Console.Write("es un administrador");
                                RegistroUsuarios usuarios = new RegistroUsuarios();
                                usuarios.Show();
                                this.Hide();
                                Activo = true;
                                roles = 0;

                            }
                            else
                            {
                                if (MetodosBD.tipoUser.Equals("Secretaria"))
                                {
                                    Console.Write("es una secretaria");
                                    roles = 1;
                                    Activo = false;
                                    VentanaPrincipalNuevo ventana = new VentanaPrincipalNuevo();
                                    ventana.Show();
                                    this.Hide();


                                }
                                else
                                {
                                    Console.Write("es un empleado");
                                    roles = 2;
                                    Activo = false;
                                    VentanaPrincipalNuevo ventana = new VentanaPrincipalNuevo();
                                    ventana.Show();
                                    this.Hide();
                                }
                            }

                        }
                        else
                        {
                            MessageBox.Show("Usted esta inactivo dentro del sistema", "Mensaje de advertencia");
                            txtUser.Text = "";
                            txtPassword.Text = "";
                            txtUser.Focus();

                        }



                    }
                    else
                    {
                        MessageBox.Show("Usuario no registrado");
                    }
                }
            }
        }

       


           

       }
}
