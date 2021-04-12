using Volo.Abp.Modularity;

namespace Nacho.JuanAlvarez
{
    [DependsOn(
        typeof(JuanAlvarezApplicationModule),
        typeof(JuanAlvarezDomainTestModule)
        )]
    public class JuanAlvarezApplicationTestModule : AbpModule
    {

    }
}