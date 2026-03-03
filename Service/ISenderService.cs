using CRUD_CSharp1.Formatters;
using CRUD_CSharp1.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_CSharp1.Service
{
    public interface ISenderService
    {
          void  Send(IFormatter_ formatter, IRepository repository, string  menssage);//
    }
}
