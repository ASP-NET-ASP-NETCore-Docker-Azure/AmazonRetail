using AmazonWeb.Core.Entities;
using AmazonWeb.Core.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AmazonWeb.Core.Repositories
{
    public interface ICompareRepository: IRepository<Compare>
    {
        IEnumerable<Compare> GetAll();
        Compare Get(int id);
        Compare Add(Compare item);
        void Remove(int id);
        bool Update(Compare item);

        /*Task<Compare> GetByUserNameAsync(string userName);*/
    }
}
