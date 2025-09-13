using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.GenericRepository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        private readonly RentACarContext _context;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(RentACarContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public List<T> GetListAll()
        {
            return _dbSet.ToList();
        }

        public T Insert(T t)
        {
            _dbSet.Add(t);
            _context.SaveChanges();
            return t;
        }

        public T Remove(T t)
        {
            _dbSet.Remove(t);
            _context.SaveChanges ();
            return t;
        }

        public T Update(T t)
        {
            _dbSet.Update(t);
            _context.SaveChanges();
            return t;
        }
    }
}
