using Members.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Members.Core.Repositories
{
    public class NullUnitOfWork : IUnitOfWork
    {
        public static NullUnitOfWork Instance { get; } = new NullUnitOfWork();

        private NullUnitOfWork()
        {
        }

        public IRepository<TEntity> GetRepository<TEntity>() where TEntity : Item
        {
            return NullRepository<TEntity>.Instance;
        }

        public void Begin()
        {
        }

        public void Commit()
        {
        }

        public void Dispose()
        {
        }

        public void Rollback()
        {
        }

        public void SaveChanges()
        {
        }
    }
}
