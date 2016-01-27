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
    public partial class RegistroClientes : MetroFramework.Forms.MetroForm
    {

        Validaciones validacion = new Validaciones();
        String codigo = "";
        bool banderaModificar = false;
        int contador = 0;
        bool estado = true;
        DialogResult resultado;
        string nombreCompleto = "";
        string cedula2 = "";
        string dir = "";
        string telf = "";
        
        public RegistroClientes()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            codigo = validacion.generarCodigo();
            txtCodigo.Text = codigo;
            txtCedula.Focus();
            pictureCodigo.Image = System.Drawing.Image.FromFile("D:\\ingenieria en sistemas\\Fernando sexto semestre\\Programacion 5\\Programas n c# 6to semestre\\ProyectoProgV\\ProyectoProgV\\Resources\\aprovado.png");
            habilitar();
            pictureEstado.Image = System.Drawing.Image.FromFile("D:\\ingenieria en sistemas\\Fernando sexto semestre\\Programacion 5\\Programas n c# 6to semestre\\ProyectoProgV\\ProyectoProgV\\Resources\\aprovado.png");
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            banderaModificar = false;
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCedula.Text = "";
            txtDireccion.Text = "";
            txtEmail.Text = "";
            chEstado.Text = "Activo";
            chEstado.Checked = false;
            chEstado.Enabled = true;
            chEstado.ForeColor = Color.Green;
            contador = 0;
            estado = true;

            pictureNombre.Image = null;

            pictureApellido.Image = null;


            pictureDireccion.Image = null;

            pictureCedula.Image = null;

            pictureEmail.Image = null;
            pictureCiudad.Image = null;
            pictureTelefono.Image = null;

            txtTelefono.Text = "";
        
            dataGridView.ClearSelection();



        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            VentanaPrincipalNuevo ventana = new VentanaPrincipalNuevo();
            ventana.Show();
        }

        private void RegistroClientes_Load(object sender, EventArgs e)
        {
            cbCiudad.DisplayMember = "Ciud";  // el Ciud es el get y set de la clase Ciudad
            cbCiudad.ValueMember = "Codigo"; // Codigo es el get y set de la clase Ciudad
            cbCiudad.DataSource = MetodosBD.cargarCiudad();

            dataGridView.Rows.Clear();
            if(BuscarCliente.banderaCliente== true)
            {
                btnSalir.Visible = false;
                btnSalir2.Visible = true;
                BuscarCliente.banderaCliente = false;

            }
            else
            {
                btnSalir.Visible = true;
                btnSalir2.Visible = false;
            }


            dataGridView.DataSource = MetodosBD.cargarClientes();

            dataGridView.ClearSelection();
            deshabilitar();
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

        public void habilitar()
        {
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtCedula.Enabled = true;
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
            txtApellido.Enabled = false;
            txtCedula.Enabled = false;
            txtDireccion.Enabled = false;
            txtEmail.Enabled = false;
          
            txtTelefono.Enabled = false;
           
            cbCiudad.Enabled = false;

            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;


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

        private void txtCedula_Leave(object sender, EventArgs e)
        {
            string cedula = txtCedula.Text;
            if (cedula.Equals(""))
            {

            }
            else
            {
                if (banderaModificar == false)
                {
                    if (MetodosBD.buscarCedulaCliente(cedula) == true)
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string direccion = txtDireccion.Text;
            string telefono = txtTelefono.Text;
            string cedula = txtCedula.Text;
            string email = txtEmail.Text;
            string ciudad = cbCiudad.SelectedValue.ToString();

            bool banderaNombre = false;
            bool banderaApellido = false;
            bool banderaDireccion = false;
            bool banderaCedula = false;
            bool banderaEmail = false;
    
            bool banderaCiudad = false;
            
            bool banderaTelefono = false;

            if (nombre.Equals(""))
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


            if (banderaNombre && banderaApellido && banderaCedula && banderaCiudad  && banderaDireccion && banderaEmail  && banderaTelefono)
            {

                if (banderaModificar == false)
                {
                    Cliente cliente = new Cliente(codigo, cedula, nombre, apellido, direccion, telefono, email, ciudad, estado);
                    nombreCompleto = nombre + " " + apellido;
                    cedula2 = cedula;
                    dir = direccion;
                    telf = telefono;
                    int resultado = MetodosBD.InsertarCliente(cliente);
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
                      
                        pictureNombre.Image = null;

                        pictureApellido.Image = null;
                        pictureEstado.Image = null;
                        pictureCodigo.Image = null;


                        pictureDireccion.Image = null;

                        pictureCedula.Image = null;

                        pictureEmail.Image = null;

                       

                        pictureCiudad.Image = null;

                       
                        pictureTelefono.Image = null;
                        contador = 0;

                        


                    }


                    dataGridView.DataSource = MetodosBD.cargarClientes();
                }
                else
                {
                    bool estado2 = false;
                    if (contador == 0)
                    {
                        estado2 = MetodosBD.buscarEstadoCliente(txtCodigo.Text);

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
                    int resultado = MetodosBD.ActualizarCliente(codigo, cedula, nombre, apellido, direccion, telefono, email,  ciudad, estado2);
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

                        
                        pictureNombre.Image = null;

                        pictureApellido.Image = null;
                        pictureEstado.Image = null;
                        pictureCodigo.Image = null;


                        pictureDireccion.Image = null;

                        pictureCedula.Image = null;

                        pictureEmail.Image = null;

                        

                        pictureCiudad.Image = null;

                       

                        pictureTelefono.Image = null;
                 
                        txtTelefono.Text = "";
                       
                        MessageBox.Show("Dato Actualizado Correctamente", "Mensaje de Confirmación");
                        dataGridView.DataSource = MetodosBD.cargarClientes();
                    }
                    else
                    {
                        MessageBox.Show("Datos no actualizado", "Mensaje de advertencia");
                    }
                }

            }
            else
            {
                MessageBox.Show("Algún campo esta erróneo o vacío", "Mensaje de Advertencia");
            }


        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string codigo = (string)dataGridView.CurrentRow.Cells["cod_cliente"].Value;
            btnModificar.Enabled = true;
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnEliminar.Enabled = true;


            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtCedula.Enabled = false;
            txtDireccion.Enabled = false;
            txtEmail.Enabled = false;


            txtTelefono.Enabled = false;
            
            cbCiudad.Enabled = false;

            pictureCodigo.Image = null;
            pictureEstado.Image = null;

            pictureNombre.Image = null;

            pictureApellido.Image = null;
          



            pictureDireccion.Image = null;

            pictureCedula.Image = null;

            pictureEmail.Image = null;

           

            pictureCiudad.Image = null;

           

            pictureTelefono.Image = null;
            chEstado.Enabled = false;

            using (SqlConnection conexion = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Select * from cliente where cod_cliente like '%{0}'", codigo), conexion);
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

                    string c = MetodosBD.buscarCiudad(reader.GetString(7));
                    cbCiudad.SelectedIndex = cbCiudad.FindString(c);
                    
                  
                    bool estado2 = reader.GetBoolean(8);
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

                DataTable dt = MetodosBD.cargarClientes();
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

                DataTable dt = MetodosBD.cargarClientes();
                string fieldName = string.Concat("[", dt.Columns[2].ColumnName, "]");
                dt.DefaultView.Sort = fieldName;
                DataView view = dt.DefaultView;
                view.RowFilter = string.Empty;
                if (txtBusqueda.Text != string.Empty)
                    view.RowFilter = fieldName + " LIKE '%" + txtBusqueda.Text + "%'";
                dataGridView.DataSource = view;
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
                dataGridView.DataSource = view;
            }
        }

        private void rbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            txtBusqueda.Enabled = true;
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
            txtApellido.Enabled = true;
            txtCedula.Enabled = true;
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
                string codigo = (string)dataGridView.Rows[count].Cells["cod_cliente"].Value;
                bool estado = MetodosBD.buscarEstadoCliente(codigo);
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
                string codigo = (string)dataGridView.CurrentRow.Cells["cod_cliente"].Value;
                int resultado2 = MetodosBD.ActualizarEstadoCliente(codigo, false);
                if (resultado2 > 0)
                {

                    MessageBox.Show("Registro dado de baja exitosamente¡¡", "Mensaje de Confirmación");
                    chEstado.Text = "Inactivo";
                    chEstado.ForeColor = Color.Red;
                    btnEliminar.Enabled = false;
                    dataGridView.DataSource = MetodosBD.cargarClientes();
                }
            }
            else
            {

            }
        }

        private void btnSalir2_Click(object sender, EventArgs e)
        {
            this.Close();
            FacturaCliente.guardar = true;
            FacturaCliente.rbConsu = true;
            FacturaCliente.rbFact = true;
           
            FacturaCliente.rbCod = true;
            FacturaCliente.rbProdu = true;
            FacturaCliente.txtBusq = true;
            FacturaCliente.dataGridPro = true;

            FacturaCliente.txtCant = true;
            FacturaCliente.btnA = true;
            FacturaCliente factCliente = new FacturaCliente();
            factCliente.txtCliente.Text = nombreCompleto;
            factCliente.txtRUC.Text = cedula2;
            factCliente.txtDireccion.Text = dir;
            factCliente.txtTelefono.Text = telf;
            factCliente.Show();
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
