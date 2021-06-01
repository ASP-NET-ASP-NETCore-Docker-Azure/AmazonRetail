using AmazonWeb.Core.Entities;
using AmazonWeb.Core.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonWeb.Core.Repositories
{
    public interface IWishlistRepository:IRepository<Wishlist>
    {
        IEnumerable<Wishlist> GetAll();
        Wishlist Get(int id);
        Wishlist Add(Wishlist item);
        void Remove(int id);
        bool Update(Wishlist item);
    }
}
