using AmazonWeb.Core.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AmazonWeb.Core.Entities;

namespace AmazonWeb.Core.Repositories
{
    public interface IOrderRepository : IRepository<Order>
    {
        IEnumerable<Order> GetAll();
        Order Get(int id);
        Order Add(Product item);
        void Remove(int id);
        bool Update(Order item);

        /* Task<IEnumerable<Order>> GetOrderByUserNameAsync(string userName); */
    }
}
