using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace VelthovenConsultancy.AgileTool.Web.Views
{
    public abstract class AgileToolRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected AgileToolRazorPage()
        {
            LocalizationSourceName = AgileToolConsts.LocalizationSourceName;
        }
    }
}
