using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace FarmManager.Server.Data
{
    public class SqliteFarmManagerContext : FarmManagerContext
    {
        public SqliteFarmManagerContext(DbContextOptions options, IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite("FileName=FarmManagerSqliteDB.db");
    }
}
