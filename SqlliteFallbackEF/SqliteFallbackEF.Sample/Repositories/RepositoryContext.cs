using Microsoft.EntityFrameworkCore;

namespace SqliteFallbackEF.Sample.Repositories
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options) { }
    }
}