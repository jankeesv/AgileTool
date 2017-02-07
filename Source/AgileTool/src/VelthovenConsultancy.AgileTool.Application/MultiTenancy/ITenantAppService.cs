using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using VelthovenConsultancy.AgileTool.MultiTenancy.Dto;

namespace VelthovenConsultancy.AgileTool.MultiTenancy
{
    public interface ITenantAppService : IApplicationService
    {
        ListResultDto<TenantListDto> GetTenants();

        Task CreateTenant(CreateTenantInput input);
    }
}
