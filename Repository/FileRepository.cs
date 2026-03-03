using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_CSharp1.Repository
{
    public class FileRepository: IRepository
    {
        private string _path { get; set; }

        public  FileRepository(string path)
        { 
            _path= path;
        }

        public  void  Save(string content)
        {
            System.IO.File.WriteAllText(_path, content);//
        }
    }

    
}
