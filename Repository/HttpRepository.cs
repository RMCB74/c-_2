using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_CSharp1.Repository
{
    public class HttpRepository : IRepository
    {
        private string _url { get; set; }
        private HttpClient _hhtpClient { get; set; }


        public HttpRepository(string url) 
        {
            _url = url;   
            _hhtpClient = new HttpClient();
        }

        public  void Save(string message)
        {
            string url = "https://jsonplaceholder.typicode.com/post";
            var httpclient = new HttpClient();
            var jsonContebt = new StringContent(message);
            var respone = httpclient.PostAsync(url, jsonContebt);
            if (respone.IsCompleted)
            {
                //var content = await respone.Content.ReadAsStringAsync(); //.Content.ReadAsStringAsync();
                message = "enviado";


            }
        }
    }
}
