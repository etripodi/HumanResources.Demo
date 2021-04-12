using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Nacho.JuanAlvarez.EntityFrameworkCore
{
    [DependsOn(
        typeof(JuanAlvarezEntityFrameworkCoreModule)
        )]
    public class JuanAlvarezEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<JuanAlvarezMigrationsDbContext>();
        }
    }
}
