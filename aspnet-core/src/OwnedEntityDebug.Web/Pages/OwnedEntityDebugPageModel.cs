﻿using OwnedEntityDebug.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace OwnedEntityDebug.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class OwnedEntityDebugPageModel : AbpPageModel
    {
        protected OwnedEntityDebugPageModel()
        {
            LocalizationResourceType = typeof(OwnedEntityDebugResource);
        }
    }
}