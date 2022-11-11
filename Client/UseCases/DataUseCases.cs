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
        public Task<List<Products>> GetProduct(string tokenKey);
        public Task<string> CreateOrder(int userID, string date);
        //public Task<string> AddItems(OrderItems items);
    }
}
