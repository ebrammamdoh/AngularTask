using ApiTask.Models.mongoModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Web;

namespace ApiTask.Models.BL
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly DbContext _context;
        protected readonly MongoDbEntities _mongodb;
        public Repository(DbContext context, MongoDbEntities mongodb)
        {
            _context = context;
            _mongodb = mongodb;
        }
        public async Task<IEnumerable<T>> Add(T entity)
        {
            _context.Set<T>().Add(entity);
            await _mongodb.Add(new Logs() { Action = "Add new" });
            return GetAll();
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().Where(predicate);
        }

        public T Get(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public async Task<IEnumerable<T>> Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
            await _mongodb.Add(new Logs() { Action = "Delete customer " + entity });
            return GetAll();
        }
    }
}