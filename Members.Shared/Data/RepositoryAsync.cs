using Microsoft.EntityFrameworkCore;

using Members.Core.Data;
using Members.Core.Repositories;

namespace Members.Shared.Data
{
    public class RepositoryAsync<TEntity> : Repository<TEntity>, IRepositoryAsync<TEntity> where TEntity : Item
    {
        public RepositoryAsync( IFactory factory, DbContext context)
            : base( factory, context) { }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await Context.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity?> GetAsync(int id)
        {
            return await Context.Set<TEntity>().FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task InsertAsync(TEntity item)
        {
            await Context.Set<TEntity>().AddAsync(item);
        }
    }
}
