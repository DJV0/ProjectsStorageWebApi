using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.BLL.Interfaces
{
    public interface IService<T> where T: DAL.Entities.TEntity
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> Get(int id);
        Task Add(T entity);
        Task Update(T entity);
        Task Delete(T entity);
        Task Delete(int id);
    }
}
