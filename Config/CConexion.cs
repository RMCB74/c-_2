using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_CSharp1.Config
{
    internal class CConexion
    {
        SqlConnection conex = new SqlConnection();

        //"server=DESKTOP-N1FRO57\\SQLEXPRESS26; database=DEVS26; Trusted_Connection = true;");
        static String server = "DESKTOP-N1FRO57\\SQLEXPRESS26";
        static String db = "DEVS26";
        static String usuario = "Usr1";
        static String contrasenia = "usr1pp";

        String cadenaConexion = string.Concat( 
            "Data Source= ", 
            server, ";user id=",
            usuario, ";password=", 
            contrasenia,";Initial Catalog=", 
            db, ";Persist Security Info =true"); 


        public SqlConnection establecerConexion()
            {

            try
            {
                // Autenticación SQL Server
                cadenaConexion = "Data Source=DESKTOP-N1FRO57\\SQLEXPRESS26;";
                cadenaConexion +="Initial Catalog =DEVS26;User ID=sa;Password=Holasx;";
                cadenaConexion +="Integrated Security = True;";
                //
                conex.ConnectionString = cadenaConexion;
                //if (conex == null)
                        conex.Open();

                //MessageBox.Show("Connecto");
            }
            catch (Exception ex) {

                MessageBox.Show("No Connecto"+ex.ToString());
            }
            

            return conex; 
        }
        public void cerrarConexion()
        {

            try
            {                 
                conex.Close();

                //MessageBox.Show("Connecto");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No Connecto" + ex.ToString());
            }

             
        }

    }
}
