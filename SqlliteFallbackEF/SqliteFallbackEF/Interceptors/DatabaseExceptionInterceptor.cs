using Microsoft.EntityFrameworkCore.Diagnostics;
using System.Data.Common;

namespace SqliteFallbackEF.Interceptors
{
    public class DatabaseExceptionInterceptor : DbCommandInterceptor
    {
        public override async Task<InterceptionResult<DbDataReader>> ReaderExecutingAsync(DbCommand command, CommandEventData eventData, InterceptionResult<DbDataReader> result, CancellationToken cancellationToken = default)
        {
            try
            {
                return await base.ReaderExecutingAsync(command, eventData, result, cancellationToken);
            }
            catch (Exception ex)
            {
                
                return result;
            }
        }
    }
}
