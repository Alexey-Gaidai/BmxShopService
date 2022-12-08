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
        public Task<T> GetSupplies<T>(string tokenKey);
        public Task<string> UpdateSupplies(string tokenKey, Supplies sup);
        public Task<List<Products>> GetProduct(string tokenKey);
        public Task<string> CreateOrder(int userID, string date);
        public Task<List<Order>> GetOrders(string tokenKey, string parameter);
        public Task<T> GetProduct<T>(string tokenKey, string parameter);
        public Task<List<OrderItems>> GetOrderItems(string tokenKey, string parameter);
        public Task<string> AddOrderItems(OrderItems[] orderItems);
        public Task<string> DeleteOrder(int userID);
        //public Task<string> AddItems(OrderItems items);
    }
}
