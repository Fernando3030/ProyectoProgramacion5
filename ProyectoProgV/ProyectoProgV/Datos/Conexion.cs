using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoProgV.Properties;
using System.Configuration;

namespace ProyectoProgV
{
    class Conexion
    {
        public static string obtenerString()
        {
            return Settings.Default.BDNutrilConnectionString;
        }

        public static SqlConnection obtenerConexion()
        {
            SqlConnection con = new SqlConnection(obtenerString());
            con.Open();

            return con;

        }
    }
}
