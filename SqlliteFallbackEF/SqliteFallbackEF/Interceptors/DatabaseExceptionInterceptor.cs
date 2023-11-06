using Microsoft.EntityFrameworkCore.Diagnostics;
using System.Data.Common;

namespace SqliteFallbackEF.Interceptors
{
    public class DatabaseExceptionInterceptor : DbCommandInterceptor
    {
        public override void CommandFailed(DbCommand command, CommandErrorEventData eventData)
        {

        }
    }
}
