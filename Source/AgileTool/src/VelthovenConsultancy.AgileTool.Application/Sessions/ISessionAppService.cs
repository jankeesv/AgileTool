using System.Threading.Tasks;
using Abp.Application.Services;
using VelthovenConsultancy.AgileTool.Sessions.Dto;

namespace VelthovenConsultancy.AgileTool.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
