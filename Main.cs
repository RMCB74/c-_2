using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_CSharp1
{
    public partial class Main : Form
    {

        private string DatoRetornadoIDEmp_ { get; set; }
        private string DatoRetornadoNombre { get; set; }
        private string DatoRetornadoPermiso { get; set; }

        static bool babrio = false;

        public Main()
        {
            InitializeComponent();

                      

        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form1 frmEm = new Form1();
            //frmEm.ShowDialog();

            Form1 frmEm = new Form1();
            frmEm.DatoRetornadoPermiso = this.DatoRetornadoPermiso;
            frmEm.ShowDialog();

        }

        private void skillToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            Skills frmSk = new Skills();
            frmSk.ShowDialog();
        }

        private void empSkilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }
            
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void validarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmValidar form2 =  new frmValidar();
            if (form2.ShowDialog() == DialogResult.OK)
            {
                // Leer la propiedad del formulario ya cerrado
                this.DatoRetornadoIDEmp_ = form2.DatoRetornadoIDEmp_;
                this.DatoRetornadoNombre = form2.DatoRetornadoNombre;
                this.DatoRetornadoPermiso = form2.DatoRetornadoPermiso;
                MessageBox.Show("Recibido: " + this.DatoRetornadoIDEmp_ + " " + this.DatoRetornadoNombre + " " + this.DatoRetornadoPermiso);

                //E-A,S-A,ES-A,E-C,S-C,ES-C
                if (this.DatoRetornadoPermiso.LastIndexOf("E-C") >0)
                {
                    empleadoToolStripMenuItem.Enabled = true;                   
                }
                skillToolStripMenuItem1.Enabled = this.DatoRetornadoPermiso.LastIndexOf("S-C") <= 0 ? false : true;
                empSkilToolStripMenuItem.Enabled = this.DatoRetornadoPermiso.LastIndexOf("ES-C") <= 0 ? false : true; 


            }
            else
                MessageBox.Show("no se identifica el usuario", "USER", MessageBoxButtons.OK);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            empleadoToolStripMenuItem.Enabled = false;
            skillToolStripMenuItem1.Enabled = false;
            empSkilToolStripMenuItem.Enabled = false;

            if (!babrio)
            {
                babrio = true;
                validarToolStripMenuItem_Click(this, EventArgs.Empty);
            }

        }

        private void Main_Resize(object sender, EventArgs e)
        {
            

        }

        private void jsonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmJsonv1 frmJSn = new frmJsonv1();
            frmJSn.ShowDialog();

        }
    }
}
