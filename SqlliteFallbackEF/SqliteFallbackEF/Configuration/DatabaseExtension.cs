using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SqliteFallbackEF.Interceptors;

namespace SqliteFallbackEF.Configuration
{
    public static class DatabaseExtension
    {
        private static string DEFAULT_SQLITE_LOCATION = "C:\\default_sqlite";

        public static void RegisterFallback(this WebApplicationBuilder builder) =>
            builder.Services.AddDbContext<SQLiteDbContext>(options => options.UseSqlite(DEFAULT_SQLITE_LOCATION));

        public static void SQLiteInterceptors(this DbContextOptionsBuilder builder) =>
            builder.AddInterceptors(new SQLiteExceptionInterceptor()); 
    }
}
