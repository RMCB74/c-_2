using CRUD_CSharp1.Config;
using CRUD_CSharp1.Entidad;
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

 
namespace CRUD_CSharp1
{
    public partial class Form1 : Form
    {

        public string DatoRetornadoPermiso { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            int este = 2;
            if (este == 1)
            {
                Conexion.Conectar();

                dtGridViewEmp.DataSource = Index();
            }
            if (este == 2)
            {
                //test conexion
                //Config.CConexion objconxion = new CConexion();
                //objconxion.establecerConexion();

                //Config.CEmpleado objEmp = new CEmpleado();
                //objEmp.mostrarEmp(dtGridViewEmp);
                mostrarEmp(este);

                //objconxion.cerrarConexion();
            }

            btnAgrega.Enabled = false;
            btnElimina.Enabled = false;
            btnModifica.Enabled = false;

            //E-A,S-A,ES-A,E-C,S-C,ES-C
            if (this.DatoRetornadoPermiso.ToString().IndexOf("E-A") >= 0)
            {
                btnAgrega.Enabled = true;
                btnElimina.Enabled = true;
                btnModifica.Enabled = true;
            }

            char delimiter = ',';
            string[] retornas = this.DatoRetornadoPermiso.ToString().Split(delimiter);

            foreach (string retorna in retornas)
            {
                Console.WriteLine(retorna);
                if (retorna.Contains("E-A"))
                {
                    btnAgrega.Enabled = true;
                    btnElimina.Enabled = true;
                    btnModifica.Enabled = true;

                    break;
                }
            }

        }

        public DataTable Index()
        {
            Conexion.Conectar();

            DataTable datatable = new DataTable();
            string sql = @"Select * from  DEVS26.dbo.Empleado";
            SqlCommand cmd = new SqlCommand(sql, Conexion.Conectar());

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            adapter.Fill(datatable);

             return datatable;      
        }

