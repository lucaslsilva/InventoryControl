using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using InventoryControl.Store.Dto;

namespace InventoryControl.Store
{
    public interface IStoreAppService : IApplicationService
    {
        Task<ListResultDto<StoreDto>> GetAll();
    }
}
