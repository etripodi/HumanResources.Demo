using System.Threading.Tasks;
using Nacho.JuanAlvarez.Localization;
using Nacho.JuanAlvarez.MultiTenancy;
using Volo.Abp.TenantManagement.Web.Navigation;
using Volo.Abp.UI.Navigation;

namespace Nacho.JuanAlvarez.Web.Menus
{
    public class JuanAlvarezMenuContributor : IMenuContributor
    {
        public async Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if (context.Menu.Name == StandardMenus.Main)
            {
                await ConfigureMainMenuAsync(context);
            }
        }

        private async Task ConfigureMainMenuAsync(MenuConfigurationContext context)
        {
            if (!MultiTenancyConsts.IsEnabled)
            {
                var administration = context.Menu.GetAdministration();
                administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
            }

            var l = context.GetLocalizer<JuanAlvarezResource>();

            context.Menu.Items.Insert(0, new ApplicationMenuItem(JuanAlvarezMenus.Home, l["Menu:Home"], "~/"));

            context.Menu.AddItem(
                new ApplicationMenuItem(
                    "JuanAlvarez",
                    l["Menu:JuanAlvarez"],
                    icon: "fa fa-eye"
                ).AddItem(
                    new ApplicationMenuItem(
                        "JuanAlvarez.Empleados",
                        l["Menu:Empleados"],
                        url: "/Empleados"
                    )
                )
            );

        }
    }
}
