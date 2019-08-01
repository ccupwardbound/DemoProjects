using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GetDataTest
{
    class MakeRequest
    {
        public static string MakeHttpRequest()
        {
            var client = GetClient.GetHttpClient();

            //HttpResponseMessage response = client.GetAsync("https://api.openweathermap.org/data/2.5/weather?zip=98531,us&appid=7b18f1b44130ba322ebacb9174b7a200").Result;

            var baseAddress = "https://api.openweathermap.org/data/2.5/";
            var endpoint = "weather?zip=";
            var zip = "98531";
            var country = "us";
            var appIdEndpoint = "appid=";
            var appId = "7b18f1b44130ba322ebacb9174b7a200";

            var dataEndpoint = baseAddress + endpoint + zip + "," + country + "&" + appIdEndpoint + appId;

            HttpResponseMessage response = client.GetAsync(dataEndpoint).Result;
            
            //if we get data back
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsStringAsync().Result;
            }
            //other wise do something else
            Console.WriteLine("Error: " + response.StatusCode + " ||| " + response.ReasonPhrase + " ||| " + response.RequestMessage);
            Console.ReadLine();
            return "";
        }

        public static WeatherData DeserializeResponseData(string data)
        {
            //Product deserializedProduct = JsonConvert.DeserializeObject<Product>(output);
            return JsonConvert.DeserializeObject<WeatherData>(data);
        }
    }
}
