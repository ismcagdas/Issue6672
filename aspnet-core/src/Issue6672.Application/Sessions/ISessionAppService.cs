using System.Threading.Tasks;
using Abp.Application.Services;
using Issue6672.Sessions.Dto;

namespace Issue6672.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
