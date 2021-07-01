using Projects.DAL.Interfaces;
using Projects.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Projects.DAL.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : TEntity
    {
        protected readonly IList<T> _context;
        public GenericRepository(IList<T> context)
        {
            _context = context;
        }
        public IEnumerable<T> Get(Expression<Func<T, bool>> filter = null)
        {
            IQueryable<T> query = _context.AsQueryable();
            if(filter != null)
            {
                query = query.Where(filter);
            }

            return query.ToList();
        }

        public void Create(T entity)
        {
            _context.Add(entity);
        }
        public void Update(T entityUpdate)
        {
            T entity = _context.FirstOrDefault(e => e.Id == entityUpdate.Id);
            if (entity != null)
            {
                int index = _context.IndexOf(entity);
                _context[index] = entityUpdate;
            }
        }

        public void Delete(T entity)
        {
            _context.Remove(entity);
        }

        public void Delete(int id)
        {
            var team = _context.FirstOrDefault(e => e.Id == id);
            if (team != null)
            {
                _context.Remove(team);
            }
        }


    }
}
