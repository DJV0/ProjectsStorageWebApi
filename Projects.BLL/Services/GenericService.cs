using Projects.BLL.Interfaces;
using Projects.DAL.Interfaces;
using Projects.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.BLL.Services
{
    public class GenericService<T> : IService<T> where T : TEntity
    {
        protected IRepository<T> _context;
        public GenericService(IRepository<T> context)
        {
            _context = context;
        }
        public void Add(T entity)
        {
            _context.Create(entity);
        }

        public void Delete(T entity)
        {
            _context.Delete(entity);
        }

        public void Delete(int id)
        {
            _context.Delete(id);
        }

        public T Get(int id)
        {
            return _context.Get(e => e.Id == id).FirstOrDefault();
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Get();
        }

        public void Update(T entity)
        {
            _context.Update(entity);
        }
    }
}
