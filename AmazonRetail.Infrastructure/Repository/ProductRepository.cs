using AmazonRetail.Infrastructure.Data;
using AmazonWeb.Core.Entities;
using AmazonWeb.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AmazonRetail.Infrastructure.NewFolder
{
    public class ProductRepository : IProductRepository
    {
        AmazonWebContext _context;

        public ProductRepository(AmazonWebContext context)
        {
            _context = context;
            context.Database.EnsureCreated();
            if (context.Products.Any())
            {
                return;
            }
            Add(new Product()
            {
                Name = "Adidas_Rangers",
                Star = 3,
                UnitPrice = 4200,
                UnitsInStock = 10,
                Description = "Available Size(9)",
                Summary = "Get Set Go",
                ImageFile = "shoes-img6.png",
            });
            Add(new Product()
            {
                Name = "Bata_Rangers",
                Star = 4,
                UnitPrice = 1500,
                UnitsInStock = 60,
                Description = "Available Size(6,7,8,9)",
                Summary = "For the Legends",
                ImageFile = "shoes-img7.png",
            });
            Add(new Product()
            {
                Name = "Reebok_treak",
                Star = 5,
                UnitPrice = 12000,
                UnitsInStock = 20,
                Description = "Available Size(8)",
                Summary = "Set the standard",
                ImageFile = "shoes-img8.png",
            });
            Add(new Product()
            {
                Name = "Puma_Blues",
                Star = 4,
                UnitPrice = 3500,
                UnitsInStock = 20,
                Description = "Available Size(5,6,7,8,9)",
                Summary = "For the Blues",
                ImageFile = "shoes-img9.png",
            });
        }
        public Product Add(Product item)
        {
            _context.Products.Add(item);
            _context.SaveChanges();
            return item;
        }

        public Product Get(int id)
        {
            return _context.Products.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Product> GetAll()
        {
            return _context.Products;
        }

        public IEnumerable<Product> Search(string searchTerm)
        {
            if (string.IsNullOrEmpty(searchTerm))
            {
                return _context.Products;
            }
            return _context.Products.Where(e => e.Name.Contains(searchTerm));
            
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product item)
        {
            
        }
    }
}
