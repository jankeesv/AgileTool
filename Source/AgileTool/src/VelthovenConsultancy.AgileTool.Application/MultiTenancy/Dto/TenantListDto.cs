using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace VelthovenConsultancy.AgileTool.MultiTenancy.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantListDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}