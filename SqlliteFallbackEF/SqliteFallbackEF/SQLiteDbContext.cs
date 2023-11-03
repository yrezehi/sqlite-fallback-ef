using Microsoft.EntityFrameworkCore;

namespace SqliteFallbackEF
{
    public class SQLiteDbContext : DbContext
    {
        public SQLiteDbContext(DbContextOptions<SQLiteDbContext> options) : base(options) { }
    }
}