        private void btnAgrega_Click(object sender, EventArgs e)
        {
            int este = 3;
            if (btnAgrega.Text.ToUpper() == "NUEVO") 
            {
                txtID.Text = "0"; 
                txtIdEmp_.Text = string.Empty; 
                txtNom.Text = string.Empty;
                txtApat.Text = string.Empty;
                txtAma.Text = string.Empty;
                dtimePkFecha.Value = DateTime.Now;

                btnAgrega.Text = "Agregar";

                txtUser.Text = string.Empty;
                txtPWD.Text = string.Empty;

                txtPermiso.Text = "E-A,S-A,ES-A,E-C,S-C,ES-C";
                return;
            }

            if (este == 1)
            {
                    Conexion.Conectar();
                string sql_Ins = @"insert into DEVS26.dbo.Empleado(Nombre,APat,AMat,FNacim,PWD,User,User_Permiso)";
                sql_Ins += string.Concat("values (@Nombre, @APat, @AMat, @FNacim " +
                                    ",@PWD,@User,@User_Permiso)", "");
           
                SqlCommand   sqlCommAgr = new SqlCommand(sql_Ins, Conexion.Conectar());
                sqlCommAgr.Parameters.Add("@Nombre", SqlDbType.VarChar);
                sqlCommAgr.Parameters[0].Value = txtNom.Text;

                sqlCommAgr.Parameters.Add(new SqlParameter("@APat", SqlDbType.VarChar,100) {Value = txtApat.Text});                              
 
                sqlCommAgr.Parameters.AddWithValue("@AMat", txtAma.Text);
                sqlCommAgr.Parameters.AddWithValue("@FNacim", dtimePkFecha.Value);

                sqlCommAgr.Parameters.AddWithValue("@PWD", txtPWD.Text);
                sqlCommAgr.Parameters.AddWithValue("@User", txtUser.Text);
                sqlCommAgr.Parameters.AddWithValue("@User_Permiso", txtPermiso.Text);

                sqlCommAgr.ExecuteNonQuery();

                MessageBox.Show("Dato ingresado");

                dtGridViewEmp.DataSource = Index(); 
            }
            
            if (este == 2)
            {

                Config.CEmpleado objEmp = new Config.CEmpleado();                
                objEmp.GuardarEmp(txtID, txtNom, txtApat, txtAma, dtimePkFecha
                    , txtPWD , txtUser , txtPermiso);
                 
                MessageBox.Show("Dato ingresado");
                btnAgrega.Text = "Nuevo";
                objEmp.mostrarEmp(dtGridViewEmp);
            }

            if (este == 3)
            {

                Config.CEmpleado objEmp = new Config.CEmpleado();
                CRUD_CSharp1.Entidad.E_Empleado eEmpleado = new Entidad.E_Empleado();
                string resultado = string.Empty;

                eEmpleado.IDOperacion = 1;
                eEmpleado.IDEmpleado = Int32.Parse(txtID.Text.ToString());
                eEmpleado.IDEmp_ =  txtIdEmp_.Text.ToString();
                eEmpleado.Nombre = txtNom.Text;
                eEmpleado.APat = txtApat.Text;
                eEmpleado.AMat = txtAma.Text;
                eEmpleado.FNacim = dtimePkFecha.Value;
                eEmpleado.PWD = txtPWD.Text;
                eEmpleado.User = txtUser.Text;
                eEmpleado.User_Permiso = txtPermiso.Text;


                resultado = objEmp.GuardarEmp(eEmpleado);

                if (resultado == string.Empty)
                { 
                    MessageBox.Show("Dato ingresado", "Agregado",
                System.Windows.Forms.MessageBoxButtons.OKCancel,
                System.Windows.Forms.MessageBoxIcon.Information);
                    btnAgrega.Text = "Nuevo";
                    txtID.Text = "0";

                    txtIdEmp_.Text = string.Empty;
                    txtNom.Text = string.Empty;
                    txtApat.Text = string.Empty;
                    txtAma.Text = string.Empty;
                    dtimePkFecha.Value = DateTime.Now;

                    btnAgrega.Text = "Nuevo";

                    txtUser.Text = string.Empty;
                    txtPWD.Text = string.Empty;

                    txtPermiso.Text = "";


                     

                    eEmpleado.IDOperacion = 0;

                    eEmpleado.Nombre = txtNom.Text;
                    eEmpleado.APat = txtApat.Text;
                    eEmpleado.AMat = txtAma.Text;

                     
                     eEmpleado.FNacim = new DateTime(1900, 01, 01);

                    eEmpleado.User = txtUser.Text;
                    eEmpleado.User_Permiso = txtPermiso.Text;

                    objEmp.mostrarEmp(dtGridViewEmp, eEmpleado);

                    //objEmp.mostrarEmp(dtGridViewEmp);
                }
                else
                {

                    MessageBox.Show("Dato no ingresado" + Environment.NewLine + resultado, "Agregado eError");

                   MessageBox.Show("Dato no ingresado" + Environment.NewLine + resultado, "Agregado",
                System.Windows.Forms.MessageBoxButtons.RetryCancel,
                System.Windows.Forms.MessageBoxIcon.Error);
                }
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {

        }

        private void btnElimina_Click(object sender, EventArgs e)
        {

        }

        private void dtGridViewEmp_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Config.CEmpleado objEmp = new Config.CEmpleado();
            objEmp.SeleccionarEmp(dtGridViewEmp, txtID, txtIdEmp_, txtNom, txtApat, txtAma, dtimePkFecha,
                txtUser, txtPermiso);
        }

        private void btnConulta_Click(object sender, EventArgs e)
        {
            if (btnAgrega.Text.ToUpper() == "AGREGAR")
            {

                DialogResult resultado = MessageBox.Show(
                    "¿Estás seguro de que deseas continuar sin guardar esto?", // Mensaje
                    "Confirmación",                             // Título
                    MessageBoxButtons.YesNo,                    // Botones
                    MessageBoxIcon.Question                     // Icono
                );

                if (resultado == DialogResult.Yes)
                {
                    txtID.Text = "0";
                    txtIdEmp_.Text = string.Empty;
                    txtNom.Text = string.Empty;
                    txtApat.Text = string.Empty;
                    txtAma.Text = string.Empty;
                    dtimePkFecha.Value = DateTime.Now;

                    btnAgrega.Text = "Nuevo";

                    txtUser.Text = string.Empty;
                    txtPWD.Text = string.Empty;

                    txtPermiso.Text = "";


                }
                else
                {
                    return;
                }
            }
            else
            {

        
            //string filterField = "Nombre";
                //if (chkGrid.Checked)
                //{ 
                //    ((DataTable)dtGridViewEmp.DataSource).DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", filterField, txtNom.Text);
                //    ((DataTable)dtGridViewEmp.DataSource).DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", filterField, txtNom.Text);
                //}
                //else
                //{
                    int este = 2;
                    if (este == 1)
                        mostrarEmp(este);

                    if (este == 2)
                    {                        
                        mostrarEmp(este);
                    }

                //}
            } 
        }

        private void mostrarEmp(int este)
        {
            Config.CEmpleado objEmp = new CEmpleado();
            
            if (este == 1)
                objEmp.mostrarEmp(dtGridViewEmp);

            if (este == 2)
            {
                Entidad.E_Empleado eEmpleado = new Entidad.E_Empleado();

                eEmpleado.IDOperacion = 0;

                eEmpleado.Nombre = txtNom.Text;
                eEmpleado.APat = txtApat.Text;
                eEmpleado.AMat = txtAma.Text;  
                
                if (chkFecha.Checked )
                    eEmpleado.FNacim = dtimePkFecha.Value;
                else
                    eEmpleado.FNacim = new DateTime(1900, 01, 01);

                eEmpleado.User = txtUser.Text;
                eEmpleado.User_Permiso = txtPermiso.Text;

                objEmp.mostrarEmp(dtGridViewEmp,eEmpleado);
            }

        }

        private void lblPermiso_Click(object sender, EventArgs e)
        {
            txtPermiso.Text = "E-A,S-A,ES-A,E-C,S-C,ES-C";
        }
    }

}
