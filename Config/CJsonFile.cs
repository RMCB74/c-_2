using CRUD_CSharp1.Entidad;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_CSharp1.Config
{
    internal static class CJsonFile
    {
        //private static string filejsonPath { get; set; }

        //public CJsonFile(string json) { 
        //        filejsonPath = json;
        //}

        public static List<E_Jsonv1> ListaJson(string filejsonPath)
        {

            List<E_Jsonv1> lista =  JsonConvert.DeserializeObject<List<E_Jsonv1>>(System.IO.File.ReadAllText(filejsonPath));

            return lista;

        }

    }
}
