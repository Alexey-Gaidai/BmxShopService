using Client.Data.Models;
using Client.UseCases;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Client.Data.Service
{
    public class UserCases_Impl: UserUseCases
    {
        public string tokenKey;
        AuthInfo authInfo;
        public async Task<(AuthInfo, string)> LogIn(string login, string password)
        {
            string data;
            var baseAddress = new Uri("https://localhost:7132");
            string url = "/token";
            string message = "";

            var content = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("username", login),
                new KeyValuePair<string, string>("password", password),
            });
            try
            {
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
                return (authInfo, message);
            } catch
            {
                return (default, message);
            }

        }
        public async Task<string> SignUp(string Name, string Lastname, string Email, string Phone, string Address, string Password)
        {
            string data;
            var baseAddress = new Uri("https://localhost:7132");
            string url = "/signup";
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

            try
            {
                using (var client = new HttpClient { BaseAddress = baseAddress })
                {
                    var result = await client.PostAsync(url, content);
                    var bytes = await result.Content.ReadAsByteArrayAsync();

                    Encoding encoding = Encoding.GetEncoding("utf-8");
                    data = encoding.GetString(bytes, 0, bytes.Length);
                    message = result.StatusCode.ToString();
                    result.EnsureSuccessStatusCode();
                }
                return message;
            }
            catch
            {
                return message;
            }
            
        }
    }
}
