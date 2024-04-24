using Members.Core.Data;

namespace Members.Core.Repositories
{
    public interface IUnitOfWorkAsync : IUnitOfWork
    {
        IRepositoryAsync<TEntity> GetRepositoryAsync<TEntity>() where TEntity : Item;

        Task SaveChangesAsync();
    }
}
