using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using InventoryControl.Product.Dto;

namespace InventoryControl.Product
{
    public interface IProductAppService : IApplicationService
    {
        Task<ListResultDto<ProductDto>> GetAll();
    }
}
