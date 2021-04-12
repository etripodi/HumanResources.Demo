using Nacho.JuanAlvarez.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Nacho.JuanAlvarez.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class JuanAlvarezPageModel : AbpPageModel
    {
        protected JuanAlvarezPageModel()
        {
            LocalizationResourceType = typeof(JuanAlvarezResource);
        }
    }
}