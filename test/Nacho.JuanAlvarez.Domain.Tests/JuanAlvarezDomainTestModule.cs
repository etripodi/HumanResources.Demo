using Nacho.JuanAlvarez.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Nacho.JuanAlvarez
{
    [DependsOn(
        typeof(JuanAlvarezEntityFrameworkCoreTestModule)
        )]
    public class JuanAlvarezDomainTestModule : AbpModule
    {

    }
}