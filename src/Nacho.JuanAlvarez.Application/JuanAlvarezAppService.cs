using Nacho.JuanAlvarez.Localization;
using Volo.Abp.Application.Services;

namespace Nacho.JuanAlvarez
{
    /* Inherit your application services from this class.
     */
    public abstract class JuanAlvarezAppService : ApplicationService
    {
        protected JuanAlvarezAppService()
        {
            LocalizationResource = typeof(JuanAlvarezResource);
        }
    }
}
