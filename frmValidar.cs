using CRUD_CSharp1.Config;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CRUD_CSharp1
{
    public partial class frmValidar : Form
    {

        public string DatoRetornadoIDEmp_ { get; private set; }
        public string DatoRetornadoNombre { get; private set; }
        public string DatoRetornadoPermiso { get; private set; }


        public frmValidar()
        {
            InitializeComponent();
        }

        private void frmValidar_Load(object sender, EventArgs e)
        {
            int? entero = null;

            entero = 1;
        }

        private void cmdValida_Click(object sender, EventArgs e)
        {
            DatoRetornadoIDEmp_ = txtUsr.Text;
            DatoRetornadoNombre = txtUsr.Text;
            DatoRetornadoPermiso = txtPswrd.Text;

            DatoRetornadoIDEmp_ = DatoRetornadoIDEmp_.Replace(Environment.NewLine, string.Empty);
            DatoRetornadoPermiso = DatoRetornadoPermiso.Replace(Environment.NewLine, string.Empty);

            string Retornado = string.Empty;
            Config.CEmpleado objEmp = new Config.CEmpleado();
            Retornado = objEmp.ValidarEmp(DatoRetornadoIDEmp_, @DatoRetornadoPermiso);

            if (!Retornado.Trim().Contains("Error|:|")) 
            {
                char delimiter = '|';
                string[] retornas = Retornado.Split(delimiter);

                foreach (string retorna in retornas)
                {
                    Console.WriteLine(retorna);                
                }
                this.DatoRetornadoIDEmp_ = retornas[0];
                this.DatoRetornadoNombre = retornas[1];
                this.DatoRetornadoPermiso = retornas[2];
 

                if (DatoRetornadoIDEmp_.ToString().Trim().Length > 0)  
                {
                    this.DialogResult = DialogResult.OK;

                    // 3. Ocultar en lugar de cerrar
                    this.Hide();
                    this.Close();
                }
                else
                {
                    string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                    Log oLog = new Log(@path);
                    oLog.Add("No encontrado:"+ DatoRetornadoIDEmp_);
                    this.DialogResult = DialogResult.Cancel;

                }
            }
            else
            {
                string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                path += @"\Log\";
                Log oLog = new Log(@path);
                oLog.Add(Retornado+ "|"+DatoRetornadoIDEmp_);
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}
