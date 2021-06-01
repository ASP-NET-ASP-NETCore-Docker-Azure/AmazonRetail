using System;
using AmazonWeb.Core.Repositories.Base;
using AmazonWeb.Core.Entities;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;

namespace AmazonWeb.Core.Repositories
{
    public interface IProductRepository: IRepository<Product>
    {
        IEnumerable<Product> GetAll();
        IEnumerable<Product> Search(string searchTerm);
        Product Get(int id);
        Product Add(Product item);
        void Remove(int id);
        void Update(Product item);

        /*        Task<IEnumerable<Product>> GetProductListAsync();
                Task<Product> GetProductBySlug(string slug);
                Task<IEnumerable<Product>> GetProductNameAsync(string productName);
                Task<IEnumerable<Product>> GetProductByIdWithCategoryAsync(int productId);
                Task<IEnumerable<Product>> GetProductByCategoryAsync(int categoryId);*/
    }
}
