using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace hey_url_challenge_code_dotnet.Repository
{
    public interface IUrlRepository<T> where T : class
    {
        void Add(T entity);
        void AddAsync(T entity);
        void Delete(T entity);
        T Get(Expression<Func<T, bool>> predicate);
        IQueryable<T> GetAll();
        void Update(T entity);
    }
}
