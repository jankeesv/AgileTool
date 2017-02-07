using Abp.MultiTenancy;
using VelthovenConsultancy.AgileTool.Users;

namespace VelthovenConsultancy.AgileTool.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {
            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}