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
    public partial class RegistrarCategoria : MetroFramework.Forms.MetroForm
    {

        Validaciones validacion = new Validaciones();
        String codigo = "";
        bool banderaModificar = false;
        int contador = 0;
        bool estado = true;
        DialogResult resultado;


        public RegistrarCategoria()
        {
            InitializeComponent();
        }

        private void RegistrarCategoria_Load(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();


            dataGridView.DataSource = MetodosBD.cargarCategoria();

            dataGridView.ClearSelection();
            deshabilitar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            VentanaPrincipalNuevo ventana = new VentanaPrincipalNuevo();
            ventana.Show();
        }

        public void habilitar()
        {
            txtCategoria.Enabled = true;

            

            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;

        }


        public void deshabilitar()
        {
            txtCategoria.Enabled = false;

           
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;


        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            codigo = validacion.generarCodigo();
            txtCodigo.Text = codigo;
            txtCategoria.Focus();
            pictureCodigo.Image = System.Drawing.Image.FromFile("D:\\ingenieria en sistemas\\Fernando sexto semestre\\Programacion 5\\Programas n c# 6to semestre\\ProyectoProgV\\ProyectoProgV\\Resources\\aprovado.png");
            habilitar();
            pictureEstado.Image = System.Drawing.Image.FromFile("D:\\ingenieria en sistemas\\Fernando sexto semestre\\Programacion 5\\Programas n c# 6to semestre\\ProyectoProgV\\ProyectoProgV\\Resources\\aprovado.png");
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            banderaModificar = false;
            txtCategoria.Text = "";

           
            chEstado.Text = "Activo";
            chEstado.Checked = false;
            chEstado.Enabled = true;
            chEstado.ForeColor = Color.Green;
            contador = 0;
            estado = true;

          




            pictureCategoria.Image = null;

      
            

            dataGridView.ClearSelection();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;
            string cat = txtCategoria.Text;

           

            bool banderaCategoria = false;



            if (cat.Equals(""))
            {
                pictureCategoria.Image = System.Drawing.Image.FromFile("D:\\ingenieria en sistemas\\Fernando sexto semestre\\Programacion 5\\Programas n c# 6to semestre\\ProyectoProgV\\ProyectoProgV\\Resources\\error.png");
            }
            else
            {
                banderaCategoria = true;
                pictureCategoria.Image = System.Drawing.Image.FromFile("D:\\ingenieria en sistemas\\Fernando sexto semestre\\Programacion 5\\Programas n c# 6to semestre\\ProyectoProgV\\ProyectoProgV\\Resources\\aprovado.png");
            }






            if (banderaCategoria)
            {

                if (banderaModificar == false)
                {
                    Categoria categoria = new Categoria(codigo, cat, estado);
                    int resultado = MetodosBD.InsertarCategoria(categoria);
                    if (resultado > 0)
                    {
                        MessageBox.Show("Datos guardados correctamente", "Mensaje de confirmación");
                        deshabilitar();
                        chEstado.Enabled = false;
                        txtCodigo.Text = "";
                        txtCategoria.Text = "";

                        

                        pictureCategoria.Image = null;


                        pictureEstado.Image = null;
                        pictureCodigo.Image = null;


                       



                    }


                    dataGridView.DataSource = MetodosBD.cargarCategoria();
                }
                else
                {
                    banderaModificar = false;
                    int resultado = MetodosBD.ActualizarCategoria(codigo, cat ,estado);
                    if (resultado > 0)
                    {
                        txtCodigo.Text = "";
                        txtCategoria.Text = "";

                       
                        deshabilitar();
                        chEstado.Enabled = false;


                        pictureCategoria.Image = null;


                        pictureEstado.Image = null;
                        pictureCodigo.Image = null;


                        

                        MessageBox.Show("Dato Actualizado Correctamente", "Mensaje de Confirmación");
                        dataGridView.DataSource = MetodosBD.cargarCategoria();
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
            string codigo = (string)dataGridView.CurrentRow.Cells["cod_categoria"].Value;
            btnModificar.Enabled = true;
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnEliminar.Enabled = true;


            txtCategoria.Enabled = false;

            

            pictureCodigo.Image = null;
            pictureEstado.Image = null;

            pictureCategoria.Image = null;






          
            chEstado.Enabled = false;

            using (SqlConnection conexion = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Select * from categoria where cod_categoria like '%{0}'", codigo), conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    txtCodigo.Text = reader.GetString(0);

                    txtCategoria.Text = reader.GetString(1);
                   
                    bool estado2 = reader.GetBoolean(2);
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

                DataTable dt = MetodosBD.cargarCategoria();
                string fieldName = string.Concat("[", dt.Columns[0].ColumnName, "]");
                dt.DefaultView.Sort = fieldName;
                DataView view = dt.DefaultView;
                view.RowFilter = string.Empty;
                if (txtBusqueda.Text != string.Empty)
                    view.RowFilter = fieldName + " LIKE '%" + txtBusqueda.Text + "%'";
                dataGridView.DataSource = view;
            }


            if (rbCategoria.Checked)
            {

                DataTable dt = MetodosBD.cargarCategoria();
                string fieldName = string.Concat("[", dt.Columns[1].ColumnName, "]");
                dt.DefaultView.Sort = fieldName;
                DataView view = dt.DefaultView;
                view.RowFilter = string.Empty;
                if (txtBusqueda.Text != string.Empty)
                    view.RowFilter = fieldName + " LIKE '%" + txtBusqueda.Text + "%'";
                dataGridView.DataSource = view;
            }


           
        }

        private void rbCategoria_CheckedChanged(object sender, EventArgs e)
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
            txtCategoria.Enabled = true;

           
            chEstado.Enabled = true;
           
        }

        private void dataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int count = 0; count < dataGridView.Rows.Count; count++)
            {
                string codigo = (string)dataGridView.Rows[count].Cells["cod_categoria"].Value;
                bool estado = MetodosBD.buscarEstadoCategoria(codigo);
                if (estado == false)
                {
                    dataGridView.Rows[count].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        private void chEstado_Click(object sender, EventArgs e)
        {
            if (contador == 0)
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
            resultado = MessageBox.Show("¿Desea dar de baja a este registro?", "Mensaje de confimación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado.Equals(DialogResult.Yes))
            {
                string codigo = (string)dataGridView.CurrentRow.Cells["cod_categoria"].Value;
                Console.Write("el codigo es " + codigo);
                int resultado2 = MetodosBD.ActualizarEstadoCategoria(codigo, false);
                if (resultado2 > 0)
                {

                    MessageBox.Show("Registro dado de baja exitosamente¡¡", "Mensaje de Confirmación");
                    chEstado.Text = "Inactivo";
                    chEstado.ForeColor = Color.Red;
                    btnEliminar.Enabled = false;
                    dataGridView.DataSource = MetodosBD.cargarCategoria();
                }
            }
            else
            {

            }
        }
    }
}
