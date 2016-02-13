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
    public partial class RegistroProveedores : MetroFramework.Forms.MetroForm
    {

        Validaciones validacion = new Validaciones();
        String codigo = "";
        bool banderaModificar = false;
        int contador = 0;
        bool estado = true;
        DialogResult resultado;
        public RegistroProveedores()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            VentanaPrincipalNuevo ventana = new VentanaPrincipalNuevo();
            ventana.Show();
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

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            if (email.Equals(""))
            {

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

        private void txtRuc_Leave(object sender, EventArgs e)
        {
            string cedula = txtRuc.Text;
            if (cedula.Equals(""))
            {

            }
            else
            {
                if (banderaModificar == false)
                {
                    if (MetodosBD.buscarRucProveedor(cedula) == true)
                    {
                        txtRuc.Text = "";
                        txtRuc.Focus();
                        MessageBox.Show("El RUC " + cedula + " ya existe en la Base de datos", "Mensaje de Advertencia");
                    }

                    if (validacion.validarRuc(cedula) == false)
                    {
                        txtRuc.Text = "";
                        txtRuc.Focus();
                        MessageBox.Show("El RUC " + cedula + " no es válida", "Mensaje de Advertencia");
                    }
                }

                else
                {
                    if (validacion.validarRuc(cedula) == false)
                    {
                        txtRuc.Text = "";
                        txtRuc.Focus();
                        MessageBox.Show("El RUC " + cedula + " no es válida", "Mensaje de Advertencia");
                    }
                }
            }
        }

        private void RegistroProveedores_Load(object sender, EventArgs e)
        {
            dateFecha.MaxDate = DateTime.Today;
            cbCiudad.DisplayMember = "Ciud";  // el Ciud es el get y set de la clase Ciudad
            cbCiudad.ValueMember = "Codigo"; // Codigo es el get y set de la clase Ciudad
            cbCiudad.DataSource = MetodosBD.cargarCiudad();

            dataGridView.Rows.Clear();


            dataGridView.DataSource = MetodosBD.cargarProveedores();

            dataGridView.Columns[0].HeaderText = "Código";
            dataGridView.Columns[1].HeaderText = "Proveedor";
            dataGridView.Columns[2].HeaderText = "RUC";
            dataGridView.Columns[3].HeaderText = "Dirección";
            dataGridView.Columns[4].HeaderText = "Teléfono";
            dataGridView.Columns[5].HeaderText = "Email";
        

            dataGridView.ClearSelection();
            deshabilitar();
        }

        public void habilitar()
        {
            txtNombre.Enabled = true;

            txtRuc.Enabled = true;
            txtDireccion.Enabled = true;
            txtEmail.Enabled = true;

            txtTelefono.Enabled = true;

            cbCiudad.Enabled = true;

            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;

        }


        public void deshabilitar()
        {
            txtNombre.Enabled = false;

            txtRuc.Enabled = false;
            txtDireccion.Enabled = false;
            txtEmail.Enabled = false;

            txtTelefono.Enabled = false;

            cbCiudad.Enabled = false;

            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;


        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            codigo = validacion.generarCodigo();
            txtCodigo.Text = codigo;
            txtNombre.Focus();
            pictureCodigo.Image = System.Drawing.Image.FromFile("D:\\ingenieria en sistemas\\Fernando sexto semestre\\Programacion 5\\Programas n c# 6to semestre\\ProyectoProgV\\ProyectoProgV\\Resources\\aprovado.png");
            habilitar();
            pictureEstado.Image = System.Drawing.Image.FromFile("D:\\ingenieria en sistemas\\Fernando sexto semestre\\Programacion 5\\Programas n c# 6to semestre\\ProyectoProgV\\ProyectoProgV\\Resources\\aprovado.png");
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            banderaModificar = false;
            txtNombre.Text = "";

            txtRuc.Text = "";
            txtDireccion.Text = "";
            txtEmail.Text = "";
            chEstado.Text = "Activo";
            chEstado.Checked = false;
            chEstado.Enabled = true;
            chEstado.ForeColor = Color.Green;
            contador = 0;
            estado = true;
            dateFecha.Enabled = true;

            pictureNombre.Image = null;
            pictureFecha.Image = null;



            pictureDireccion.Image = null;

            pictureCedula.Image = null;

            pictureEmail.Image = null;
            pictureCiudad.Image = null;
            pictureTelefono.Image = null;

            txtTelefono.Text = "";

            dataGridView.ClearSelection();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            pictureFecha.Image = System.Drawing.Image.FromFile("D:\\ingenieria en sistemas\\Fernando sexto semestre\\Programacion 5\\Programas n c# 6to semestre\\ProyectoProgV\\ProyectoProgV\\Resources\\aprovado.png");
            string codigo = txtCodigo.Text;
            string nombre = txtNombre.Text;

            string direccion = txtDireccion.Text;
            string telefono = txtTelefono.Text;
            string cedula = txtRuc.Text;
            string email = txtEmail.Text;
            string ciudad = cbCiudad.SelectedValue.ToString();

            bool banderaNombre = false;

            bool banderaDireccion = false;
            bool banderaCedula = false;
            bool banderaEmail = false;

            bool banderaCiudad = false;

            bool banderaTelefono = false;
            

            DateTime fecha = dateFecha.Value;
            string fechita = fecha.ToString("d");

            if (nombre.Equals(""))
            {
                pictureNombre.Image = System.Drawing.Image.FromFile("D:\\ingenieria en sistemas\\Fernando sexto semestre\\Programacion 5\\Programas n c# 6to semestre\\ProyectoProgV\\ProyectoProgV\\Resources\\error.png");
            }
            else
            {
                banderaNombre = true;
                pictureNombre.Image = System.Drawing.Image.FromFile("D:\\ingenieria en sistemas\\Fernando sexto semestre\\Programacion 5\\Programas n c# 6to semestre\\ProyectoProgV\\ProyectoProgV\\Resources\\aprovado.png");
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

            if (ciudad.Equals(""))
            {
                pictureCiudad.Image = System.Drawing.Image.FromFile("D:\\ingenieria en sistemas\\Fernando sexto semestre\\Programacion 5\\Programas n c# 6to semestre\\ProyectoProgV\\ProyectoProgV\\Resources\\error.png");
            }
            else
            {
                banderaCiudad = true;
                pictureCiudad.Image = System.Drawing.Image.FromFile("D:\\ingenieria en sistemas\\Fernando sexto semestre\\Programacion 5\\Programas n c# 6to semestre\\ProyectoProgV\\ProyectoProgV\\Resources\\aprovado.png");
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


            if (banderaNombre && banderaCedula && banderaCiudad && banderaDireccion && banderaEmail && banderaTelefono)
            {

                if (banderaModificar == false)
                {
                    Proveedor proveedor = new Proveedor(codigo, nombre, cedula, direccion, telefono, email, ciudad, estado, fechita);
                    int resultado = MetodosBD.InsertarProveedor(proveedor);
                    if (resultado > 0)
                    {
                        MessageBox.Show("Datos guardados correctamente", "Mensaje de confirmación");
                        deshabilitar();
                        chEstado.Enabled = false;
                        txtCodigo.Text = "";
                        txtNombre.Text = "";

                        txtRuc.Text = "";
                        txtDireccion.Text = "";
                        txtEmail.Text = "";
                        txtTelefono.Text = "";

                        pictureNombre.Image = null;


                        pictureEstado.Image = null;
                        pictureCodigo.Image = null;


                        pictureDireccion.Image = null;

                        pictureCedula.Image = null;

                        pictureEmail.Image = null;
                        pictureFecha.Image = null;



                        pictureCiudad.Image = null;


                        pictureTelefono.Image = null;
                        contador = 0;



                    }


                    dataGridView.DataSource = MetodosBD.cargarProveedores();
                }
                else
                {
                    bool estado2 = false;
                    if (contador == 0)
                    {
                        estado2 = MetodosBD.buscarEstadoProveedor(txtCodigo.Text);

                    }
                    else
                    {
                        if (contador == 1)
                        {
                            estado2 = estado;
                            contador = 0;
                        }

                    }
                    banderaModificar = false;
                    int resultado = MetodosBD.ActualizarProveedor(codigo, nombre, cedula, direccion, telefono, email, ciudad, estado2, fechita);
                    if (resultado > 0)
                    {
                        txtCodigo.Text = "";
                        txtNombre.Text = "";

                        txtRuc.Text = "";
                        txtDireccion.Text = "";
                        txtEmail.Text = "";
                        deshabilitar();
                        chEstado.Enabled = false;


                        pictureNombre.Image = null;


                        pictureEstado.Image = null;
                        pictureCodigo.Image = null;

                        pictureFecha.Image = null;
                        pictureDireccion.Image = null;

                        pictureCedula.Image = null;

                        pictureEmail.Image = null;



                        pictureCiudad.Image = null;



                        pictureTelefono.Image = null;

                        txtTelefono.Text = "";

                        MessageBox.Show("Dato Actualizado Correctamente", "Mensaje de Confirmación");
                        dataGridView.DataSource = MetodosBD.cargarProveedores();
                    }
                    else
                    {
                        MessageBox.Show("Datos no actualizado", "Mensaje de advertencia");
                    }
                }
            }
            else
            {
                MessageBox.Show("Algún dato esta erroneo o vacío", "Mensaje de advertencia");
            }
        }

        private void rbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            txtBusqueda.Enabled = true;
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string codigo = (string)dataGridView.CurrentRow.Cells["cod_proveedor"].Value;
            btnModificar.Enabled = true;
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnEliminar.Enabled = true;


            txtNombre.Enabled = false;
        
            txtRuc.Enabled = false;
            txtDireccion.Enabled = false;
            txtEmail.Enabled = false;
            dateFecha.Enabled = false;


            txtTelefono.Enabled = false;

            cbCiudad.Enabled = false;

            pictureCodigo.Image = null;
            pictureEstado.Image = null;

            pictureNombre.Image = null;

       




            pictureDireccion.Image = null;

            pictureCedula.Image = null;

            pictureEmail.Image = null;


            pictureFecha.Image = null;
            pictureCiudad.Image = null;



            pictureTelefono.Image = null;
            chEstado.Enabled = false;

            using (SqlConnection conexion = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Select * from proveedor where cod_proveedor like '%{0}'", codigo), conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    txtCodigo.Text = reader.GetString(0);
                 
                    txtNombre.Text = reader.GetString(1);
                    txtRuc.Text = reader.GetString(2);
                    
                    txtDireccion.Text = reader.GetString(3);
                    txtTelefono.Text = reader.GetString(4);
                    txtEmail.Text = reader.GetString(5);
                    string c = MetodosBD.buscarCiudad(reader.GetString(6));
                    cbCiudad.SelectedIndex = cbCiudad.FindString(c);
                 
                    bool estado2 = reader.GetBoolean(7);
                    dateFecha.Value = Convert.ToDateTime(reader.GetString(8));
                    if (estado2)
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




                }
                conexion.Close();


            }

            Console.Write(codigo);
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (rbCodigo.Checked)
            {

                DataTable dt = MetodosBD.cargarProveedores();
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

                DataTable dt = MetodosBD.cargarProveedores();
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

                DataTable dt = MetodosBD.cargarProveedores();
                string fieldName = string.Concat("[", dt.Columns[2].ColumnName, "]");
                dt.DefaultView.Sort = fieldName;
                DataView view = dt.DefaultView;
                view.RowFilter = string.Empty;
                if (txtBusqueda.Text != string.Empty)
                    view.RowFilter = fieldName + " LIKE '%" + txtBusqueda.Text + "%'";
                dataGridView.DataSource = view;
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            banderaModificar = true;
            txtNombre.Enabled = true;
            dateFecha.Enabled = true;
            
            txtRuc.Enabled = true;
            txtDireccion.Enabled = true;
            chEstado.Enabled = true;
            txtEmail.Enabled = true;

            txtTelefono.Enabled = true;

            cbCiudad.Enabled = true;
        }

        private void dataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int count = 0; count < dataGridView.Rows.Count; count++)
            {
                string codigo = (string)dataGridView.Rows[count].Cells["cod_proveedor"].Value;
                bool estado = MetodosBD.buscarEstadoProveedor(codigo);
                if (estado == false)
                {
                    dataGridView.Rows[count].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        private void chEstado_Click(object sender, EventArgs e)
        {
            contador = 1;
            Console.WriteLine("el contador es " + contador);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            resultado = MessageBox.Show("¿Desea dar de baja a este registro?", "Mensaje de confimación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado.Equals(DialogResult.Yes))
            {
                string codigo = (string)dataGridView.CurrentRow.Cells["cod_proveedor"].Value;
                int resultado2 = MetodosBD.ActualizarEstadoProveedor(codigo, false);
                if (resultado2 > 0)
                {

                    MessageBox.Show("Registro dado de baja exitosamente¡¡", "Mensaje de Confirmación");
                    chEstado.Text = "Inactivo";
                    chEstado.ForeColor = Color.Red;
                    btnEliminar.Enabled = false;
                    dataGridView.DataSource = MetodosBD.cargarProveedores();
                }
            }
            else
            {

            }
        }

        private void chEstado_CheckedChanged(object sender, EventArgs e)
        {
            if (chEstado.Checked)
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





    }
}
