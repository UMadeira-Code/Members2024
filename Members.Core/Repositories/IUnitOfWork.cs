using Members.Core.Data;

namespace Members.Core.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<TEntity> GetRepository<TEntity>() where TEntity : Item;

        void Begin();
        void Commit();
        void Rollback();

        void SaveChanges();
    }
}
