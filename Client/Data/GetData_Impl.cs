using Client.Data.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BmxShopClient.Data
{
    public class GetData_Impl
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
    }
}
