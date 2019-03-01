using System.Threading.Tasks;
using Abp.Application.Services;
using InventoryControl.Sessions.Dto;

namespace InventoryControl.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
