
using System;
using System.Collections;
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
    
    public partial class RegistrarProducto : MetroFramework.Forms.MetroForm
    {

        Validaciones validacion = new Validaciones();
        String codigo = "";
        bool banderaModificar = false;
        int contador = 0;
        bool estado = true;
        
        DialogResult resultado;

        public RegistrarProducto()
        {
            InitializeComponent();
        }

       

       

        private void RegistrarProducto_Load(object sender, EventArgs e)
        {
            cbCategoria.DisplayMember = "Categoria1";  // el Ciud es el get y set de la clase Categoria
            cbCategoria.ValueMember = "Codigo"; // Codigo es el get y set de la clase Categoria
            cbCategoria.DataSource = MetodosBD.cargarCategoria2();
           
           
            cbProveedor.DisplayMember = "Nombre";  // el Ciud es el get y set de la clase Categoria
            cbProveedor.ValueMember = "Codigo"; // Codigo es el get y set de la clase Categoria
            cbProveedor.DataSource = MetodosBD.cargarProveedor2();

            dataGridView.Rows.Clear();
            dataGridView.DataSource = MetodosBD.cargarProductos();

           

            dataGridView.ClearSelection();
            deshabilitar();
           
        }

        
        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            codigo = validacion.generarCodigo();
            txtCodigo.Text = codigo;
            txtProducto.Focus();
            pictureCodigo.Image = System.Drawing.Image.FromFile("D:\\ingenieria en sistemas\\Fernando sexto semestre\\Programacion 5\\Programas n c# 6to semestre\\ProyectoProgV\\ProyectoProgV\\Resources\\aprovado.png");
            habilitar();
            pictureEstado.Image = System.Drawing.Image.FromFile("D:\\ingenieria en sistemas\\Fernando sexto semestre\\Programacion 5\\Programas n c# 6to semestre\\ProyectoProgV\\ProyectoProgV\\Resources\\aprovado.png");
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            banderaModificar = false;
            txtStock.Text = "";
            txtPrecioC.Text = "";
            txtPrecioV.Text = "";
           
            chEstado.Text = "Activo";
            chEstado.Checked = false;
            chEstado.Enabled = true;
            chEstado.ForeColor = Color.Green;
            contador = 0;
            estado = true;

            pictureCategoria.Image = null;

            pictureProducto.Image = null;


            pictureProveedor.Image = null;

            pictureFecha.Image = null;

            pictureStock.Image = null;
            picturePrecioC.Image = null;
            picturePrecioV.Image = null;

          

            dataGridView.ClearSelection();


        }


        public void habilitar()
        {
            txtProducto.Enabled = true;
            cbCategoria.Enabled = true;
            cbProveedor.Enabled = true;
            dateFecha.Enabled = true;
            txtStock.Enabled = true;

            txtPrecioC.Enabled = true;

            txtPrecioV.Enabled = true;

            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;

        }


        public void deshabilitar()
        {
            txtProducto.Enabled = false;
            cbCategoria.Enabled = false;
            cbProveedor.Enabled = false;
            dateFecha.Enabled = false;
            txtStock.Enabled = false;

            txtPrecioC.Enabled = false;

            txtPrecioV.Enabled = false;
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;
            string producto = txtProducto.Text;
            
            string stock2 = Convert.ToString(txtStock.Text);
            int stock = Convert.ToInt32(txtStock.Text);
           // float precioC = float.Parse(txtPrecioC.Text);


            double precioC = Convert.ToDouble(txtPrecioC.Text);
           
           
            string precioC2 = Convert.ToString(precioC);




            double precioV = Convert.ToDouble(txtPrecioV.Text);
            
         
           

                       
            string precioV2 = Convert.ToString(precioV);

            
            
           
            DateTime fecha = dateFecha.Value;
            string fechita = fecha.ToString("d");
            string categoria = cbCategoria.SelectedValue.ToString();
            string proveedor = cbProveedor.SelectedValue.ToString();

            bool banderaProducto = false;
            bool banderaStock = false;
            bool banderaPrecioC = false;
            bool banderaPrecioV = false;


            if (producto.Equals(""))
            {
                pictureProducto.Image = System.Drawing.Image.FromFile("D:\\ingenieria en sistemas\\Fernando sexto semestre\\Programacion 5\\Programas n c# 6to semestre\\ProyectoProgV\\ProyectoProgV\\Resources\\error.png");
            }
            else
            {
                banderaProducto = true;
                pictureProducto.Image = System.Drawing.Image.FromFile("D:\\ingenieria en sistemas\\Fernando sexto semestre\\Programacion 5\\Programas n c# 6to semestre\\ProyectoProgV\\ProyectoProgV\\Resources\\aprovado.png");
            }

            if (stock2.Equals(""))
            {
                pictureStock.Image = System.Drawing.Image.FromFile("D:\\ingenieria en sistemas\\Fernando sexto semestre\\Programacion 5\\Programas n c# 6to semestre\\ProyectoProgV\\ProyectoProgV\\Resources\\error.png");
            }
            else
            {
                banderaStock = true;
                pictureStock.Image = System.Drawing.Image.FromFile("D:\\ingenieria en sistemas\\Fernando sexto semestre\\Programacion 5\\Programas n c# 6to semestre\\ProyectoProgV\\ProyectoProgV\\Resources\\aprovado.png");
            }

            if (precioC2.Equals(""))
            {
                picturePrecioC.Image = System.Drawing.Image.FromFile("D:\\ingenieria en sistemas\\Fernando sexto semestre\\Programacion 5\\Programas n c# 6to semestre\\ProyectoProgV\\ProyectoProgV\\Resources\\error.png");
            }
            else
            {
                banderaPrecioC = true;
                picturePrecioC.Image = System.Drawing.Image.FromFile("D:\\ingenieria en sistemas\\Fernando sexto semestre\\Programacion 5\\Programas n c# 6to semestre\\ProyectoProgV\\ProyectoProgV\\Resources\\aprovado.png");
            }

            if (precioV2.Equals(""))
            {
                picturePrecioV.Image = System.Drawing.Image.FromFile("D:\\ingenieria en sistemas\\Fernando sexto semestre\\Programacion 5\\Programas n c# 6to semestre\\ProyectoProgV\\ProyectoProgV\\Resources\\error.png");
            }
            else
            {
                banderaPrecioV = true;
                picturePrecioV.Image = System.Drawing.Image.FromFile("D:\\ingenieria en sistemas\\Fernando sexto semestre\\Programacion 5\\Programas n c# 6to semestre\\ProyectoProgV\\ProyectoProgV\\Resources\\aprovado.png");
            }

            if (banderaProducto && banderaStock && banderaPrecioC && banderaPrecioV)
            {

                if (banderaModificar == false)
                {
                    Console.WriteLine("Categoria " + categoria);
                    Producto product = new Producto(codigo, categoria, proveedor, producto, fechita, stock, precioC, precioV, estado);
                    int resultado = MetodosBD.InsertarProducto(product);
                    if (resultado > 0)
                    {
                        MessageBox.Show("Datos guardados correctamente", "Mensaje de confirmación");
                        deshabilitar();
                        chEstado.Enabled = false;
                        txtCodigo.Text = "";
                        txtProducto.Text = "";
                        txtStock.Text = "";
                        txtPrecioC.Text = "";
                        txtPrecioV.Text = "";
                        
                        pictureCodigo.Image = null;

                        pictureCategoria.Image = null;
                        pictureProducto.Image = null;
                        pictureProveedor.Image = null;


                        pictureEstado.Image = null;

                        pictureStock.Image = null;

                        pictureFecha.Image = null;



                        picturePrecioC.Image = null;


                        picturePrecioV.Image = null;
                        contador = 0;


                    }


                    dataGridView.DataSource = MetodosBD.cargarProductos();
                }
                else
                {
                    bool estado2 = false;
                    if (contador == 0)
                    {
                        estado2 = MetodosBD.buscarEstadoProducto(txtCodigo.Text);

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
                    Console.WriteLine("Categoria " + categoria);
                    int resultado = MetodosBD.ActualizarProducto(codigo, categoria, proveedor, producto, fechita, stock, precioC, precioV, estado2);
                    if (resultado > 0)
                    {
                        txtCodigo.Text = "";
                        txtProducto.Text = "";
                        txtStock.Text = "";
                        txtPrecioC.Text = "";
                        txtPrecioV.Text = "";
                        deshabilitar();
                        chEstado.Enabled = false;


                        pictureCodigo.Image = null;

                        pictureCategoria.Image = null;
                        pictureProducto.Image = null;
                        pictureProveedor.Image = null;


                        pictureEstado.Image = null;

                        pictureStock.Image = null;

                        pictureFecha.Image = null;



                        picturePrecioC.Image = null;


                        picturePrecioV.Image = null;


                        MessageBox.Show("Dato Actualizado Correctamente", "Mensaje de Confirmación");
                        dataGridView.DataSource = MetodosBD.cargarProductos();
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
            string codigo = (string)dataGridView.CurrentRow.Cells["cod_producto"].Value;
            btnModificar.Enabled = true;
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnEliminar.Enabled = true;


            txtProducto.Enabled = false;
            cbCategoria.Enabled = false;
            cbProveedor.Enabled = false;
            dateFecha.Enabled = false;
            txtStock.Enabled = false;

            txtPrecioC.Enabled = false;

            txtPrecioV.Enabled = false;

            pictureCodigo.Image = null;

            pictureCategoria.Image = null;
            pictureProducto.Image = null;
            pictureProveedor.Image = null;


            pictureEstado.Image = null;

            pictureStock.Image = null;

            pictureFecha.Image = null;



            picturePrecioC.Image = null;


            picturePrecioV.Image = null;
            chEstado.Enabled = false;

            using (SqlConnection conexion = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Select * from producto where cod_producto like '%{0}'", codigo), conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    txtCodigo.Text = reader.GetString(0);
                    
                    string c = MetodosBD.buscarCategoria(reader.GetString(1));
                    cbCategoria.SelectedIndex = cbCategoria.FindString(c);
                    string p = MetodosBD.buscarProveedor(reader.GetString(2));
                    cbProveedor.SelectedIndex = cbProveedor.FindString(p);
                   
                    txtProducto.Text = reader.GetString(3);
                    dateFecha.Value = Convert.ToDateTime(reader.GetString(4));
                    txtStock.Text = Convert.ToString(reader.GetInt32(5));

                    txtPrecioC.Text = Convert.ToString(reader.GetDecimal(6));
                    txtPrecioV.Text = Convert.ToString(reader.GetDecimal(7));

                   
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

                DataTable dt = MetodosBD.cargarProductos();
                string fieldName = string.Concat("[", dt.Columns[0].ColumnName, "]");
                dt.DefaultView.Sort = fieldName;
                DataView view = dt.DefaultView;
                view.RowFilter = string.Empty;
                if (txtBusqueda.Text != string.Empty)
                    view.RowFilter = fieldName + " LIKE '%" + txtBusqueda.Text + "%'";
                dataGridView.DataSource = view;
            }


            if (rbProducto.Checked)
            {

                DataTable dt = MetodosBD.cargarProductos();
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

        private void rbProducto_CheckedChanged(object sender, EventArgs e)
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
            txtProducto.Enabled = true;
            cbCategoria.Enabled = true;
            cbProveedor.Enabled = true;
            dateFecha.Enabled = true;
            chEstado.Enabled = true;
            txtStock.Enabled = true;

            txtPrecioC.Enabled = true;

            txtPrecioV.Enabled = true;
        }

        private void dataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int count = 0; count < dataGridView.Rows.Count; count++)
            {
                string codigo = (string)dataGridView.Rows[count].Cells["cod_producto"].Value;
                bool estado = MetodosBD.buscarEstadoProducto(codigo);
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
                string codigo = (string)dataGridView.CurrentRow.Cells["cod_producto"].Value;
                int resultado2 = MetodosBD.ActualizarEstadoProducto(codigo, false);
                if (resultado2 > 0)
                {

                    MessageBox.Show("Registro dado de baja exitosamente¡¡", "Mensaje de Confirmación");
                    chEstado.Text = "Inactivo";
                    chEstado.ForeColor = Color.Red;
                    btnEliminar.Enabled = false;
                    dataGridView.DataSource = MetodosBD.cargarProductos();
                }
            }
            else
            {

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            VentanaPrincipalNuevo ventana = new VentanaPrincipalNuevo();
            ventana.Show();
        }

        private void txtPrecioV_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtPrecioC_KeyPress(object sender, KeyPressEventArgs e)
        {
            
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
