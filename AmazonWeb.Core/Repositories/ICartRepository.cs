using AmazonWeb.Core.Entities;
using AmazonWeb.Core.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AmazonWeb.Core.Repositories
{
    public interface ICartRepository:IRepository<CartItem>
    {
        IEnumerable<CartItem> GetAll();
        CartItem Get(int id);
        void Add(CartItem item);
        void Remove(int id);

        /*Task<Cart> GetByUserNameAsync(string username);*/
    }
}
