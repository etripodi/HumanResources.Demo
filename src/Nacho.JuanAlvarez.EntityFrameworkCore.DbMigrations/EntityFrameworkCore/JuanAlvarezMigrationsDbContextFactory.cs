using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Nacho.JuanAlvarez.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class JuanAlvarezMigrationsDbContextFactory : IDesignTimeDbContextFactory<JuanAlvarezMigrationsDbContext>
    {
        public JuanAlvarezMigrationsDbContext CreateDbContext(string[] args)
        {
            JuanAlvarezEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<JuanAlvarezMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new JuanAlvarezMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Nacho.JuanAlvarez.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
