﻿using Microsoft.EntityFrameworkCore;

namespace SqliteFallbackEF.Sample.Repositories.Abstracts.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<TEntity> Repository<TEntity>() where TEntity : class;

        Task<int> CompletedAsync();
        Task DisposeAsync();
    }

    public interface IUnitOfWork<TContext> : IUnitOfWork where TContext : DbContext
    {
        TContext Context { get; }
    }
}
