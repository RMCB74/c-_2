using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_CSharp1.Formatters
{
    public class ToUpperFormatters : IFormatter_
    {
        public string Format(string content)
        {
            return content.ToUpper();//
        }
    }
}
