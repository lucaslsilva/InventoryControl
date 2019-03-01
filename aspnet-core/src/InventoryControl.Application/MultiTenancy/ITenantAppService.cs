using Abp.Application.Services;
using Abp.Application.Services.Dto;
using InventoryControl.MultiTenancy.Dto;

namespace InventoryControl.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

