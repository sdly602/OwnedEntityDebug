using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using OwnedEntityDebug.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace OwnedEntityDebug.Web.Pages
{
    /* Inherit your UI Pages from this class. To do that, add this line to your Pages (.cshtml files under the Page folder):
     * @inherits OwnedEntityDebug.Web.Pages.OwnedEntityDebugPage
     */
    public abstract class OwnedEntityDebugPage : AbpPage
    {
        [RazorInject]
        public IHtmlLocalizer<OwnedEntityDebugResource> L { get; set; }
    }
}
