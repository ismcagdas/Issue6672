using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Issue6672.Controllers
{
    public abstract class Issue6672ControllerBase: AbpController
    {
        protected Issue6672ControllerBase()
        {
            LocalizationSourceName = Issue6672Consts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
