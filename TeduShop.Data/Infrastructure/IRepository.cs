using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Data.Infrastructure
{
    public interface IRepository<T> where T : class
    {
        //mark an emty as new
        void Add(T entity);

    }
}
