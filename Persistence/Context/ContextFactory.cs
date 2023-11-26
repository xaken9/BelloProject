using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Persistence.Context;
using System.IO;

namespace Persistence
{
    public class ContextFactory : IDesignTimeDbContextFactory<ApplicationDBContext>
    {
        public ApplicationDBContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                            .SetBasePath(Directory.GetCurrentDirectory())
                            .AddJsonFile("appsettings.json")
                            .Build();

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDBContext>().UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);

            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                             x => x.MigrationsHistoryTable("_EFMigrationsHistory"));

            return new ApplicationDBContext(optionsBuilder.Options);
        }
    }
}
