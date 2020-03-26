using OwnedEntityDebug.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace OwnedEntityDebug.Permissions
{
    public class OwnedEntityDebugPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(OwnedEntityDebugPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(OwnedEntityDebugPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<OwnedEntityDebugResource>(name);
        }
    }
}
