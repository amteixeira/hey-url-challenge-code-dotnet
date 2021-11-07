using HeyUrlChallengeCodeDotnet.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hey_url_challenge_code_dotnet.Repository
{
    public class UrlRepository<T> : IUrlRepository<T> where T : class
    {
        private readonly ApplicationContext context = null;
        private readonly DbSet<T> set;

        public UrlRepository(ApplicationContext context)
        {
            this.context = context;
            set = context.Set<T>();
        }

        public void Add(T entity)
        {
            set.Add(entity);
        }

        public void AddAsync(T entity)
        {
            set.AddAsync(entity);
        }

        public void Delete(T entity)
        {
            set.Remove(entity);
        }

        public T Get(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return set.FirstOrDefault(predicate);
        }

        public IQueryable<T> GetAll()
        {
            return set;
        }

        public void Update(T entity)
        {
            set.Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
        }
    }
}
