using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_CSharp1.Config
{
    internal class Conexion
    {

        public static SqlConnection Conectar()
        {
            SqlConnection conexion = new SqlConnection(
            "server=DESKTOP-N1FRO57\\SQLEXPRESS26; database=DEVS26; Trusted_Connection = true;");

            conexion.ConnectionString = 
            "server=DESKTOP-N1FRO57\\SQLEXPRESS26; database=DEVS26; Trusted_Connection = true;";

            conexion.Open();

            return conexion;
        }

    }
}
