using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Nacho.JuanAlvarez.Web
{
    [Dependency(ReplaceServices = true)]
    public class JuanAlvarezBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "JuanAlvarez";
    }
}
