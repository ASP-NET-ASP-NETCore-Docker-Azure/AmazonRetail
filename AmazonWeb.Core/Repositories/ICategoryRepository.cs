using AmazonWeb.Core.Entities;
using AmazonWeb.Core.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AmazonWeb.Core.Repositories
{
    public interface ICategoryRepository: IRepository<Category>
    {
        IEnumerable<Category> GetAll();
        Category Get(int id);
        Category Add(Category item);
        void Remove(int id);
        bool Update(Category item);

        /*Task<Category> GetCategoryWithProductsAsync(int categoryId);*/
    }
}
