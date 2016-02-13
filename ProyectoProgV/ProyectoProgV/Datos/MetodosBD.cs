using ProyectoProgV.Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgV
{
    class MetodosBD
    {
        public static string tipoUser;
        public static bool buscarUsuario(string user, string pass)
        {
           
            bool bandera = false;
            using (SqlConnection con = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM usuario WHERE user_empleado=@user AND contra_empleado=@pass", con);
                comando.Parameters.AddWithValue("@user", user);  // para evitar el sql injection
                comando.Parameters.AddWithValue("@pass", pass);  // para evitar el sql injection
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    tipoUser = reader.GetString(9);
                    bandera = true;
                                       
                }
                Console.Write("bandera es " + bandera);

               
               

                 
                con.Close();
                return bandera;
            }

           

         
        }

        public static bool buscarCedula(string cedula)
        {

            bool bandera = false;
            using (SqlConnection con = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Select * from usuario where ced_empleado like '%{0}'", cedula), con);
           //     comando.Parameters.AddWithValue("@cedula", cedula);  // para evitar el sql injection

                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    
                    bandera = true;

                }
              
                con.Close();
                return bandera;
            }
        }

        public static bool facturaAnulada(string numFact)
        {

            bool bandera = false;
            using (SqlConnection con = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Select anulado from facturaCliente where numFact_cliente like '%{0}'", numFact), con);
                //     comando.Parameters.AddWithValue("@cedula", cedula);  // para evitar el sql injection

                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {

                    bandera = reader.GetBoolean(0);

                }

                con.Close();
                return bandera;
            }
        }

        public static string retornaCedulaEmpleado(string user)
        {

            string cedula ="";
            using (SqlConnection con = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Select ced_empleado from usuario where user_empleado like '%{0}'", user), con);
                //     comando.Parameters.AddWithValue("@cedula", cedula);  // para evitar el sql injection

                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {

                    cedula = reader.GetString(0);

                }

                con.Close();
                return cedula;
            }
        }

        public static bool buscarRucProveedor(string cedula)
        {

            bool bandera = false;
            using (SqlConnection con = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Select * from proveedor where ruc like '%{0}'", cedula), con);
                //     comando.Parameters.AddWithValue("@cedula", cedula);  // para evitar el sql injection

                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {

                    bandera = true;

                }

                con.Close();
                return bandera;
            }
        }

        public static bool buscarCedulaCliente(string cedula)
        {

            bool bandera = false;
            using (SqlConnection con = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Select * from cliente where ced_cliente like '%{0}'", cedula), con);
                //     comando.Parameters.AddWithValue("@cedula", cedula);  // para evitar el sql injection

                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {

                    bandera = true;

                }

                con.Close();
                return bandera;
            }




        }

        public static string buscarCedula2(string numFact)
        {

            string bandera = "";
            using (SqlConnection con = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Select ced_cliente from facturaCliente where numFact_cliente like '%{0}'", numFact), con);
                //     comando.Parameters.AddWithValue("@cedula", cedula);  // para evitar el sql injection

                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {

                    bandera = reader.GetString(0);

                }

                con.Close();
                return bandera;
            }




        }


        

        public static bool buscarUser(string user)
        {

            bool bandera = false;
            using (SqlConnection con = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Select * from usuario where user_empleado like '%{0}'", user), con);
                //     comando.Parameters.AddWithValue("@cedula", cedula);  // para evitar el sql injection

                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {

                    bandera = true;

                }

                con.Close();
                return bandera;
            }




        }

        public static string buscarImagen(string user)
        {

            string bandera = "";
            using (SqlConnection con = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Select urlfoto_empleado from usuario where user_empleado like '%{0}'", user), con);
                //     comando.Parameters.AddWithValue("@cedula", cedula);  // para evitar el sql injection

                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {

                    bandera = reader.GetString(0) ;

                }

                con.Close();
                return bandera;
            }




        }

        public static string buscarContra(string codigo)
        {

            string contra ="";
            using (SqlConnection con = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Select contra_empleado from usuario where cod_empleado like '%{0}'", codigo), con);
                //     comando.Parameters.AddWithValue("@cedula", cedula);  // para evitar el sql injection

                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {

                    contra = reader.GetString(0);

                }

                con.Close();
                return contra;
            }




        }


       


        public static bool buscarEstado(string codigo)
        {

            bool bandera = false;
            using (SqlConnection con = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Select estado from usuario where cod_empleado like '%{0}'", codigo), con);
                //     comando.Parameters.AddWithValue("@cedula", cedula);  // para evitar el sql injection

                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {

                    bandera = reader.GetBoolean(0);

                }

                con.Close();
                return bandera;
            }




        }

        public static string buscarCategoria(string codigo)
        {

            string categoria = "";
            using (SqlConnection con = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Select categoria from categoria where cod_categoria like '%{0}'", codigo), con);
                //     comando.Parameters.AddWithValue("@cedula", cedula);  // para evitar el sql injection

                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {

                    categoria = reader.GetString(0);

                }

                con.Close();
                return categoria;
            }




        }


        public static bool buscarEstadoCliente(string codigo)
        {

            bool bandera = false;
            using (SqlConnection con = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Select estado_cliente from cliente where cod_cliente like '%{0}'", codigo), con);
                //     comando.Parameters.AddWithValue("@cedula", cedula);  // para evitar el sql injection

                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {

                    bandera = reader.GetBoolean(0);

                }

                con.Close();
                return bandera;
            }




        }


        public static string buscarEmailCliente(string cedula)
        {

            string bandera = "";
            using (SqlConnection con = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Select email_cliente from cliente where ced_cliente like '%{0}'", cedula), con);
                //     comando.Parameters.AddWithValue("@cedula", cedula);  // para evitar el sql injection

                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {

                    bandera = reader.GetString(0);

                }

                con.Close();
                return bandera;
            }




        }


        public static bool buscarEstadoProveedor(string codigo)
        {

            bool bandera = false;
            using (SqlConnection con = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Select estado_proveedor from proveedor where cod_proveedor like '%{0}'", codigo), con);
             

                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {

                    bandera = reader.GetBoolean(0);

                }

                con.Close();
                return bandera;
            }




        }


        public static string  buscarCodProveedor(string proveedor)
        {

            string bandera = "";
            using (SqlConnection con = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Select cod_proveedor from proveedor where razon_social like '%{0}'", proveedor), con);


                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {

                    bandera = reader.GetString(0);

                }

                con.Close();
                return bandera;
            }




        }

        public static bool buscarEstadoCategoria(string codigo)
        {

            bool bandera = false;
            using (SqlConnection con = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Select estado_categoria from categoria where cod_categoria like '%{0}'", codigo), con);


                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {

                    bandera = reader.GetBoolean(0);

                }

                con.Close();
                return bandera;
            }




        }
        public static bool buscarEstadoTrabajador(string user)
        {

            bool bandera = false;
            using (SqlConnection con = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Select estado from usuario where user_empleado like '%{0}'", user), con);
                //     comando.Parameters.AddWithValue("@cedula", cedula);  // para evitar el sql injection

                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {

                    bandera = reader.GetBoolean(0);

                }

                con.Close();
                return bandera;
            }


        }


        public static bool buscarEstadoProducto(string codigo)
        {

            bool bandera = false;
            using (SqlConnection con = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Select estado_producto from producto where cod_producto like '%{0}'", codigo), con);


                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {

                    bandera = reader.GetBoolean(0);

                }

                con.Close();
                return bandera;
            }




        }

        public static string buscarCodigoProducto(string producto)
        {

            string bandera = "";
            using (SqlConnection con = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Select cod_producto from producto where producto like '%{0}'", producto), con);


                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {

                    bandera = reader.GetString(0);

                }

                con.Close();
                return bandera;
            }




        }

        public static string buscarCodigoProducto5(string producto)
        {

            string bandera = "";
            using (SqlConnection con = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Select cod_producto from detalleFacturaCliente where numFact_cliente like '%{0}'", producto), con);


                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {

                    bandera = reader.GetString(0);

                }

                con.Close();
                return bandera;
            }




        }
        public static int buscarStock(string codigo)
        {

            int stock = 0;
            using (SqlConnection con = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Select stock from producto where cod_producto like '%{0}'", codigo), con);


                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {

                    stock = reader.GetInt32(0);

                }

                con.Close();
                return stock;
            }




        }

        public static int buscarStock2(string producto)
        {

            int stock = 0;
            using (SqlConnection con = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Select stock from producto where producto like '%{0}'", producto), con);


                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {

                    stock = reader.GetInt32(0);

                }

                con.Close();
                return stock;
            }




        }


        public static string buscarProducto(string codigo)
        {

            string producto = "";
            using (SqlConnection con = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Select producto from producto where cod_producto like '%{0}'", codigo), con);


                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {

                    producto = reader.GetString(0);

                }

                con.Close();
                return producto;
            }




        }


        public static string buscarCiudad(string codigo)
        {

            string ciudad = "";
            using (SqlConnection con = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Select ciud_ciudad from ciudad where cod_ciudad like '%{0}'", codigo), con);


                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {

                    ciudad = reader.GetString(0);

                }

                con.Close();
                return ciudad;
            }




        }

        public static string buscarProveedor(string codigo)
        {

            string proveedor = "";
            using (SqlConnection con = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Select razon_social from proveedor where cod_proveedor like '%{0}'", codigo), con);


                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {

                    proveedor = reader.GetString(0);

                }

                con.Close();
                return proveedor;
            }




        }

        public static string buscarNumFactP(string codigo)
        {

            string numF = "";
            using (SqlConnection con = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Select num_factp from controlPagos where num_factp like '%{0}'", codigo), con);


                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {

                    numF = reader.GetString(0);

                }

                con.Close();
                return numF;
            }

        }

        public static bool buscarNumFactCliente(string codigo)
        {

            bool numF = false;
            using (SqlConnection con = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Select numFact_cliente from facturaCliente where numFact_cliente like '%{0}'", codigo), con);


                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {

                    numF = reader.GetBoolean(0);

                }

                con.Close();
                return numF;
            }

        }

        public static double buscarPrecio(string codigo)
        {
            decimal precio;
            double precio2 = 0;
            using (SqlConnection con = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Select precio_venta from producto where cod_producto like '%{0}'", codigo), con);


                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {

                    precio = reader.GetDecimal(0);
                    precio2= Convert.ToDouble(precio);

                }

                con.Close();
                return precio2;
            }




        }

        public static int numeroFactura()
        {

            int numero = 5;
            using (SqlConnection con = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("select count(*) from facturaCliente"), con);
                //     comando.Parameters.AddWithValue("@cedula", cedula);  // para evitar el sql injection

                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {

                    numero = reader.GetInt32(0);

                }

                con.Close();
                return numero;
            }


        }
        
        public static List<Ciudad> cargarCiudad()
        {
            string cod;
            string ciudad;
            List<Ciudad> lista = new List<Ciudad>();
            using (SqlConnection conexion = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand("Select * from ciudad", conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    cod = reader.GetString(0);
                    
                    ciudad = reader.GetString(1);
                  

                    Ciudad ciud = new Ciudad(cod, ciudad);
                    lista.Add(ciud);
                }
                conexion.Close();
                return lista;

            }
        }


        public static List<Categoria> cargarCategoria2()
        {
            string cod;
            string cat;
            bool estado;
            List<Categoria> lista = new List<Categoria>();
            using (SqlConnection conexion = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand("Select * from categoria", conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    cod = reader.GetString(0);

                    cat = reader.GetString(1);
                    estado = reader.GetBoolean(2);
                    bool x = MetodosBD.buscarEstadoCategoria(cod);

                    if (x == true)
                    {
                        Categoria categoria = new Categoria(cod, cat, estado);
                        lista.Add(categoria);
                    }
                   
                }
                conexion.Close();
                return lista;

            }
        }

        public static List<Proveedor> cargarProveedor2()
        {
            string cod;
            string nombre;
            string ruc;
            string direccion;
            string telefono;
            string email;
            string ciudad;
            string fecha;

            bool estado;
            List<Proveedor> lista = new List<Proveedor>();
            using (SqlConnection conexion = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand("Select * from proveedor", conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    cod = reader.GetString(0);

                    nombre = reader.GetString(1);
                    ruc = reader.GetString(2);
                    direccion=  reader.GetString(3);
                    telefono  = reader.GetString(4);
                    email = reader.GetString(5);
                    ciudad  = reader.GetString(6);
                    estado = reader.GetBoolean(7);
                    fecha = reader.GetString(8);

                    bool x = buscarEstadoProveedor(cod);
                    if(x==true)
                    {
                        Proveedor pro = new Proveedor(cod, nombre, ruc, direccion, telefono, email, ciudad, estado, fecha);
                        lista.Add(pro);
                    }
                    
                }
                conexion.Close();
                return lista;

            }
        }



        public static List<Proveedor> cargarProveedorModificar()
        {
            string cod;
            string nombre;
            string ruc;
            string direccion;
            string telefono;
            string email;
            string ciudad;
            string fecha;

            bool estado;
            List<Proveedor> lista = new List<Proveedor>();
            using (SqlConnection conexion = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand("Select * from proveedor", conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    cod = reader.GetString(0);

                    nombre = reader.GetString(1);
                    ruc = reader.GetString(2);
                    direccion = reader.GetString(3);
                    telefono = reader.GetString(4);
                    email = reader.GetString(5);
                    ciudad = reader.GetString(6);
                    estado = reader.GetBoolean(7);
                    fecha = reader.GetString(8);

                   
                        Proveedor pro = new Proveedor(cod, nombre, ruc, direccion, telefono, email, ciudad, estado, fecha);
                        lista.Add(pro);
                    

                }
                conexion.Close();
                return lista;

            }
        }


        public static List<ControlPagos> cargarControlP()
        {
            string numFact;
            string codigoProve;
            string fecha;
            int cantidad;
            decimal total;
            string url;


          
            List<ControlPagos> lista = new List<ControlPagos>();
            using (SqlConnection conexion = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand("Select * from controlPagos", conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    numFact = reader.GetString(0);

                    codigoProve = reader.GetString(1);
                    fecha = reader.GetString(2);
                    cantidad = reader.GetInt32(3);
                    total = reader.GetDecimal(4);
                    url = reader.GetString(5);



                    ControlPagos pro = new ControlPagos(numFact, codigoProve, fecha, cantidad, total, url);
                        lista.Add(pro);
                    

                }
                conexion.Close();
                return lista;

            }
        }



        public static List<Usuarios> cargarPerfiles(string codigo)
        {
            string apellido;
            string nombre;
            string cedula;
            string direccion;
            string telefono;
            string email;
            string fecha;
           
            List<Usuarios> lista = new List<Usuarios>();
            using (SqlConnection conexion = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand("Select ced_empleado, nom_empleado, ape_empleado, dir_empleado, telf_empleado, email_empleado  from usuario where cod_empleado like = '" + codigo +"'", conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    cedula = reader.GetString(0);

                    nombre = reader.GetString(1);
                    apellido = reader.GetString(2);
                    direccion = reader.GetString(3);
                    telefono = reader.GetString(4);
                    email = reader.GetString(5);


                  

                    Usuarios pro = new Usuarios("",cedula, nombre, apellido, direccion, telefono, email, "", "", "", "", "", false, "");
                        lista.Add(pro);
                    

                }
                conexion.Close();
                return lista;

            }
        }


        public static List<FacturaC> cargarFacturaC(string numFact)
        {
             string numF;

       
        string cedulaC;

        
        string cedulaE;

      
        string fecha;

       
        decimal subTotal;

     
        decimal iva;

       
        decimal total;
        bool anulado;

       

          
            List<FacturaC> lista = new List<FacturaC>();
            using (SqlConnection conexion = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand("Select * from facturaCliente where numFact_cliente like '" + numFact+"'", conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    numF = reader.GetString(0);

                    cedulaC = reader.GetString(1);
                    cedulaE = reader.GetString(2);
                    fecha = reader.GetString(3);
                    subTotal = reader.GetDecimal(4);
                    iva = reader.GetDecimal(5);
                    total = reader.GetDecimal(6);
                    anulado = reader.GetBoolean(7);
                    

                  
                        FacturaC pro = new FacturaC(numF, cedulaC, cedulaE, fecha, subTotal, iva, total, anulado);
                        lista.Add(pro);
                    

                }
                conexion.Close();
                return lista;

            }
        }


        public static List<Cliente> cargarClienteF(string cedula)
        {
            string cod;


            string cedulaC;


            string nombre;


            string apellido;

            string dir;
            string telef;
            string email;
            string ciudad;
            bool estado;








            List<Cliente> lista = new List<Cliente>();
            using (SqlConnection conexion = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand("Select * from cliente where ced_cliente like '" + cedula + "'", conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    cod = reader.GetString(0);

                    cedulaC = reader.GetString(1);
                    nombre = reader.GetString(2);
                    apellido = reader.GetString(3);
                    dir = reader.GetString(4);
                    telef = reader.GetString(5);
                    email = reader.GetString(6);
                    ciudad = reader.GetString(7);
                    estado = reader.GetBoolean(8);
                    



                    Cliente pro = new Cliente(cod, cedulaC, nombre, apellido, dir, telef, email, ciudad, estado);
                    lista.Add(pro);


                }
                conexion.Close();
                return lista;

            }
        }


        public static List<DetalleFactura> cargarDetalleFactura(string numFact)
        {
            string codP;
            int cantidad;
            decimal precio;
            decimal total;

            List<DetalleFactura> lista = new List<DetalleFactura>();
            using (SqlConnection conexion = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand("Select cod_producto, cantidad, precio_unitario, total from detalleFacturaCliente where numFact_cliente like '" + numFact + "'", conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    codP = reader.GetString(0);

                    cantidad = reader.GetInt32(1);
                    precio = reader.GetDecimal(2);
                    total = reader.GetDecimal(3);
                  
                    DetalleFactura pro = new DetalleFactura(codP, cantidad, precio, total);
                    lista.Add(pro);


                }
                conexion.Close();
                return lista;
            }
        }


        public static DataTable cargarUsuarios2()
        {
            DataTable dt = new DataTable();
          
            using (SqlConnection conexion = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand("Select cod_empleado, nom_empleado, ape_empleado, ced_empleado from usuario", conexion);
                SqlDataAdapter da = new SqlDataAdapter(comando);
                da.Fill(dt);
                conexion.Close();       

            }
            
            return dt;
        }

        public static DataTable cargarClientes()
        {
            DataTable dt = new DataTable();

            using (SqlConnection conexion = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand("Select cod_cliente, ced_cliente, nom_cliente, ape_cliente,dir_cliente, telf_cliente, email_cliente, cod_ciudad from cliente", conexion);
                SqlDataAdapter da = new SqlDataAdapter(comando);
                da.Fill(dt);
                
                conexion.Close();

            }

            return dt;
        }


        public static DataTable cargarProveedores()
        {
            DataTable dt = new DataTable();

            using (SqlConnection conexion = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand("Select cod_proveedor, razon_social, ruc,dir_proveedor, telf_proveedor, email_proveedor from proveedor", conexion);
                SqlDataAdapter da = new SqlDataAdapter(comando);
                da.Fill(dt);
                conexion.Close();

            }

            return dt;
        }


        public static DataTable cargarCategoria()
        {
            DataTable dt = new DataTable();

            using (SqlConnection conexion = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand("Select cod_categoria, categoria from categoria", conexion);
                SqlDataAdapter da = new SqlDataAdapter(comando);
                da.Fill(dt);
                conexion.Close();

            }

            return dt;
        }

        public static DataTable cargarProductos()
        {
            DataTable dt = new DataTable();

            using (SqlConnection conexion = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand("Select cod_producto, cod_categoria, cod_proveedor, producto, fecha_vencimiento, stock, precio_compra, precio_venta from producto", conexion);
                SqlDataAdapter da = new SqlDataAdapter(comando);
                da.Fill(dt);
                conexion.Close();
            }

            return dt;
        }

        public static DataTable cargarControlPagos()
        {
            DataTable dt = new DataTable();

            using (SqlConnection conexion = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand("Select num_factp,cod_proveedor, fecha_entrega, cantidad, total from controlPagos", conexion);
                SqlDataAdapter da = new SqlDataAdapter(comando);
                da.Fill(dt);
                conexion.Close();
            }

            return dt;
        }

        public static DataTable cargarPagosFactura()
        {
            DataTable dt = new DataTable();

            using (SqlConnection conexion = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand("Select num_factp,fecha_pago, nro_cuenta_banco, monto_pagar, banco from pagoFacturasCompra", conexion);
                SqlDataAdapter da = new SqlDataAdapter(comando);
                da.Fill(dt);
                conexion.Close();
            }

            return dt;
        }

        public static DataTable cargarProductos3()
        {
            DataTable dt = new DataTable();

            using (SqlConnection conexion = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand("Select cod_producto, producto, fecha_vencimiento, precio_compra, precio_venta from producto where estado_producto = 'true'", conexion);
                SqlDataAdapter da = new SqlDataAdapter(comando);
                da.Fill(dt);
                conexion.Close();
            }

            return dt;
        }

        public static DataTable cargarProductos2()
        {
            DataTable dt = new DataTable();

            using (SqlConnection conexion = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand("Select cod_producto, producto, stock, precio_venta from producto where estado_producto != 0", conexion);
                SqlDataAdapter da = new SqlDataAdapter(comando);
                da.Fill(dt);
                conexion.Close();
            }

            return dt;
        }

        public static void InsertarFacturaC(string numFact, string cedula, string ced_user, string fecha, double subTotal, double iva, double total, bool estado)
        {
            int retorno = 0; // en el caso de que no se inserter el registro retornara cero
            using (SqlConnection con = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Insert into facturaCliente(numFact_cliente, ced_cliente, ced_empleado, fecha_facturaC, subTotal, iva, totalFact, anulado) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')", numFact, cedula, ced_user, fecha, subTotal, iva, total, estado), con);
                retorno = comando.ExecuteNonQuery();
                
                con.Close();
            }
          //  return retorno;
        }

        public static void InsertarDetalleFactura(string numFact, string cod_producto, int cantidad, double precio, double total)
        {
            int retorno = 0; // en el caso de que no se inserter el registro retornara cero
            using (SqlConnection con = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Insert into detalleFacturaCliente(numFact_cliente, cod_producto, cantidad,  precio_unitario,  total) values ('{0}', '{1}', '{2}', '{3}', '{4}')", numFact, cod_producto,cantidad, precio, total), con);
                retorno = comando.ExecuteNonQuery();

                con.Close();
            }
            //  return retorno;
        }

     
        public static int InsertarProducto(Producto producto)
        {
            int retorno = 0; // en el caso de que no se inserter el registro retornara cero
            using (SqlConnection con = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Insert into producto(cod_producto, cod_categoria, cod_proveedor, producto, fecha_vencimiento, stock, precio_compra, precio_venta, estado_producto) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')", producto.Codigo, producto.Categoria, producto.Proveedor, producto.Producto1, producto.FechaV, producto.Stock, producto.PrecioC, producto.PrecioV, producto.Estado), con);
                retorno = comando.ExecuteNonQuery();

                con.Close();
            }
            return retorno;
        }

        public static int InsertarEntradaProducto(Movimiento producto)
        {
            int retorno = 0; // en el caso de que no se inserter el registro retornara cero
            using (SqlConnection con = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Insert into entradaProductos(cod_entrada, cod_producto, recibir, fecha_vencimiento, precio_compra, precio_venta) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", producto.CodigoM, producto.CodigoP, producto.Cantidad,  producto.Fecha,  producto.PrecioC, producto.PrecioV ), con);
                retorno = comando.ExecuteNonQuery();

                con.Close();
            }
            return retorno;
        }

        public static int InsertarSalidaProducto(Movimiento producto)
        {
            int retorno = 0; // en el caso de que no se inserter el registro retornara cero
            using (SqlConnection con = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Insert into salidaProductos(cod_salida, cod_producto, retirar, fecha_vencimiento, precio_compra, precio_venta) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", producto.CodigoM, producto.CodigoP, producto.Cantidad, producto.Fecha, producto.PrecioC, producto.PrecioV), con);
                retorno = comando.ExecuteNonQuery();

                con.Close();
            }
            return retorno;
        }
        public static int InsertarCliente(Cliente usuario)
        {
            int retorno = 0; // en el caso de que no se inserter el registro retornara cero
            using (SqlConnection con = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Insert into cliente(cod_cliente, ced_cliente, nom_cliente, ape_cliente, dir_cliente, telf_cliente, email_cliente, cod_ciudad, estado_cliente) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')", usuario.Codigo, usuario.Cedula, usuario.Nombre, usuario.Apellido, usuario.Direccion, usuario.Telefono, usuario.Email, usuario.Ciudad, usuario.Estado), con);
                retorno = comando.ExecuteNonQuery();

                con.Close();
            }
            return retorno;
        }

        public static int InsertarProveedor(Proveedor usuario)
        {
            int retorno = 0; // en el caso de que no se inserter el registro retornara cero
            using (SqlConnection con = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Insert into proveedor(cod_proveedor, razon_social, ruc, dir_proveedor, telf_proveedor, email_proveedor, cod_ciudad, estado_proveedor, fechaIngreso) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')", usuario.Codigo, usuario.Nombre, usuario.Ruc, usuario.Direccion, usuario.Telefono, usuario.Email, usuario.Ciudad, usuario.Estado, usuario.FechaI), con);
                retorno = comando.ExecuteNonQuery();

                con.Close();
            }
            return retorno;
        }


        public static int InsertarUsuario(Usuarios usuario)
        {
            int retorno = 0; // en el caso de que no se inserter el registro retornara cero
            using (SqlConnection con = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Insert into usuario(cod_empleado, ced_empleado, nom_empleado, ape_empleado, dir_empleado, telf_empleado,email_empleado, user_empleado, contra_empleado, tipo_empleado, urlfoto_empleado, cod_ciudad, estado, fechaI) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}')", usuario.Codigo, usuario.Cedula, usuario.Nombre, usuario.Apellido, usuario.Direccion, usuario.Telefono, usuario.Email, usuario.User, usuario.Contra, usuario.TipoEmpleado, usuario.Url, usuario.CodigoCiudad, usuario.Estado, usuario.Fecha), con);
                retorno = comando.ExecuteNonQuery();

                con.Close();
            }
            return retorno;
        }

        public static int InsertarCategoria(Categoria cat)
        {
            int retorno = 0; // en el caso de que no se inserter el registro retornara cero
            using (SqlConnection con = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Insert into categoria(cod_categoria, categoria, estado_categoria) values ('{0}', '{1}', '{2}')", cat.Codigo, cat.Categoria1, cat.Estado), con);
                retorno = comando.ExecuteNonQuery();

                con.Close();
            }
            return retorno;
        }


        public static int InsertarControl(ControlPagos cat)
        {
            int retorno = 0; // en el caso de que no se inserter el registro retornara cero
            using (SqlConnection con = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Insert into controlPagos(num_factp, cod_proveedor, fecha_entrega, cantidad, total, url_factura) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", cat.NumFact, cat.CodigoProve, cat.Fecha, cat.Cantidad, cat.Total, cat.UrlFoto), con);
                retorno = comando.ExecuteNonQuery();

                con.Close();
            }
            return retorno;
        }


        public static int InsertarPagos(PagosFactura cat)
        {
            int retorno = 0; // en el caso de que no se inserter el registro retornara cero
            using (SqlConnection con = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Insert into pagoFacturasCompra(cod_egresoc, num_factp, fecha_pago, nro_cuenta_banco, monto_pagar, banco) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", cat.Codigo, cat.NumFactP, cat.Fecha, cat.NroCuenta, cat.Monto, cat.Banco), con);
                retorno = comando.ExecuteNonQuery();

                con.Close();
            }
            return retorno;
        }

        public static int ActualizarUsuario(string codigo, string cedula, string nombre, string apellido, string direccion, string telefono, string email, string user, string contra, string tipo, string url , string ciudad, bool estado, string fecha)
        {
            int retorno = 0; // en el caso de que no se borre el registro retornara cero
            using (SqlConnection con = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand("update usuario set cod_empleado='" + codigo + "', ced_empleado='" + cedula + "', nom_empleado='" + nombre + "', ape_empleado='" + apellido + "', dir_empleado='" + direccion + "', telf_empleado='" + telefono + "', email_empleado='" + email + "', user_empleado='" + user + "', contra_empleado='" + contra + "', tipo_empleado='" + tipo + "', urlfoto_empleado='" + url + "', cod_ciudad='" + ciudad + "', estado='" + estado  +"', fechaI='" + fecha + "' where cod_empleado like '" + codigo + "'", con);
                retorno = comando.ExecuteNonQuery();
                con.Close();
            }
            return retorno;
        }


        public static int ActualizarUsuario2(string codigo, string urlFoto, string user, string contra)
        {
            int retorno = 0; // en el caso de que no se borre el registro retornara cero
            using (SqlConnection con = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand("update usuario set urlfoto_empleado='" + urlFoto + "', user_empleado='" + user + "', contra_empleado='" + contra + "' where cod_empleado like '" + codigo + "'", con);
                retorno = comando.ExecuteNonQuery();
                con.Close();
            }
            return retorno;
        }


        public static int ActualizarCliente(string codigo, string cedula, string nombre, string apellido, string direccion, string telefono, string email,  string ciudad, bool estado)
        {
            int retorno = 0; // en el caso de que no se borre el registro retornara cero
            using (SqlConnection con = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand("update cliente set cod_cliente='" + codigo + "', ced_cliente='" + cedula + "', nom_cliente='" + nombre + "', ape_cliente='" + apellido + "', dir_cliente='" + direccion + "', telf_cliente='" + telefono + "', email_cliente='" + email + "', cod_ciudad='" + ciudad + "', estado_cliente='" + estado + "' where cod_cliente like '" + codigo + "'", con);
                retorno = comando.ExecuteNonQuery();
                con.Close();
            }
            return retorno;
        }

        public static int ActualizarProveedor(string codigo, string nombre, string cedula, string direccion, string telefono, string email, string ciudad, bool estado, string fecha)
        {
            int retorno = 0; // en el caso de que no se borre el registro retornara cero
            using (SqlConnection con = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand("update proveedor set cod_proveedor='" + codigo + "',  razon_social='" + nombre + "', ruc='" + cedula + "', dir_proveedor='" + direccion + "', telf_proveedor='" + telefono + "', email_proveedor='" + email + "', cod_ciudad='" + ciudad + "', estado_proveedor='" + estado + "', fechaIngreso='" + fecha + "' where cod_proveedor like '" + codigo + "'", con);
                retorno = comando.ExecuteNonQuery();
                con.Close();
            }
            return retorno;
        }

        public static int ActualizarCategoria(string codigo,string categoria, bool estado)
        {
            int retorno = 0; // en el caso de que no se borre el registro retornara cero
            using (SqlConnection con = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand("update categoria set cod_categoria='" + codigo + "',  categoria='" + categoria + "', estado_categoria='" + estado + "' where cod_categoria like '" + codigo + "'", con);
                retorno = comando.ExecuteNonQuery();
                con.Close();
            }
            return retorno;
        }


        public static int ActualizarControlP(string numF, string codP, string fecha, int cantidad, decimal total, string url)
        {
            int retorno = 0; // en el caso de que no se borre el registro retornara cero
            using (SqlConnection con = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand("update controlPagos set cod_proveedor='" + codP + "', fecha_entrega='" + fecha + "', cantidad='" + cantidad + "', total='" + total + "', url_factura='" + url + "' where num_factp like '" + numF + "'", con);
                retorno = comando.ExecuteNonQuery();
                con.Close();
            }
            return retorno;
        }



        public static int ActualizarProducto(string codigo, string categoria, string proveedor, string producto, string fecha, int stock, double precioC, double precioV, bool estado)
        {
            int retorno = 0; // en el caso de que no se borre el registro retornara cero
            using (SqlConnection con = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand("update producto set cod_producto='" + codigo + "',  cod_categoria='" + categoria + "', cod_proveedor='" + proveedor + "', producto='" + producto + "', fecha_vencimiento='" + fecha + "', stock='" + stock + "', precio_compra='" + precioC + "', precio_venta='" + precioV + "', estado_producto='" + estado+ "' where cod_producto like '" + codigo + "'", con);
                retorno = comando.ExecuteNonQuery();
                con.Close();
            }
            return retorno;
        }


        public static int ActualizarPagos(string cod, string numF, string fecha, int nroC, decimal monto, string banco)
        {
            int retorno = 0; // en el caso de que no se borre el registro retornara cero
            using (SqlConnection con = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand("update pagoFacturasCompra set num_factp='" + numF + "',  fecha_pago='" + fecha + "', nro_cuenta_banco='" + nroC + "', monto_pagar='" + monto + "', banco='" + banco + "' where cod_egresoc like '" + cod + "'", con);
                retorno = comando.ExecuteNonQuery();
                con.Close();
            }
            return retorno;
        }


        public static int ActualizarEstadoUsuario(string codigo, bool estado)
        {
            int retorno = 0; // en el caso de que no se borre el registro retornara cero
            using (SqlConnection con = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand("update usuario set estado='" + estado + "' where cod_empleado like '" + codigo + "'", con);
                retorno = comando.ExecuteNonQuery();
                con.Close();
            }
            return retorno;
        }


        public static int ActualizarEstadoCliente(string codigo, bool estado)
        {
            int retorno = 0; // en el caso de que no se borre el registro retornara cero
            using (SqlConnection con = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand("update cliente set estado_cliente='" + estado + "' where cod_cliente like '" + codigo + "'", con);
                retorno = comando.ExecuteNonQuery();
                con.Close();
            }
            return retorno;
        }

        public static int ActualizarEstadoProveedor(string codigo, bool estado)
        {
            int retorno = 0; // en el caso de que no se borre el registro retornara cero
            using (SqlConnection con = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand("update proveedor set estado_proveedor='" + estado + "' where cod_proveedor like '" + codigo + "'", con);
                retorno = comando.ExecuteNonQuery();
                con.Close();
            }
            return retorno;
        }


        public static int ActualizarEstadoCategoria(string codigo, bool estado)
        {
            int retorno = 0; // en el caso de que no se borre el registro retornara cero
            using (SqlConnection con = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand("update categoria set estado_categoria='" + estado + "' where cod_categoria like '" + codigo + "'", con);
                retorno = comando.ExecuteNonQuery();
                con.Close();
            }
            return retorno;
        }

        public static void ActualizarStock(string codigo, int stock)
        {
            int retorno = 0; // en el caso de que no se borre el registro retornara cero
            using (SqlConnection con = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand("update producto set stock='" + stock + "' where cod_producto like '" + codigo + "'", con);
                retorno = comando.ExecuteNonQuery();
                con.Close();
            }
          //  return retorno;
        }

        public static int ActualizarStock3(string codigo, int stock, string fecha)
        {
            int retorno = 0; // en el caso de que no se borre el registro retornara cero
            using (SqlConnection con = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand("update producto set stock='" + stock + "',  fecha_vencimiento='" +fecha +  "' where cod_producto like '" + codigo + "'", con);
                retorno = comando.ExecuteNonQuery();
                con.Close();
            }

            return retorno;
            //  return retorno;
        }

        public static void ActualizarStock2(string producto, int stock)
        {
            int retorno = 0; // en el caso de que no se borre el registro retornara cero
            using (SqlConnection con = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand("update producto set stock='" + stock + "' where producto like '" + producto + "'", con);
                retorno = comando.ExecuteNonQuery();
                con.Close();
            }
            //  return retorno;
        }

        public static int ActualizarEstadoProducto(string codigo, bool estado)
        {
            int retorno = 0; // en el caso de que no se borre el registro retornara cero
            using (SqlConnection con = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand("update producto set estado_producto='" + estado + "' where cod_producto like '" + codigo + "'", con);
                retorno = comando.ExecuteNonQuery();
                con.Close();
            }
            return retorno;
        }

        public static int ActualizarAnulacionFactura(string codigo, bool estado)
        {
            int retorno = 0; // en el caso de que no se borre el registro retornara cero
            using (SqlConnection con = Conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand("update facturaCliente set anulado='" + estado + "' where numFact_cliente like '" + codigo + "'", con);
                retorno = comando.ExecuteNonQuery();
                con.Close();
            }
            return retorno;
        }





       
        

    }
}
