using Nacho.JuanAlvarez.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Nacho.JuanAlvarez.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class JuanAlvarezController : AbpController
    {
        protected JuanAlvarezController()
        {
            LocalizationResource = typeof(JuanAlvarezResource);
        }
    }
}