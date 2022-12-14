using Client.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.UseCases
{
    public interface DataUseCases
    {
        public Task<string> SaveAccountInfo(string tokenKey, User user);
        public Task<User> LoadAccountInfo(string tokenKey, int id);
        public Task<T> GetSupplies<T>(string tokenKey);
        public Task<string> UpdateSupplies(string tokenKey, Supplies sup);
        public Task<List<Products>> GetProduct(string tokenKey);
        public Task<string> CreateOrder(int userId, DateTime date, bool status, string tokenKey);
        public Task<string> UpdateOrder(string tokenKey, Order ord);
        public Task<List<Order>> GetOrders(string tokenKey, string parameter);
        public Task<T> GetProduct<T>(string tokenKey, string parameter);
        public Task<List<OrderItems>> GetOrderItems(string tokenKey, string parameter);
        public Task<string> AddOrderItems(string tokenKey, OrderItems[] orderItems);
        public Task<string> DeleteOrder(string tokenKey, int userID);
    }
}
