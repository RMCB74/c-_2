using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_CSharp1.Formatters
{
    internal class ToUpperwithoutSpaceFormatter : IFormatter_
    {
        public string Format(string content)
        {
            content = content.ToUpper();
            return content.Replace(" ", "");//
        }
    }
}
