using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace WoWClassicTalentCalculator.DataAccess.Repositories
{
    public class BaseRepository<T, Repository>
        where T : class
        where Repository : class
    {
        public TalentCalculatorContext Context { get; private set; }
        protected Repository CurrentRepository { get; set; }
        public IQueryable<T> Query { get; protected set; }

        public BaseRepository(DbContext context)
        {
            Context = (TalentCalculatorContext)context;
        }

        public virtual T Add(T entity)
        {
            Context.Set<T>().Add(entity);
            Context.SaveChanges();

            return entity;
        }

        public virtual T GetById(int id)
        {
            return Context.Set<T>().Find(id);
        }

        public virtual Repository All()
        {
            Query = Context.Set<T>();

            return CurrentRepository;
        }

        public virtual void Update()
        {
            Context.SaveChanges();
        }

        public virtual IEnumerable<T> Results()
        {
            return Query.AsEnumerable();
        }
    }
}
