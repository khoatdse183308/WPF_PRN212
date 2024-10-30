using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_DAOs
{
    public class GenericDAO<T> where T : class
    {
        private readonly DbContext _context;
        private readonly DbSet<T> _dbSet;

        public GenericDAO(DbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

 

        public List<T> GetAll()
        {
            return _dbSet.ToList();
        }
        public T GetById(string id)
        {
            return _dbSet.Find(id);
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }
        public bool Update(T entity)
        {
            try
            {
                _context.Entry(entity).State = EntityState.Modified;
                bool isSuccess = _context.SaveChanges() > 0;
                _context.Entry(entity).State = EntityState.Detached;
                return isSuccess;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public void Delete(string id)
        {
            var entity = GetById(id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
                _context.SaveChanges();
            }
        }
    }
}
