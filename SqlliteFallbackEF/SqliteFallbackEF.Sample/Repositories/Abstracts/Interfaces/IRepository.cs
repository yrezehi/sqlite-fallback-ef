using Microsoft.EntityFrameworkCore;

namespace SqliteFallbackEF.Sample.Repositories.Abstracts.Interfaces
{
    public interface IRepository<T> : IDisposable where T : class
    {
        public DbSet<T> DBSet { get; }
    }
}
