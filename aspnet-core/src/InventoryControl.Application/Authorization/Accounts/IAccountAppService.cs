using System.Threading.Tasks;
using Abp.Application.Services;
using InventoryControl.Authorization.Accounts.Dto;

namespace InventoryControl.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
