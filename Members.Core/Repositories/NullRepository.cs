using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Members.Core.Data;
using System.Linq.Expressions;

namespace Members.Core.Repositories
{
    public class NullRepository<T> : IRepository<T> where T : Item
    {
        public static NullRepository<T> Instance { get; } = new NullRepository<T>();

        private NullRepository()
        {
        }

        public T? Create( params object?[ ]? args )
        {
            return null;
        }

        public IQueryable<T> GetAll()
        {
            return Enumerable.Empty<T>().AsQueryable();
        }

        public void Insert( T item )
        {
        }

        public void Update( T item )
        {
        }

        public void Delete( T item )
        {
        }

        public void Ensure<TProperty>( T entity, Expression<Func<T, TProperty>> expression ) where TProperty : class
        {
        }

        public void Ensure<TProperty>( T entity, Expression<Func<T, IEnumerable<TProperty>>> expression ) where TProperty : class
        {
        }

        public void Ensure<TProperty>( T entity, Expression<Func<T, ICollection<TProperty>>> expression ) where TProperty : class
        {
        }
    }
}
