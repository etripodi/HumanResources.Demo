using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Nacho.JuanAlvarez.Data;
using Volo.Abp.DependencyInjection;

namespace Nacho.JuanAlvarez.EntityFrameworkCore
{
    public class EntityFrameworkCoreJuanAlvarezDbSchemaMigrator
        : IJuanAlvarezDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreJuanAlvarezDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the JuanAlvarezMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<JuanAlvarezMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}