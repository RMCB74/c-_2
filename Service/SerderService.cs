using CRUD_CSharp1.Formatters;
using CRUD_CSharp1.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_CSharp1.Service
{
    public class SerderService : ISenderService
    {
        public void  Send(IFormatter_ formmatter, IRepository repository, string message)
        {
            message = formmatter.Format(message);
              repository.Save(message);//
        }

    }
}
