using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoProgV
{
    public partial class FacturaCliente : MetroFramework.Forms.MetroForm
    {
        DateTime thisDay;
       // DateTime fechita;
        string fechaActual;
        string codigoProducto = "";
        int stock = 0;
        int nuevoStock = 0;
        int cantidad2 = 0;
        double totalFinal=0;
        double iva = 0;
        double subTotal = 0;
        DialogResult result;
        bool consumidorF = false;
     
        string ced = "";
        string numFactura = "";
        string cedEmpleado="";
        int contador = 0;
        double subT = 0;
        double I = 0;
        double T = 0;
        string num = "";
        public static bool  rbConsu = false;
        public static  bool rbFact = false;
        
        public static  bool rbCod = false;
        public static  bool rbProdu = false;
        public static bool txtBusq = false;
        public static bool dataGridPro = false;
        public static bool dataGridFact = false;
        public static  bool txtCant = false;
        public static bool btnA = false;
        public static bool guardar = false;
        bool banderaTabla = true;

        string p = "";
        List<FacturaC> f;
        public FacturaCliente()
        {
            InitializeComponent();
        }

        private void FacturaCliente_Load(object sender, EventArgs e)
        {
            columnProducto.Width = 200; 
            thisDay = DateTime.Today;
            dateTime.Value = thisDay;
           


                    btnGuardar.Enabled = guardar;
                    rbConsumidorFinal.Enabled=  rbConsu;
                    rbFactura.Enabled=rbFact;
                    
        rbCodigo.Enabled= rbCod;
        rbProducto.Enabled= rbProdu ;
        txtBusqueda.Enabled = txtBusq;
        dataGridViewProducto.Enabled = dataGridPro;
        
        txtCantidad.Enabled = txtCant;
        btnAgregarProducto.Enabled = btnA;

           
            txtEmpleado.Text = Login.ROL;
             fechaActual = thisDay.ToString("d");

             Console.WriteLine("fecha 3 " + dateTime);
             dataGridViewProducto.Rows.Clear();
             dataGridViewProducto.DataSource = MetodosBD.cargarProductos2();
             dataGridViewProducto.ClearSelection();

             int numFact = MetodosBD.numeroFactura() + 1;
             if (numFact < 10)
             {
                 lblNumFact.Text = "00" + Convert.ToString(numFact);
                 num = "00" + Convert.ToString(numFact);
             }
             else
             {
                 if (numFact >= 10 && numFact < 100)
                 {
                     lblNumFact.Text = "0" + Convert.ToString(numFact);
                     num = "0" + Convert.ToString(numFact);
                 }
                 else
                 {
                     if (numFact >= 100)
                     {
                         lblNumFact.Text = "" + Convert.ToString(numFact);
                         num = "" + Convert.ToString(numFact);
                     }

                 }
             }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            this.Close();
            BuscarCliente bCliente = new BuscarCliente();
            bCliente.Show();
        }

        private void rbConsumidorFinal_CheckedChanged(object sender, EventArgs e)
        {
            txtCliente.Text = "CONSUMIDOR FINAL";
            txtDireccion.Text = "---------------------";
            txtRUC.Text = "---------------------";
            txtTelefono.Text = "---------------------";
            btnBuscarCliente.Enabled = false;
            consumidorF = true;
            
        }

        private void rbFactura_CheckedChanged(object sender, EventArgs e)
        {
            txtCliente.Text = "";
            txtDireccion.Text = "";
            txtRUC.Text = "";
            txtTelefono.Text = "";
            btnBuscarCliente.Enabled = true;
            consumidorF = false;
           
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            rbFactura.Enabled = true;
            lblAnulada.Text = "";
            rbConsumidorFinal.Enabled = true;
            rbCodigo.Enabled = true;
            rbProducto.Enabled = true;
            txtBusqueda.Enabled = true;
            dataGridViewProducto.Enabled = true;
            btnGuardar.Enabled = true;
            btnAgregarProducto.Enabled = true;
            txtCantidad.Enabled = true;
            dateTime.Value = thisDay;
           
            guardar = true;
            txtCliente.Text = "";
            txtRUC.Text = "";
            txtDireccion.Text = "";
            txtEmpleado.Text = Login.ROL;
            txtTelefono.Text = "";
            dataGridViewProducto.ClearSelection();
            dataGridViewFactura.Rows.Clear();
            txtSubTotal.Text = "";
            txtIva.Text = "";
            txtTotal.Text = "";

            int numFact = MetodosBD.numeroFactura() + 1;
            if (numFact < 10)
            {
                lblNumFact.Text = "00" + Convert.ToString(numFact);
                num = "00" + Convert.ToString(numFact);
            }
            else
            {
                if (numFact >= 10 && numFact < 100)
                {
                    lblNumFact.Text = "0" + Convert.ToString(numFact);
                    num = "0" + Convert.ToString(numFact);
                }
                else
                {
                    if (numFact >= 100)
                    {
                        lblNumFact.Text = "" + Convert.ToString(numFact);
                        num = "" + Convert.ToString(numFact);
                    }

                }
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

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (rbCodigo.Checked)
            {

                DataTable dt = MetodosBD.cargarProductos2();
                string fieldName = string.Concat("[", dt.Columns[0].ColumnName, "]");
                dt.DefaultView.Sort = fieldName;
                DataView view = dt.DefaultView;
                view.RowFilter = string.Empty;
                if (txtBusqueda.Text != string.Empty)
                    view.RowFilter = fieldName + " LIKE '%" + txtBusqueda.Text + "%'";
                dataGridViewProducto.DataSource = view;
            }


            if (rbProducto.Checked)
            {

                DataTable dt = MetodosBD.cargarProductos2();
                string fieldName = string.Concat("[", dt.Columns[1].ColumnName, "]");
                dt.DefaultView.Sort = fieldName;
                DataView view = dt.DefaultView;
                view.RowFilter = string.Empty;
                if (txtBusqueda.Text != string.Empty)
                    view.RowFilter = fieldName + " LIKE '%" + txtBusqueda.Text + "%'";
                dataGridViewProducto.DataSource = view;
            }
        }

        private void dataGridViewProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             codigoProducto = (string)dataGridViewProducto.CurrentRow.Cells["cod_producto"].Value;
              stock = MetodosBD.buscarStock(codigoProducto);
              p = (string)dataGridViewProducto.CurrentRow.Cells["producto"].Value;
             
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            string cantidad = txtCantidad.Text;
            contador = 0;
            subTotal = 0;
           
            bool bandera1 = false;
            bool bandera2 = false;
            double total = 0;
            string producto="";
            double precio = 0;
            if(codigoProducto.Equals(""))
            {
                MessageBox.Show("Debe elegir un producto", "Mensaje de advertencia");
            }
            else
            {
                bandera1 = true;
               
                if(cantidad=="")
                {
                    MessageBox.Show("No puede dejar en blanco la cantidad", "Mensaje de advertencia");
                }
                else
                {
                     cantidad2 = Convert.ToInt32(txtCantidad.Text);
                    
                   
                    if(cantidad2 <= stock)
                    {
                        
                        bandera2 = true;
                    }
                    else
                    {
                        MessageBox.Show("Stock Insuficiente", "Mensaje de advertencia");
                        txtCantidad.Text = "";
                        txtCantidad.Focus();
                    }
                    
                }
            }

            if(bandera2&&bandera1)
            {
                string product = "";
                int cant = 0;
                int cant2=0;
                Console.Write(" SubTotal antes del for " + subTotal);
                for (int count = 0; count < dataGridViewFactura.Rows.Count; count++)
                {
                    product = (string)dataGridViewFactura.Rows[count].Cells["columnProducto"].Value;

                    Console.Write("entro 0");
                    if (p.Equals(product))
                    {
                        Console.Write("entro 1");
                        banderaTabla = false;
                        cant = (int)dataGridViewFactura.Rows[count].Cells["columnCantidad"].Value;
                        total = (double)dataGridViewFactura.Rows[count].Cells["columnTotal"].Value;
                      

                        
                        precio = MetodosBD.buscarPrecio(codigoProducto);

                        Console.Write("stock " + stock);
                        Console.Write("cantidad " + cantidad2);
                        nuevoStock = stock - cantidad2;
                      
                        
                        cant2 = cant + cantidad2;
                        dataGridViewFactura.Rows[count].Cells["columnCantidad"].Value = cant2;
                        total = precio * cant2;
                        dataGridViewFactura.Rows[count].Cells["columnTotal"].Value = total;
                       // subTotal = subTotal + total;
                        


                        MetodosBD.ActualizarStock(codigoProducto, nuevoStock);

                        dataGridViewProducto.DataSource = MetodosBD.cargarProductos2();
                        dataGridViewProducto.ClearSelection();

                        
                    
                    }
                    subTotal = subTotal + (double)dataGridViewFactura.Rows[count].Cells["columnTotal"].Value;
                    Console.Write(" SubTotal despues  del for " + subTotal);
                    iva = subTotal * 0.12;
                    totalFinal = iva + subTotal;
                    txtSubTotal.Text = Convert.ToString(subTotal);
                    txtIva.Text = Convert.ToString(iva);
                    txtTotal.Text = Convert.ToString(totalFinal);
                   
                       

                    
                   

                }
                if(banderaTabla)
                {
                    Console.Write("entro 2");
                    producto = MetodosBD.buscarProducto(codigoProducto);
                    precio = MetodosBD.buscarPrecio(codigoProducto);
                    total = precio * cantidad2;

                    
                    dataGridViewFactura.Rows.Add(cantidad2, producto, precio, total);
                    Console.Write("stock " + stock);
                    Console.Write("cantidad " + cantidad2);

                    nuevoStock = stock - cantidad2;
                    MetodosBD.ActualizarStock(codigoProducto, nuevoStock);
                    dataGridViewProducto.DataSource = MetodosBD.cargarProductos2();
                    dataGridViewProducto.ClearSelection();
                    Console.Write(" SubTotal antes del for " +subTotal);
                    //for (int count = 0; count < dataGridViewFactura.Rows.Count; count++)
                    //{
                        subTotal = subTotal + total;
                    //}

                    Console.Write(" SubTotal despues  del for " + subTotal);
                   
                    
                   // subTotal = subTotal + total;
                    iva = subTotal * 0.12;
                    totalFinal = iva + subTotal;
                    txtSubTotal.Text = Convert.ToString(subTotal);
                    txtIva.Text = Convert.ToString(iva);
                    txtTotal.Text = Convert.ToString(totalFinal);
                   

                    
                    banderaTabla = true;
                }

                

                
                txtCantidad.Text = "";
                txtCantidad.Focus();
                bandera1 = false;
                bandera2 = false;
                codigoProducto = "";

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            VentanaPrincipalNuevo ventana = new VentanaPrincipalNuevo();
            ventana.Show();
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

        private void dataGridViewFactura_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
             result = MessageBox.Show("¿Desea eliminar este producto de la Factura?", "Mensaje de confimación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
             if (result.Equals(DialogResult.Yes))
             {
                 string producto = (string)dataGridViewFactura.CurrentRow.Cells["columnProducto"].Value;
                 
                 int cantidad = (int)dataGridViewFactura.CurrentRow.Cells["columnCantidad"].Value;
                 double total3 = (double)dataGridViewFactura.CurrentRow.Cells["columnTotal"].Value;
                 Console.Write("total columna " + total3);
                 Console.Write("subtotal antigua " + subTotal);
                 double sub = Convert.ToDouble(txtSubTotal.Text);
              
                 subTotal = sub - total3;
                
                
                 iva = subTotal * 0.12;
                 totalFinal = iva + subTotal;
                 txtSubTotal.Text = Convert.ToString(subTotal);
                 txtIva.Text = Convert.ToString(iva);
                 txtTotal.Text = Convert.ToString(totalFinal);
                 int stockViejo = MetodosBD.buscarStock2(producto);
                 int newStock = stockViejo + cantidad;

                 MetodosBD.ActualizarStock2(producto, newStock);

                
                 dataGridViewProducto.DataSource = MetodosBD.cargarProductos2();
                 dataGridViewFactura.Rows.Remove(dataGridViewFactura.CurrentRow);
                 dataGridViewProducto.ClearSelection();
                 //dataGridViewFactura.ClearSelection();


             }
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string cliente = txtCliente.Text;
           
            if(cliente.Equals(""))
            {
                MessageBox.Show("Falta datos del Cliente", "Mensaje de advertencia");
            }
            else
            {
                for (int count = 0; count < dataGridViewFactura.Rows.Count; count++)
                {
                    string codigo = (string)dataGridViewFactura.Rows[count].Cells["columnProducto"].Value;
                    contador = contador + 1;

                }
                if(contador >=1)
                {
                    Console.Write("contador es " + contador);
                    if (consumidorF == true)
                    {
                        txtCliente.Text = "";
                        txtRUC.Text = "";
                        txtDireccion.Text = "";
                        txtTelefono.Text = "";
                        dataGridViewProducto.ClearSelection();
                        dataGridViewFactura.Rows.Clear();
                        txtSubTotal.Text = "";
                        txtIva.Text = "";
                        txtTotal.Text = "";


                        rbFactura.Enabled = false;
                        rbConsumidorFinal.Enabled = false;
                        rbCodigo.Enabled = false;
                        rbProducto.Enabled = false;
                        txtBusqueda.Enabled = false;
                        dataGridViewProducto.Enabled = false;
                        btnGuardar.Enabled = false;
                        btnAgregarProducto.Enabled = false;
                        txtCantidad.Enabled = false;
                        txtEmpleado.Text = Login.ROL;
                        consumidorF = false;


                    }
                    else
                    {
                        contador = 0;
                        // es una factura
                        ced = txtRUC.Text;
                        numFactura = num;
                        Console.Write("num fact "+numFactura);
                        cedEmpleado = MetodosBD.retornaCedulaEmpleado(txtEmpleado.Text);
                        subT = Convert.ToDouble(txtSubTotal.Text);
                        I = Convert.ToDouble(txtIva.Text);
                        T = Convert.ToDouble(txtTotal.Text);
                         string cod="";
                        string prod="";
                        int cant =0;
                        double  precio=0;
                        double total=0;


                        MetodosBD.InsertarFacturaC(numFactura, ced, cedEmpleado, fechaActual, subT, I, T, false);
                        for (int count = 0; count < dataGridViewFactura.Rows.Count; count++)
                        {
                             cod = (string)dataGridViewFactura.Rows[count].Cells["columnProducto"].Value;
                            prod= MetodosBD.buscarCodigoProducto(cod);
                              cant = (int)dataGridViewFactura.Rows[count].Cells["columnCantidad"].Value;
                             precio = (double)dataGridViewFactura.Rows[count].Cells["columnPrecioUnit"].Value;
                            total = (double)dataGridViewFactura.Rows[count].Cells["columnTotal"].Value;


                            MetodosBD.InsertarDetalleFactura(numFactura, prod, cant, precio, total);
                            
                        }

                        txtCliente.Text = "";
                        txtRUC.Text = "";
                        txtDireccion.Text = "";
                        txtTelefono.Text = "";
                        dataGridViewProducto.ClearSelection();
                        dataGridViewFactura.Rows.Clear();
                        txtSubTotal.Text = "";
                        txtIva.Text = "";
                        txtTotal.Text = "";
                      

                        rbFactura.Enabled = false;
                        rbConsumidorFinal.Enabled = false;
                        rbCodigo.Enabled = false;
                        rbProducto.Enabled = false;
                        txtBusqueda.Enabled = false;
                        dataGridViewProducto.Enabled = false;
                        btnGuardar.Enabled = false;
                        btnAgregarProducto.Enabled = false;
                        txtCantidad.Enabled = false;
                        txtEmpleado.Text = Login.ROL;
                        consumidorF = false;
           

                    }
                }
                else
                {
                    MessageBox.Show("Falta datos de Productos", "Mensaje de advertencia");
                }
               
            }
        }

        private DateTime getFechaActual()
        {
            int anio, dia, mes;
            DateTime dtFecha;
            anio = DateTime.Today.Year;
            mes = DateTime.Today.Month;
            dia = DateTime.Today.Day;
            dtFecha = new DateTime(anio, mes, dia);
            return dtFecha;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           
            bool buscar = false;
            string cedula = "";
            string producto = "";
            string numFact = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el Número de Factura", "Mensaje de Busqueda");
             f = MetodosBD.cargarFacturaC(numFact);
            foreach (FacturaC x in f)
            {
                buscar = true;
                lblNumFact.Text = x.NumF;
                cedula = x.CedulaC;
        
                txtEmpleado.Text = x.CedulaE;
                dateTime.Value = Convert.ToDateTime(x.Fecha);
                txtSubTotal.Text = Convert.ToString(x.SubTotal);
                txtIva.Text = Convert.ToString(x.Iva);
                txtTotal.Text = Convert.ToString(x.Total);
                if(x.Anulado)
                {
                    // significa que esta anulada la factura
                    lblAnulada.Text = "Anulado";
                }
                else
                {
                    lblAnulada.Text = "";
                }


            }

            if(buscar)
            {
                dataGridViewFactura.Rows.Clear();
                List<Cliente> cliente = MetodosBD.cargarClienteF(cedula);
                foreach (Cliente cl in cliente)
                {
                    
                    txtCliente.Text = cl.Nombre + " " + cl.Apellido;
                    txtDireccion.Text = cl.Direccion;
                    txtRUC.Text = cl.Cedula;
                    txtTelefono.Text = cl.Telefono;

                }

                List<DetalleFactura> detalle = MetodosBD.cargarDetalleFactura(numFact);
                foreach (DetalleFactura d in detalle)
                {

                    producto = MetodosBD.buscarProducto(d.CodProducto);
                    

                    dataGridViewFactura.Rows.Add(d.Cantidad, producto, d.Precio, d.Total);

                }


                buscar = false;


            
            }
            
            
            Console.WriteLine(numFact);
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            string numFact = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el Número de Factura", "Mensaje de Busqueda");
             result = MessageBox.Show("¿Desea Anular esta Factura?", "Mensaje de confimación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
             if (result.Equals(DialogResult.Yes))
             {
                 bool anulado = MetodosBD.facturaAnulada(numFact);
                 if(anulado)
                 {
                     MessageBox.Show("Error la Factura esta anulada");
                 }
                 else
                 {
                     int resultado = MetodosBD.ActualizarAnulacionFactura(numFact, true);
                     if (resultado >= 1)
                     {
                         string producto;
                         List<DetalleFactura> detalle = MetodosBD.cargarDetalleFactura(numFact);
                         foreach (DetalleFactura d in detalle)
                         {

                             producto = MetodosBD.buscarProducto(d.CodProducto);
                                  int stockViejo = MetodosBD.buscarStock2(producto);
                             int newStock = stockViejo + d.Cantidad;

                          MetodosBD.ActualizarStock2(producto, newStock);


                            

                         }
                         MessageBox.Show("Factura anulada");
                     }
                     else
                     {
                         MessageBox.Show("Factura no encontrada");
                     }
                 }
                
                
             }

        }

      
    }
}
