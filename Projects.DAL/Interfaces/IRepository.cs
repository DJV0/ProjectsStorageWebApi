using Projects.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Projects.DAL.Interfaces
{
    interface IRepository<T> where T : TEntity
    {
        IEnumerable<T> Get(Expression<Func<T, bool>> filter = null);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Delete(int id);
    }
}
