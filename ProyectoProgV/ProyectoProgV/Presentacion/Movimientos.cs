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
    public partial class EntradaProductos : MetroFramework.Forms.MetroForm
    {
        string codigoProducto = "";
        Validaciones validacion = new Validaciones();
        String codigo = "";
        DataTable dt = new DataTable();
        int fila = 0;
        public EntradaProductos()
        {
            InitializeComponent();
        }

        private void EntradaProductos_Load(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
            dataGridView.DataSource = MetodosBD.cargarProductos3();



            dataGridView.ClearSelection();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            codigoProducto = (string)dataGridView.CurrentRow.Cells["cod_producto"].Value;

            using (SqlConnection conexion = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Select cod_producto,producto, fecha_vencimiento, precio_compra, precio_venta from producto where cod_producto like '%{0}'", codigoProducto), conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {

                   
                    


                   
                        txtCodigo.Text = reader.GetString(0);



                        txtProducto.Text = reader.GetString(1);
                        date.Value = Convert.ToDateTime(reader.GetString(2));

                        txtPrecioC.Text = Convert.ToString(reader.GetDecimal(3));
                        txtPrecioV.Text = Convert.ToString(reader.GetDecimal(4));
                        txtBusqueda.Text = "";
                   



                }
                conexion.Close();


            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            VentanaPrincipalNuevo ventana = new VentanaPrincipalNuevo();
            ventana.Show();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = MetodosBD.cargarProductos3();
            string fieldName = string.Concat("[", dt.Columns[1].ColumnName, "]");
            dt.DefaultView.Sort = fieldName;
            DataView view = dt.DefaultView;
            view.RowFilter = string.Empty;
            if (txtBusqueda.Text != string.Empty)
                view.RowFilter = fieldName + " LIKE '%" + txtBusqueda.Text + "%'";
            dataGridView.DataSource = view;
        }

        private void rbEntrada_CheckedChanged(object sender, EventArgs e)
        {
            btnAceptar.Enabled = true;
            txtRecibirRetirar.Enabled = true;
        }

        private void rbSalida_CheckedChanged(object sender, EventArgs e)
        {
            txtRecibirRetirar.Enabled = true;
            btnAceptar.Enabled = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string retirar = txtRecibirRetirar.Text;
            string precioC= txtPrecioC.Text;
            string precioV= txtPrecioV.Text;
            Movimiento movimiento;

            
            int nuevoStock = 0;
            if (codigoProducto.Equals(""))
            {
                MessageBox.Show("Debe Seleccionar un producto");
            }
            else
            {
                if (retirar.Equals(""))
                {
                    MessageBox.Show("Debe ingresar un valor de Entrada o Salida");
                }
                else
                {
                    codigo = validacion.generarCodigo();
                    DateTime fecha = date.Value;
                    string fechita = fecha.ToString("d");
                    int cantidad = Convert.ToInt32(retirar);
                    decimal precioCom = Convert.ToDecimal(precioC);
                    decimal precioVen = Convert.ToDecimal(precioV);
                    movimiento = new Movimiento(codigo, codigoProducto, cantidad, fechita, precioCom, precioVen);
                    int stockAntiguo = MetodosBD.buscarStock(codigoProducto);
                    if (rbEntrada.Checked)
                    {
                        nuevoStock = cantidad + stockAntiguo;
                        int r = MetodosBD.InsertarEntradaProducto(movimiento);
                        int resultado = MetodosBD.ActualizarStock3(codigoProducto, nuevoStock, fechita);
                        if (resultado > 0)
                        {
                            MessageBox.Show("Datos guardados correctamente");
                            txtCodigo.Text = "";
                            txtRecibirRetirar.Text = "";
                            txtPrecioC.Text = "";
                            txtPrecioV.Text = "";
                            txtProducto.Text = "";
                            codigoProducto = "";
                            dataGridView.ClearSelection();
                        }
                    }

                    if (rbSalida.Checked)
                    {
                        if (cantidad > stockAntiguo)
                        {
                            MessageBox.Show("La cantidad Ingresada es mayor al stock actual");
                            txtRecibirRetirar.Text = "";
                            txtRecibirRetirar.Focus();
                        }
                        else
                        {
                            nuevoStock = stockAntiguo - cantidad;
                            int re = MetodosBD.InsertarSalidaProducto(movimiento);
                            int resultado = MetodosBD.ActualizarStock3(codigoProducto, nuevoStock, fechita);
                            if (resultado > 0)
                            {
                                MessageBox.Show("Datos guardados correctamente");
                                txtCodigo.Text = "";
                                txtRecibirRetirar.Text = "";
                                txtPrecioC.Text = "";
                                txtPrecioV.Text = "";
                                txtProducto.Text = "";
                                codigoProducto = "";
                                dataGridView.ClearSelection();
                            }
                        }

                    }

                }

            }
            
        }

        private void txtRecibirRetirar_KeyPress(object sender, KeyPressEventArgs e)
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


        private void mostrarDatos(int f)
        {
           // int uf = dataGridView.Rows.Count - 1;
            int uf = dt.Rows.Count - 1;
            if (f < 0 || uf < 0) return;
            //
            //DataRow dr = MetodosBD.cargarProductos3().Rows[f];
            DataRow dr = dt.Rows[f];
            txtCodigo.Text = dr["cod_producto"].ToString();
            txtProducto.Text = dr["producto"].ToString();
            txtPrecioV.Text = dr["precio_venta"].ToString();
            txtPrecioC.Text = dr["precio_compra"].ToString();
            date.Value = Convert.ToDateTime(dr["fecha_vencimiento"].ToString());
         

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
           

            using (SqlConnection conexion = Conexion.obtenerConexion())
            {
                SqlCommand cmd1 = new SqlCommand("select * from producto", conexion);
                SqlDataAdapter da = new SqlDataAdapter(cmd1);
                da.Fill(dt);
                fila = fila - 1;
                if (fila < 0) fila = 0;
                mostrarDatos(fila);
                conexion.Close();    
            }
  
           
        }

        private void btnAvanzar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conexion = Conexion.obtenerConexion())
            {
                SqlCommand cmd1 = new SqlCommand("select * from producto", conexion);
                SqlDataAdapter da = new SqlDataAdapter(cmd1);
                da.Fill(dt);
                int uf = dt.Rows.Count - 1; 
                fila = fila + 1; 
                if (fila > uf) fila = uf; 
                mostrarDatos(fila);
                conexion.Close();
            }
        }
    }
}
