﻿using Microsoft.EntityFrameworkCore;
using Members.Core.Data;

namespace Members.Shared.Data
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Item
    {
        public Repository( IFactory factory, DbContext context )
        {
            Factory = factory;
            Context = context;
        }

        protected IFactory  Factory { get; set; }
        protected DbContext Context { get; set; }

        public IEnumerable<TEntity> GetAll()
        {
            return Context.Set<TEntity>();
        }

        public TEntity? Get( int id ) 
        {
            return Context.Set<TEntity>()?.FirstOrDefault( x => x.Id == id );
        }

        public TEntity? Create( params object?[]? args )
        {
            return Factory.Create<TEntity>( args );
        }

        public void Insert(TEntity item)
        {
            Context.Set<TEntity>().Add(item);
        }

        public void Update(TEntity item)
        {
            Context.Entry(item).State = EntityState.Modified;
        }

        public void Delete(TEntity item)
        {
            Context.Remove(item);
        }

    }
}