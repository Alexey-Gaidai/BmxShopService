using BmxShopClient.Data.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmxShopClient.Data
{
    public class Login_impl
    {
        public string tokenKey = "accessToken";
        AuthInfo authInfo;
        public async Task<AuthInfo> SendRequest(string login, string password)
        {
            string data;
            var baseAddress = new Uri("https://localhost:7132");
            string url = "/token";

            var content = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("username", login),
                new KeyValuePair<string, string>("password", password),
            });

            using (var client = new HttpClient { BaseAddress = baseAddress })
            {
                var result = await client.PostAsync(url, content);
                var bytes = await result.Content.ReadAsByteArrayAsync();

                Encoding encoding = Encoding.GetEncoding("utf-8");
                data = encoding.GetString(bytes, 0, bytes.Length);
                result.EnsureSuccessStatusCode();
            }

            authInfo = JsonConvert.DeserializeObject<AuthInfo>(data);
            Console.WriteLine(authInfo.access_token);
            return authInfo;
        }
    }
}
