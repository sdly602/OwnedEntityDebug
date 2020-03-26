using System;
using System.Collections.Generic;
using System.Text;
using OwnedEntityDebug.Localization;
using Volo.Abp.Application.Services;

namespace OwnedEntityDebug
{
    /* Inherit your application services from this class.
     */
    public abstract class OwnedEntityDebugAppService : ApplicationService
    {
        protected OwnedEntityDebugAppService()
        {
            LocalizationResource = typeof(OwnedEntityDebugResource);
        }
    }
}
