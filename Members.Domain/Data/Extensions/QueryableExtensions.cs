using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace Members.Domain.Data.Extensions
{
    public static class QueryableExtensions
    {
        public static IQueryable<TEntity> Ensure<TEntity, TProperty>(
            this IQueryable<TEntity> queryable, Expression<Func<TEntity, TProperty>> property ) where TEntity : class
        {
            return queryable.Include( property );
        }
    }
}
