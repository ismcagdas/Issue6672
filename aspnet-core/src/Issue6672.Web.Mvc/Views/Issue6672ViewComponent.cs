using Abp.AspNetCore.Mvc.ViewComponents;

namespace Issue6672.Web.Views
{
    public abstract class Issue6672ViewComponent : AbpViewComponent
    {
        protected Issue6672ViewComponent()
        {
            LocalizationSourceName = Issue6672Consts.LocalizationSourceName;
        }
    }
}
