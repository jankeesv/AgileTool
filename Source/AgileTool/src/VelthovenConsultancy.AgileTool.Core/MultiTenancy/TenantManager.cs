using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using VelthovenConsultancy.AgileTool.Editions;
using VelthovenConsultancy.AgileTool.Users;

namespace VelthovenConsultancy.AgileTool.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager,
            IAbpZeroFeatureValueStore featureValueStore
            ) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager,
                featureValueStore
            )
        {
        }
    }
}