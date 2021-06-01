using AmazonRetail.Infrastructure.Data;
using AmazonRetail.Infrastructure.NewFolder;
using AmazonWeb.Core.Entities;
using AmazonWeb.Core.Repositories;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonRetail.Infrastructure.Repository
{
    public class CartRepository : ICartRepository
    {
        AmazonWebContext _context;
        public CartRepository(AmazonWebContext context)
        {
            _context = context;
        }
        public void Add(CartItem item)
        {
            _context.CartItems.Add(item);
            _context.SaveChanges();
        }

        public CartItem Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CartItem> GetAll()
        {
            return _context.CartItems;
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
