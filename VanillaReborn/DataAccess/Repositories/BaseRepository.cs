using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace VanillaReborn.DataAccess.Repositories
{
    public class BaseRepository<T, Repository>
        where T : class
        where Repository : class
    {
        public VanillaRebornContext Context { get; private set; }
        protected Repository CurrentRepository { get; set; }
        public IQueryable<T> Query { get; protected set; }

        public BaseRepository(DbContext context)
        {
            Context = (VanillaRebornContext)context;
        }

        public virtual Repository EagerLoad()
        {
            return CurrentRepository;
        }

        public virtual T Add(T entity)
        {
            Context.Set<T>().Add(entity);
            Context.SaveChanges();

            return entity;
        }

        public virtual Task<int> CountAsync()
        {
            return Context.Set<T>().CountAsync();
        }

        public virtual T GetById(int id)
        {
            return Context.Set<T>().Find(id);
        }

        public virtual Task<T> GetByIdAsync(int id)
        {
            return Context.Set<T>().FindAsync(id);
        }

        public virtual Repository All()
        {
            Query = Context.Set<T>();

            return CurrentRepository;
        }
        public virtual Repository For(Expression<Func<T, bool>> filter)
        {
            Query = Query.Where(filter);

            return CurrentRepository;
        }

        public virtual IEnumerable<T> Results()
        {
            return Query.AsEnumerable();
        }

        public virtual Task<IEnumerable<T>> ResultsAsync()
        {
            return Task.FromResult(Query.AsEnumerable());
        }

        public virtual List<T> ResultsAsList()
        {
            return Query.ToList();
        }

        public virtual Task<List<T>> ResultsAsListAsync()
        {
            return Query.ToListAsync();
        }

        public virtual T FirstResult()
        {
            return Query.FirstOrDefault();
        }

        public virtual IEnumerable<TSelector> SelectResults<TSelector>(Func<T, TSelector> selector)
        {
            return Query.AsEnumerable().Select(selector);
        }

        public virtual List<TSelector> SelectResultsAsList<TSelector>(Func<T, TSelector> selector)
        {
            return Query.Select(selector).ToList();
        }

        public virtual void Update()
        {
            Context.SaveChanges();
        }
    }
}
