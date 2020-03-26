using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace OwnedEntityDebug.Web
{
    [Dependency(ReplaceServices = true)]
    public class OwnedEntityDebugBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "OwnedEntityDebug";
    }
}
