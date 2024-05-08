using System.Linq.Expressions;
using Members.Core.Data;

namespace Members.Core.Repositories
{
    public sealed class NullRepositoryAsync<TEntity> : IRepositoryAsync<TEntity> where TEntity : Item
    {
        public static NullRepositoryAsync<TEntity> Instance { get; } = new NullRepositoryAsync<TEntity>();

        private NullRepositoryAsync() { }

        public TEntity? Get( int id )
        {
            return null;
        }

        public TEntity? Create( params object?[]? args )
        {
            return null;
        }

        public IQueryable<TEntity> GetAll()
        {
            return Enumerable.Empty<TEntity>().AsQueryable();
        }

        public async Task<TEntity?> GetAsync( int id )
        { 
            return await Task.FromResult( (TEntity?) null );
        }

        public Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return Task.FromResult( Enumerable.Empty<TEntity>() );
        }

        public void Insert( TEntity item )
        {
        }

        public Task InsertAsync( TEntity item )
        {
            return Task.FromResult(0);
        }

        public void Update( TEntity item )
        {
        }

        public void Delete( TEntity item )
        {
        }

        public void Ensure<TProperty>( TEntity entity, Expression<Func<TEntity, TProperty?>> expression ) where TProperty : class
        {
        }

        public void Ensure<TProperty>( TEntity entity, Expression<Func<TEntity, IEnumerable<TProperty>>> expression ) where TProperty : class
        {
        }

        public void Ensure<TProperty>( TEntity entity, Expression<Func<TEntity, ICollection<TProperty>>> expression ) where TProperty : class
        {
        }
    }
}
