using Client.Data.Models;
using Client.Present;
using Client.UseCases;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;


namespace Client.Data.Service
{
    public class Data_Impl : DataUseCases
    {
        public async Task<string> AddProduct(string tokenKey, Products product)
        {
            string data;
            var baseAddress = new Uri("https://localhost:7132");
            string url = $"api/Products";
            string message = "";
            try
            {
                using (var client = new HttpClient(new HttpClientHandler()) { BaseAddress = baseAddress })
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {tokenKey}");
                    var result = await client.PostAsJsonAsync(url, product);
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
        public async Task<string> UpdateProducts(string tokenKey, Products product)
        {
            string data;
            var baseAddress = new Uri("https://localhost:7132");
            string url = $"api/Products/{product.Id}";
            string message = "";
            try
            {
                using (var client = new HttpClient(new HttpClientHandler()) { BaseAddress = baseAddress })
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {tokenKey}");
                    var result = await client.PutAsJsonAsync(url, product);
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
        public async Task<string> SaveAccountInfo(string tokenKey, User user)
        {
            string data;
            var baseAddress = new Uri("https://localhost:7132");
            string url = $"api/User/{user.Id}";
            string message = "";
            try
            {
                using (var client = new HttpClient(new HttpClientHandler()) { BaseAddress = baseAddress })
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {tokenKey}");
                    var result = await client.PutAsJsonAsync(url, user);
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
        public async Task<(User, string)> LoadAccountInfo(string tokenKey, int id)
        {
            string data;
            var baseAddress = new Uri("https://localhost:7132");
            string url = $"api/User/{id}";
            string message = "";
            try
            {
                using (var client = new HttpClient(new HttpClientHandler()) { BaseAddress = baseAddress })
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {tokenKey}");
                    var result = await client.GetAsync(url);
                    var bytes = await result.Content.ReadAsByteArrayAsync();
                    Encoding encoding = Encoding.GetEncoding("utf-8");
                    data = encoding.GetString(bytes, 0, bytes.Length);
                    message = result.StatusCode.ToString();
                    result.EnsureSuccessStatusCode();
                }
                var user = JsonConvert.DeserializeObject<User>(data);
                return (user, message);
            }
            catch
            {
                return (default, message);
            }
        }
        public async Task<(T, string)> GetProduct<T>(string tokenKey, string parameter)
        {
            string data;
            var baseAddress = new Uri("https://localhost:7132");
            string url = $"/api/Products/{parameter}";
            string message = "";
            try
            {
                using (var client = new HttpClient(new HttpClientHandler()) { BaseAddress = baseAddress })
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {tokenKey}");
                    var result = await client.GetAsync(url);
                    var bytes = await result.Content.ReadAsByteArrayAsync();
                    Encoding encoding = Encoding.GetEncoding("utf-8");
                    data = encoding.GetString(bytes, 0, bytes.Length);
                    message = result.StatusCode.ToString();
                    result.EnsureSuccessStatusCode();
                }
                var products = JsonConvert.DeserializeObject<T>(data);
                return (products, message);
            } 
            catch
            {
                return (default, message);
            }
            
        }
        public async Task<(List<Order>, string)> GetOrders(string tokenKey, string parameter)
        {
            string data;
            var baseAddress = new Uri("https://localhost:7132");
            string url = $"/api/Orders?userId={parameter}";
            string message = "";
            try
            {
                using (var client = new HttpClient(new HttpClientHandler()) { BaseAddress = baseAddress })
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {tokenKey}");
                    var result = await client.GetAsync(url);
                    var bytes = await result.Content.ReadAsByteArrayAsync();
                    Encoding encoding = Encoding.GetEncoding("utf-8");
                    data = encoding.GetString(bytes, 0, bytes.Length);
                    message = result.StatusCode.ToString();
                    result.EnsureSuccessStatusCode();
                }
                var orders = JsonConvert.DeserializeObject<List<Order>>(data);
                return (orders, message);
            }
            catch
            {
                return (default, message);
            }
            
        }

        public async Task<string> DeleteOrder(string tokenKey, int userId)
        {
            string data;
            var baseAddress = new Uri("https://localhost:7132");
            string url = $"/api/Orders/{userId}";
            string message = "";
            try
            {
                using (var client = new HttpClient { BaseAddress = baseAddress })
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {tokenKey}");
                    var result = await client.DeleteAsync(url);
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
            catch
            {
                return message;
            }
            
        }

        public async Task<(List<OrderItems>, string)> GetOrderItems(string tokenKey, string parameter)
        {
            string data;
            var baseAddress = new Uri("https://localhost:7132");
            string url = $"/api/OrderItems?orderId={parameter}";
            string message = "";
            try
            {
                using (var client = new HttpClient(new HttpClientHandler()) { BaseAddress = baseAddress })
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {tokenKey}");
                    var result = await client.GetAsync(url);
                    var bytes = await result.Content.ReadAsByteArrayAsync();

                    Encoding encoding = Encoding.GetEncoding("utf-8");
                    data = encoding.GetString(bytes, 0, bytes.Length);
                    message = result.StatusCode.ToString();
                    result.EnsureSuccessStatusCode();
                }

                var orderItems = JsonConvert.DeserializeObject<List<OrderItems>>(data);
                return (orderItems, message);
            }
            catch
            {
                return (default, message);
            }
        }

        public async Task<(string, string)> CreateOrder(int userId, DateTime date, bool status, string tokenKey)
        {
            string data;
            var baseAddress = new Uri("https://localhost:7132");
            string url = "/api/Orders";
            string message = "";

            try
            {
                var contentObj = new Order
                {
                    Id = 0,
                    UserId = userId,
                    purchaseDate = date.ToString(),
                    status = 0
                };
                var content = new StringContent(JsonConvert.SerializeObject(contentObj), Encoding.UTF8, "application/json");
                using (var client = new HttpClient { BaseAddress = baseAddress })
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {tokenKey}");

                    var result = await client.PostAsync(url, content);
                    var bytes = await result.Content.ReadAsByteArrayAsync();

                    Encoding encoding = Encoding.GetEncoding("utf-8");
                    data = encoding.GetString(bytes, 0, bytes.Length);
                    message = result.StatusCode.ToString();
                    result.EnsureSuccessStatusCode();
                }
                return (data,message);
            }
            catch
            {
                return (default,message);
            }
        }
        public async Task<string> AddOrderItems(string tokenKey, OrderItems[] orderItems)
        {
            string data;
            var baseAddress = new Uri("https://localhost:7132");
            string url = "/api/OrderItems";
            string message = "";
            try
            {
                using (var client = new HttpClient { BaseAddress = baseAddress })
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {tokenKey}");
                    var result = await client.PostAsJsonAsync(url, orderItems);
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
            catch
            {
                return message;
            }
        }

        public async Task<(T, string)> GetSupplies<T>(string tokenKey)
        {
            string data;
            var baseAddress = new Uri("https://localhost:7132");
            string url = $"/api/Supplies/";
            string message = "";
            try
            {
                using (var client = new HttpClient(new HttpClientHandler()) { BaseAddress = baseAddress })
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {tokenKey}");
                    var result = await client.GetAsync(url);
                    var bytes = await result.Content.ReadAsByteArrayAsync();
                    Encoding encoding = Encoding.GetEncoding("utf-8");
                    data = encoding.GetString(bytes, 0, bytes.Length);
                    message = result.StatusCode.ToString();
                    result.EnsureSuccessStatusCode();
                    
                }
                var supplies = JsonConvert.DeserializeObject<T>(data);
                return (supplies, message);
            }
            catch
            {
                return (default, message);
            }

        }

        public async Task<string> UpdateOrder(string tokenKey, Order ord)
        {
            string data;
            var baseAddress = new Uri("https://localhost:7132");
            string url = $"/api/Orders/{ord.Id}";
            string message = "";
            try
            {
                using (var client = new HttpClient(new HttpClientHandler()) { BaseAddress = baseAddress })
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {tokenKey}");
                    var result = await client.PutAsJsonAsync(url, ord);
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

        public async Task<string> UpdateSupplies(string tokenKey, Supplies sup)
        {
            string data;
            var baseAddress = new Uri("https://localhost:7132");
            string url = $"/api/Supplies/{sup.id}";
            string message = "";
            try
            {
                using (var client = new HttpClient(new HttpClientHandler()) { BaseAddress = baseAddress })
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {tokenKey}");
                    var result = await client.PutAsJsonAsync(url, sup);
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
        public async Task<string> AddSupply(string tokenKey, Supplies sup)
        {
            string data;
            var baseAddress = new Uri("https://localhost:7132");
            string url = $"/api/Supplies/";
            string message = "";
            try
            {
                using (var client = new HttpClient(new HttpClientHandler()) { BaseAddress = baseAddress })
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {tokenKey}");
                    var result = await client.PostAsJsonAsync(url, sup);
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
