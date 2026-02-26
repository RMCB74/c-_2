using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_CSharp1.Repository
{
    public class FileZipRepository : IRepository
    {

        private string _file{ get; set; }
        private string _folder { get; set; }
        private string _pathZip { get; set; }

        private string _pathFile { get; set; }  

        public FileZipRepository(string file, string folder, string pathZip)
        {
            _file = file;
            _folder = folder;   
            _pathZip = pathZip;

            _pathFile  = _folder + "/" + _file;
        }

        public  void Save(string content)
        {
            //System.IO.File.WriteAllText(path2, texto);
            //System.IO.Compression.ZipFile.CreateFromDirectory(pathfolder, pathZip);

            //await File.WriteAllText(_pathFile, content);
            File.WriteAllText(_pathFile, content);
            System.IO.Compression.ZipFile.CreateFromDirectory(_folder, _pathZip);



        }

    }
}
