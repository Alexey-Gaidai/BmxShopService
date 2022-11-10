using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Data
{
    public class SignIn_Impl
    {
        public async Task<string> SignIn(string Name, string Lastname, string Email, string Phone, string Address, string Password)
        {
            string data;
            var baseAddress = new Uri("https://localhost:7132");
            string url = "/signin";
            string message = "";

            var content = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("name", Name),
                new KeyValuePair<string, string>("lastname", Lastname),
                new KeyValuePair<string, string>("email", Email),
                new KeyValuePair<string, string>("phone", Phone),
                new KeyValuePair<string, string>("address", Address),
                new KeyValuePair<string, string>("password", Password),
                new KeyValuePair<string, string>("role", "user")
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
    }
}
