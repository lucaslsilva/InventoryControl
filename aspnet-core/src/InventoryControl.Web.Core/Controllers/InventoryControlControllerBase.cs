using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace InventoryControl.Controllers
{
    public abstract class InventoryControlControllerBase: AbpController
    {
        protected InventoryControlControllerBase()
        {
            LocalizationSourceName = InventoryControlConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
