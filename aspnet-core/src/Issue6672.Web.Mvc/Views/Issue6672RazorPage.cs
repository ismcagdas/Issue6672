using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace Issue6672.Web.Views
{
    public abstract class Issue6672RazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected Issue6672RazorPage()
        {
            LocalizationSourceName = Issue6672Consts.LocalizationSourceName;
        }
    }
}
