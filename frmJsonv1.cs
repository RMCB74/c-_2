using CRUD_CSharp1.Config;
using CRUD_CSharp1.Entidad;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_CSharp1
{
    public partial class frmJsonv1 : Form
    {
        private string filejsonPath { get; set; }
 
        public frmJsonv1()
        {
            InitializeComponent();
        }

        private void frmJsonv1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filejson = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Obtener la ruta del archivo
                    filejson = openFileDialog.FileName;
                    filejsonPath = filejson;
                    // Hacer algo con el archivo...
                    filejson = File.ReadAllText(filejson);
                    DataTable dt = (DataTable)JsonConvert.DeserializeObject(filejson, typeof(DataTable));
                    dgViewJson.DataSource = dt;

                    List<E_Jsonv1> lista = JsonConvert.DeserializeObject<List<E_Jsonv1>>(File.ReadAllText(filejsonPath));
                    dgViewJson.DataSource = new BindingList<E_Jsonv1>(lista);

                    //CJsonFile JfILE = new CJsonFile(filejsonPath);
                    dgViewJson.DataSource = new BindingList<E_Jsonv1>(CJsonFile.ListaJson(filejsonPath));

                    dgViewJson.DataSource = lista;//rmcb..1aa
                }
            }

           
        }

        private void btnguardaJson_Click(object sender, EventArgs e)
        {
            int este = 2;

            if (este == 1)//error
            { 
            List<E_Jsonv1> listaActualizada = (List<E_Jsonv1>)dgViewJson.DataSource;
            string nuevoJson = JsonConvert.SerializeObject(listaActualizada, Formatting.Indented);
            File.WriteAllText(@filejsonPath, nuevoJson);
            }

            if (este == 2)
            {
                var listaActualizada2 = (BindingList<E_Jsonv1>)dgViewJson.DataSource;
                listaActualizada2.OrderBy(x => x.Tip).ToList();

                string jsonActualizado = JsonConvert.SerializeObject(listaActualizada2.OrderByDescending(x => x.Tip), Formatting.Indented);

                File.WriteAllText(@filejsonPath, jsonActualizado);
            }

        }
    }
}
