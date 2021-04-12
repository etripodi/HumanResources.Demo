using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Nacho.JuanAlvarez.Data
{
    /* This is used if database provider does't define
     * IJuanAlvarezDbSchemaMigrator implementation.
     */
    public class NullJuanAlvarezDbSchemaMigrator : IJuanAlvarezDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}