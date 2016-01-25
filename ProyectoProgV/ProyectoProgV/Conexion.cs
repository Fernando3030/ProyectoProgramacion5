using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgV
{
    class Conexion
    {

        public static SqlConnection obtenerConexion()
        {
            SqlConnection con = new SqlConnection("Data source=PC; Initial Catalog=BDNutril; Integrated Security=SSPI");
            con.Open();

            return con;

        }
    }
}
