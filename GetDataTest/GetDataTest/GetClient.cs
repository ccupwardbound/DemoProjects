using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace GetDataTest
{
    class GetClient
    {
        private static HttpClient client;

        public static HttpClient GetHttpClient()
        {
            if(client == null)
            {
                client = SetUpClient();
            }
                
            return client;
        }

        private static HttpClient SetUpClient()
        {
            var client = new HttpClient();

            //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "7b18f1b44130ba322ebacb9174b7a200");

            return client;
        }
    }
}
