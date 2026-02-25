using CRUD_CSharp1.Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_CSharp1.Config
{
    internal class CEmpleado
    {
        public void mostrarEmp(DataGridView tablaEmp)
        {
            CConexion objconxion = new CConexion();

            try
            {
                tablaEmp.DataSource = null;

                DataTable datatable = new DataTable();
                string sql = @"Select IDEmpleado,IDEmp_,Nombre,APat,AMat,FNacim,	User,User_Permiso from  DEVS26.dbo.Empleado";
                SqlCommand cmd = new SqlCommand(sql, objconxion.establecerConexion());

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(datatable);

                tablaEmp.DataSource = datatable;

                objconxion.cerrarConexion();
            }
            catch(Exception ex) {
                objconxion.cerrarConexion();

                MessageBox.Show("No Connecto" + ex.ToString());
            }
        }

        public void mostrarEmp(DataGridView tablaEmp, E_Empleado eEmpleado)
        {
            CConexion objconxion = new CConexion();

            try
            {
                tablaEmp.DataSource = null;

                DataTable datatable = new DataTable();
                string sql = @"Select * from  DEVS26.dbo.Empleado";
                sql = @".dbo.Dev_spr_Empleado ";

                SqlCommand sqlCommAgr = new SqlCommand(sql, objconxion.establecerConexion());
                sqlCommAgr.CommandType = CommandType.StoredProcedure;

                eEmpleado.IDOperacion = eEmpleado.IDOperacion.Equals(System.DBNull.Value) ? 0 : eEmpleado.IDOperacion;
                eEmpleado.Nombre = eEmpleado.Nombre.Equals(System.DBNull.Value) ? "" : eEmpleado.Nombre;
                eEmpleado.APat = eEmpleado.APat.Equals(System.DBNull.Value) ? "" : eEmpleado.APat;
                eEmpleado.AMat = eEmpleado.AMat.Equals(System.DBNull.Value) ? "" : eEmpleado.AMat;
                eEmpleado.FNacim = eEmpleado.FNacim.Equals(System.DBNull.Value) ? new DateTime(1900, 01, 01) : eEmpleado.FNacim;
                eEmpleado.PWD = null;
                eEmpleado.User = eEmpleado.User.Equals(System.DBNull.Value) ? "" : eEmpleado.User;
                eEmpleado.User_Permiso = eEmpleado.User_Permiso.Equals(System.DBNull.Value) ? "" : eEmpleado.User_Permiso;

                sqlCommAgr.Parameters.Add("@IDOperacion", SqlDbType.Int);
                sqlCommAgr.Parameters[0].Value = eEmpleado.IDOperacion;
                sqlCommAgr.Parameters["@IDOperacion"].Value = eEmpleado.IDOperacion;

                sqlCommAgr.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar) { Value = eEmpleado.Nombre.Equals(System.DBNull.Value) ? null : eEmpleado.Nombre});
                sqlCommAgr.Parameters.Add(new SqlParameter("@APat", SqlDbType.VarChar) { Value = eEmpleado.APat.Equals(System.DBNull.Value) ? null : eEmpleado.APat });
                sqlCommAgr.Parameters.Add(new SqlParameter("@AMat", SqlDbType.VarChar) { Value = eEmpleado.AMat.Equals(System.DBNull.Value) ? null : eEmpleado.AMat });
                sqlCommAgr.Parameters.Add(new SqlParameter("@FNacim", SqlDbType.DateTime) { Value = eEmpleado.FNacim.ToString()});
                
                sqlCommAgr.Parameters.Add(new SqlParameter("@User", SqlDbType.VarChar) { Value = eEmpleado.User.Equals(System.DBNull.Value) ? null : eEmpleado.User });
                sqlCommAgr.Parameters.Add(new SqlParameter("@User_Permiso", SqlDbType.VarChar) { Value = eEmpleado.User_Permiso.Equals(System.DBNull.Value) ? null : eEmpleado.User_Permiso });

                
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommAgr);

                adapter.Fill(datatable);

                tablaEmp.DataSource = datatable;

                objconxion.cerrarConexion();
            }
            catch (Exception ex)
            {
                objconxion.cerrarConexion();

                MessageBox.Show("No Connecto" + ex.ToString());
            }
        }

        public void GuardarEmp(TextBox IdEmp, TextBox Nom, TextBox Ap,  TextBox Am,   DateTimePicker Fec
            ,TextBox PWD ,  TextBox USR , TextBox Perm)
        {
            CConexion objconxion = new CConexion();

            try
            {
 
                string sql_Ins = @"insert into DEVS26.dbo.Empleado(Nombre,APat,AMat,FNacim, PWD, [User], User_Permiso)";
                sql_Ins += string.Concat("values (@Nombre, @APat, @AMat, @FNacim, @PWD, @User, @User_Permiso)", "");

                SqlCommand sqlCommAgr = new SqlCommand(sql_Ins, objconxion.establecerConexion());
                sqlCommAgr.Parameters.AddWithValue("@Nombre",  Nom.Text);
                sqlCommAgr.Parameters.AddWithValue("@APat",  Ap .Text);
                sqlCommAgr.Parameters.AddWithValue("@AMat",  Am .Text);
                sqlCommAgr.Parameters.AddWithValue("@FNacim", Fec.Value);

                sqlCommAgr.Parameters.AddWithValue("@PWD",  PWD.Text);
                sqlCommAgr.Parameters.AddWithValue("@User",  USR.Text);
                sqlCommAgr.Parameters.AddWithValue("@User_Permiso",  Perm.Text);

                sqlCommAgr.ExecuteNonQuery();

                objconxion.cerrarConexion();

                //MessageBox.Show("Dato ingresado");

                 
            }
            catch (Exception ex)
            {
                objconxion.cerrarConexion();

                MessageBox.Show("No Connecto" + ex.ToString());
            }
        }

        public string  GuardarEmp(E_Empleado eEmpleado )
        {
            CConexion objconxion = new CConexion();

            try
            {

                //string sql_Ins = @"insert into DEVS26.dbo.Empleado(Nombre,APat,AMat,FNacim, PWD, [User], User_Permiso)";
                //sql_Ins += string.Concat("values (@Nombre, @APat, @AMat, @FNacim, @PWD, @User, @User_Permiso)", "");
                //SqlCommand sqlCommAgr = new SqlCommand(sql_Ins, objconxion.establecerConexion());
                //sqlCommAgr.Parameters.AddWithValue("@Nombre", eEmpleado.Nombre );
               

                string sql = @".dbo.Dev_spr_Empleado ";               

                SqlCommand sqlCommAgr = new SqlCommand(sql, objconxion.establecerConexion());
                sqlCommAgr.CommandType = CommandType.StoredProcedure;

                eEmpleado.IDOperacion =  eEmpleado.IDOperacion.Equals(System.DBNull.Value) ? 0 : eEmpleado.IDOperacion;
                
                //eEmpleado.IDEmpleado = eEmpleado.IDEmpleado.Equals(System.DBNull.Value) ? -999 : eEmpleado.IDEmpleado;
                //eEmpleado.IDEmp_ = eEmpleado.Nombre.Equals(System.DBNull.Value) ? "" : eEmpleado.IDEmp_;

                eEmpleado.Nombre = eEmpleado.Nombre.Equals(System.DBNull.Value) ? "" : eEmpleado.Nombre;
                eEmpleado.APat = eEmpleado.APat.Equals(System.DBNull.Value) ? "" : eEmpleado.APat;
                eEmpleado.AMat = eEmpleado.AMat.Equals(System.DBNull.Value) ? "" : eEmpleado.AMat;
                eEmpleado.FNacim = eEmpleado.FNacim.Equals(System.DBNull.Value) ? new DateTime(1900, 01, 01)  : eEmpleado.FNacim;
                eEmpleado.PWD = eEmpleado.PWD.Equals(System.DBNull.Value) ? "" : eEmpleado.PWD;
                eEmpleado.User = eEmpleado.User.Equals(System.DBNull.Value) ? "" : eEmpleado.User;
                eEmpleado.User_Permiso = eEmpleado.User_Permiso.Equals(System.DBNull.Value) ? "" : eEmpleado.User_Permiso;

                sqlCommAgr.Parameters.Add("@IDOperacion", SqlDbType.Int);
                sqlCommAgr.Parameters[0].Value = eEmpleado.IDOperacion;
                sqlCommAgr.Parameters["@IDOperacion"].Value = eEmpleado.IDOperacion;

                //sqlCommAgr.Parameters.Add(new SqlParameter("@IDEmpleado", SqlDbType.Int) { Value = eEmpleado.IDEmpleado.ToString() });
                //sqlCommAgr.Parameters.Add(new SqlParameter("@IDEmp_", SqlDbType.VarChar) { Value = eEmpleado.IDEmp_.ToString() });

                sqlCommAgr.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar) { Value = eEmpleado.Nombre.ToString()});
                sqlCommAgr.Parameters.Add(new SqlParameter("@APat", SqlDbType.VarChar) { Value = eEmpleado.APat.ToString()});
                sqlCommAgr.Parameters.Add(new SqlParameter("@AMat", SqlDbType.VarChar) { Value = eEmpleado.AMat.ToString()});
                sqlCommAgr.Parameters.Add(new SqlParameter("@FNacim", SqlDbType.DateTime) { Value = eEmpleado.FNacim.ToString()});
                sqlCommAgr.Parameters.Add(new SqlParameter("@PWD", SqlDbType.VarChar) { Value = eEmpleado.PWD.ToString()});
                sqlCommAgr.Parameters.Add(new SqlParameter("@User", SqlDbType.VarChar) { Value = eEmpleado.User.ToString()});
                sqlCommAgr.Parameters.Add(new SqlParameter("@User_Permiso", SqlDbType.VarChar) { Value = eEmpleado.User_Permiso.ToString()});
                                                               

                sqlCommAgr.ExecuteNonQuery();

                objconxion.cerrarConexion();

                return string.Empty;
            }
            catch (Exception ex)
            {
                objconxion.cerrarConexion();
                return ex.Message.ToString(); ;//.ToString();
            }
        }


        public void SeleccionarEmp(DataGridView tablaEmp, TextBox IdEmp, TextBox IdEmp_, TextBox Nom, TextBox Ap, TextBox Am, DateTimePicker Fec,
              TextBox USR,  TextBox Perm)
        {
             
            try
            {
                IdEmp.Text = tablaEmp.CurrentRow.Cells[0].Value.ToString();
                IdEmp_.Text = tablaEmp.CurrentRow.Cells[1].Value.ToString();
                Nom.Text = tablaEmp.CurrentRow.Cells[2].Value.ToString();
                Ap.Text = tablaEmp.CurrentRow.Cells[3].Value.ToString();
                Am.Text = tablaEmp.CurrentRow.Cells[4].Value.ToString();
                Fec.Text = tablaEmp.CurrentRow.Cells[5].Value.ToString();

                USR.Text = tablaEmp.CurrentRow.Cells[7].Value.ToString();
                Perm.Text = tablaEmp.CurrentRow.Cells[8].Value.ToString();
                



            }
            catch (Exception ex)
            {
                MessageBox.Show("No leyo    " + ex.ToString());
            }
        }


        public string ValidarEmp(string Usr, string PWD)
        {
            CConexion objconxion = new CConexion();
            string regresa = string.Empty;
            try
            {                
                
                string sql = @".dbo.Dev_spr_Empleado "; 

                SqlCommand sqlCommAgr = new SqlCommand(sql, objconxion.establecerConexion());
                sqlCommAgr.CommandType = CommandType.StoredProcedure;

                sqlCommAgr.Parameters.AddWithValue("@IDOperacion", -1);
                sqlCommAgr.Parameters.AddWithValue("@User", Usr);
                sqlCommAgr.Parameters.AddWithValue("@PWD", PWD);

                SHA256 mySHa256 =  SHA256.Create();
                byte[] bpwd = mySHa256.ComputeHash(Encoding.UTF8.GetBytes(PWD));
                StringBuilder sb =new StringBuilder();

                for( int i =0; i < bpwd.Length; i++)
                {
                    sb.Append(bpwd[i].ToString("x2"));
                }
                sqlCommAgr.Parameters.AddWithValue("@PWD_", "0x" + sb.ToString());

                using (SqlDataReader reader = sqlCommAgr.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(string.Format("{0}, {1}, {2}", reader[0], reader[1], reader[2]));
                        regresa = string.Concat(reader[0], "|", reader[1], "|", reader[2]);
                    }
                }

                objconxion.cerrarConexion();

                if (regresa.Contains("||"))
                    return "Error|:| " + "No se identifica el DAto.";

                return regresa;
            }
            catch (Exception ex)
            {
                objconxion.cerrarConexion();
                MessageBox.Show("No Connecto" + ex.ToString());
                return "Error|:| "+ex.Message.ToString();
            }
        }


    }
}
