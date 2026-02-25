using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace CRUD_CSharp1.Config
{
    internal class Log
    {
        private string path = string.Empty;
        

        public Log(string Path)
        {
            this.path = Path;

        }

        public void Add(string sLog)
        {
            CreaDirectorio();
            string nombre = GetNombreArchivo();
            string cadena = "";

            cadena += DateTime.Now + " - " + sLog + Environment.NewLine;

            StreamWriter sw = new StreamWriter(path+"/"+nombre,true,Encoding.UTF8);
            sw.Write(cadena);
            sw.Close();
        }

        private string GetNombreArchivo()
        {
            string nombre = "";
            nombre = string.Concat("Log_", DateTime.Now.ToString("yyyy"), DateTime.Now.ToString("MM"), DateTime.Now.ToString("dd"), ".txt");

            return nombre;
        }
        private void CreaDirectorio()
        {
            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
            }
            catch(DirectoryNotFoundException ex)
            {
                throw new Exception(ex.Message);
            }    
        }

    }


}
