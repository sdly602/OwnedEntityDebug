using OwnedEntityDebug.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace OwnedEntityDebug.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class OwnedEntityDebugController : AbpController
    {
        protected OwnedEntityDebugController()
        {
            LocalizationResource = typeof(OwnedEntityDebugResource);
        }
    }
}