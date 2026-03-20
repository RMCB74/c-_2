using CRUD_CSharp1.Formatters;
using CRUD_CSharp1.Repository;
using CRUD_CSharp1.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Compression;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace CRUD_CSharp1
{
    public partial class frmArq : Form
    {
        private string texto { get; set; }

        public frmArq()
        {
            InitializeComponent();
            texto = "texto arq";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int EsteArq = int.Parse(textBox2.Text.ToString());
            switch (EsteArq)
            {
                case (int)eEsteArq.HTTP:
                    ProcesaArq(eEsteArq.HTTP);
                    break;
                case (int)eEsteArq.FILE:
                    ProcesaArq(eEsteArq.FILE);//
                    break;
                case (int)eEsteArq.ZIP:
                    ProcesaArq(eEsteArq.ZIP);
                    break;

                default:


                    break;

            }
        }

        private void ProcesaArq(eEsteArq EsteArq)
        {

            int este = 2;
            textBox1.Text = "https://jsonplaceholder.typicode.com/post";
            if (textBox3.Text == string.Empty)
                este = 2;
            else
                este = textBox3.Text == "1" ? 1 : 2;

            if (este == 1)
            {
                switch (textBox2.Text)
                {
                    case "1":
                        string url = "https://jsonplaceholder.typicode.com/post";
                        var httpclient = new HttpClient();
                        var jsonContebt = new StringContent(texto);
                        var respone = httpclient.PostAsync(url, jsonContebt);
                        if (respone.IsCompleted)
                        {
                            //var content = await respone.Content.ReadAsStringAsync(); //.Content.ReadAsStringAsync();
                            label1.Text = "enviado";
                        }
                        break;
                    case "2":
                        string path = "file.txt";
                        System.IO.File.WriteAllText(path, texto);
                        label1.Text = "creado";
                        break;
                    case "3":
                        string path2 = "files/file.txt";

                        StringBuilder strB = new StringBuilder();
                        strB.Append("files");
                        strB.Append("/");
                        strB.Append("file");
                        strB.Append(".");
                        strB.Append("txt");

                        if (path2 == strB.ToString())
                        {
                            path2 = strB.ToString();
                        }

                        //string pathfolder? = "files";
                        string pathZip = "fileZip.zip";
                        System.IO.File.WriteAllText(path2, texto);
                        System.IO.Compression.ZipFile.CreateFromDirectory(path2, pathZip);

                        label1.Text = "zip";
                        break;

                    default:
                        label1.Text = "error";
                        break;
                }


            }
            if (este == 2)
            {
                var sender_ = new SerderService();
                //var sender_ = new CRUD_CSharp1.Service.SerderService();
                //int EsteArq = int.Parse(textBox2.Text.ToString());

                switch (EsteArq)
                {
                    case eEsteArq.HTTP:
                        sender_.Send(
                          new ToUpperFormatters(),
                          new HttpRepository(textBox1.Text),
                              "mensaje qq   ");
                        label1.Text = "se envio";
                        break;

                    case eEsteArq.FILE:
                        string path = string.Empty;
                        path = path + "file" + DateTime.Now.ToString("yyyymmdd");
                        path = path + ".txt";

                        sender_.Send(
                          new ToUpperwithoutSpaceFormatter(),
                          new FileRepository(path),
                          "  mensaje   b   ");
                        label1.Text = "se guardo";
                        break;
                    case eEsteArq.ZIP:
                        sender_.Send(
                           new ToUpperFormatters(),
                           new FileZipRepository("File.txt",
                           "files",
                           "fileZip.zip"),
                           "mensaje c");
                        label1.Text = "se zip";

                        break;

                    default:
                        label1.Text = "error";
                        break;

                }

            }
        }
        public enum eEsteArq//03032026
        {
            HTTP = 1,
            FILE = 2,
            ZIP = 3
        }

        private void frmArq_Load(object sender, EventArgs e)
        {

        }
    }
}
