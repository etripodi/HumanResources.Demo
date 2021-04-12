using Nacho.JuanAlvarez.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Nacho.JuanAlvarez.Permissions
{
    public class JuanAlvarezPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(JuanAlvarezPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(JuanAlvarezPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<JuanAlvarezResource>(name);
        }
    }
}
