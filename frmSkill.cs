using CRUD_CSharp1.Config;
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
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int este = 1;
            if (este==1)
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
                mostrarEmp();

                //objconxion.cerrarConexion();
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
            int este = 1;
            if (btnAgrega.Text.ToUpper() == "NUEVO") 
            {
                txtID.Text = "0"; 
                txtIdEmp_.Text = string.Empty; 
                txtNom.Text = string.Empty;
                txtApat.Text = string.Empty;
                txtAma.Text = string.Empty;
                dtimePkFecha.Value = DateTime.Now;

                btnAgrega.Text = "Agregar";

                return;
            }

            if (este == 1)
            {
                    Conexion.Conectar();
                string sql_Ins = @"insert into DEVS26.dbo.Empleado(Nombre,APat,AMat,FNacim)";
                sql_Ins += string.Concat("values (@Nombre, @APat, @AMat, @FNacim)", "");
           
                SqlCommand   sqlCommAgr = new SqlCommand(sql_Ins, Conexion.Conectar());
                sqlCommAgr.Parameters.AddWithValue("@Nombre", txtNom.Text);
                sqlCommAgr.Parameters.AddWithValue("@APat", txtApat.Text);
                sqlCommAgr.Parameters.AddWithValue("@AMat", txtAma.Text);
                sqlCommAgr.Parameters.AddWithValue("@FNacim", dtimePkFecha.Value);

                sqlCommAgr.ExecuteNonQuery();

                MessageBox.Show("Dato ingresado");

                dtGridViewEmp.DataSource = Index(); 
            }
            if (este == 2)
            {

                Config.CEmpleado objEmp = new Config.CEmpleado();                
                objEmp.GuardarEmp(txtID, txtNom, txtApat, txtAma, dtimePkFecha);
                 
                MessageBox.Show("Dato ingresado");
                btnAgrega.Text = "Nuevo";
                objEmp.mostrarEmp(dtGridViewEmp);
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
            objEmp.SeleccionarEmp(dtGridViewEmp, txtID, txtIdEmp_, txtNom, txtApat, txtAma, dtimePkFecha);
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
 
                }
                else
                {
                    return;
                }
            }

            mostrarEmp();
        }

        private void mostrarEmp()
        {
            Config.CEmpleado objEmp = new CEmpleado();
            objEmp.mostrarEmp(dtGridViewEmp);

        }

        
    }

}
