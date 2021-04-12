using System.Threading.Tasks;

namespace Nacho.JuanAlvarez.Data
{
    public interface IJuanAlvarezDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
