using Client.Data.Models;
using Client.UseCases;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Client.Data.Service
{
    public class Data_Impl: DataUseCases
    {
        public async Task<List<Weather>> getData(string tokenKey)
        {
            string data;
            var baseAddress = new Uri("https://localhost:7132");
            string url = "/WeatherForecast";

            using (var client = new HttpClient(new HttpClientHandler()) { BaseAddress = baseAddress })
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {tokenKey}");
                var result = await client.GetAsync(url);
                var bytes = await result.Content.ReadAsByteArrayAsync();

                Encoding encoding = Encoding.GetEncoding("utf-8");
                data = encoding.GetString(bytes, 0, bytes.Length);
                result.EnsureSuccessStatusCode();
            }
            var weather = JsonConvert.DeserializeObject<List<Weather>>(data);
            
            return weather;
        }
        public async Task<List<Products>> GetProduct(string tokenKey)
        {
            string data;
            var baseAddress = new Uri("https://localhost:7132");
            string url = "/api/Products";

            using (var client = new HttpClient(new HttpClientHandler()) { BaseAddress = baseAddress })
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {tokenKey}");
                var result = await client.GetAsync(url);
                var bytes = await result.Content.ReadAsByteArrayAsync();

                Encoding encoding = Encoding.GetEncoding("utf-8");
                data = encoding.GetString(bytes, 0, bytes.Length);
                result.EnsureSuccessStatusCode();
            }
            
            var products = JsonConvert.DeserializeObject<List<Products>>(data);
            return products;
        }

        public async Task<string> CreateOrder(int userId, string date)
        {
            string data;
            var baseAddress = new Uri("https://localhost:7132");
            string url = "/api/Orders";
            string message = "";

            var content = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("userId",  userId.ToString()),
                new KeyValuePair<string, string>("date", date),
            });

            using (var client = new HttpClient { BaseAddress = baseAddress })
            {
                var result = await client.PostAsync(url, content);
                var bytes = await result.Content.ReadAsByteArrayAsync();

                Encoding encoding = Encoding.GetEncoding("utf-8");
                data = encoding.GetString(bytes, 0, bytes.Length);
                result.EnsureSuccessStatusCode();
                if (result.IsSuccessStatusCode)
                {
                    message = result.StatusCode.ToString();
                }
                
            }
            return message;
        }

        /*public Task<string> AddItems(OrderItems items)
        {
            string data;
            var baseAddress = new Uri("https://localhost:7132");
            string url = "/api/OrderItems";
            string message = "";

            var content = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("UserId",  userID.ToString()),
                new KeyValuePair<string, string>("Date", date),
            });

            using (var client = new HttpClient { BaseAddress = baseAddress })
            {
                var result = await client.PostAsync(url, content);
                var bytes = await result.Content.ReadAsByteArrayAsync();

                Encoding encoding = Encoding.GetEncoding("utf-8");
                data = encoding.GetString(bytes, 0, bytes.Length);
                result.EnsureSuccessStatusCode();
                if (result.IsSuccessStatusCode)
                {
                    message = result.StatusCode.ToString();
                }

            }
            var order = JsonConvert.DeserializeObject<Order>(data);

            return order.Id.ToString();
        }*/
        /*public async Task<string> OrderItems(List<Products> products)
{
   var items = new OrderItems
   {
       OrderId = products,
   };

   string data;
   var baseAddress = new Uri("https://localhost:7132");
   string url = "/api/Orders";
   string message = "";

   var content = new FormUrlEncodedContent(new[]
   {
       new KeyValuePair<string, string>("UserId",  userID.ToString()),
       new KeyValuePair<string, string>("Date", date.ToString()),
   });

   using (var client = new HttpClient { BaseAddress = baseAddress })
   {
       var result = await client.PostAsync(url, content);
       var bytes = await result.Content.ReadAsByteArrayAsync();

       Encoding encoding = Encoding.GetEncoding("utf-8");
       data = encoding.GetString(bytes, 0, bytes.Length);
       result.EnsureSuccessStatusCode();
       if (result.IsSuccessStatusCode)
       {
           message = result.StatusCode.ToString();
       }
   }
   return message;
}*/
    }
}
