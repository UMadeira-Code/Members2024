using Members.Core.Data;

namespace Members.Core.Repositories
{
    public interface IRepositoryAsync<TEntity> : IRepository<TEntity> where TEntity : Item
    {
        Task<TEntity?>             GetAsync( int id );
        Task<IEnumerable<TEntity>> GetAllAsync();

        Task InsertAsync(TEntity item);
    }
}
