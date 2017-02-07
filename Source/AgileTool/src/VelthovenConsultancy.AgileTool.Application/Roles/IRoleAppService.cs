using System.Threading.Tasks;
using Abp.Application.Services;
using VelthovenConsultancy.AgileTool.Roles.Dto;

namespace VelthovenConsultancy.AgileTool.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
