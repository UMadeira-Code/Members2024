﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

using Members.Core.Data;
using Members.Core.Repositories;

namespace Members.Shared.Data
{
    public class UnitOfWorkAsync : UnitOfWork, IUnitOfWorkAsync
    {
        public UnitOfWorkAsync(MembersContext context, IFactory factory)
            : base(context, factory)
        {
        }

        public IRepositoryAsync<TEntity>? GetRepositoryAsync<TEntity>() where TEntity : Item
        {
            return GetRepository<TEntity>() as IRepositoryAsync<TEntity>;
        }

        public async Task SaveChangesAsync()
        {
            await Context.SaveChangesAsync();
        }

        protected override IRepository<TEntity>? CreateRepository<TEntity>()
        {
            return new RepositoryAsync<TEntity>( Factory, Context);
        }

    }
}
