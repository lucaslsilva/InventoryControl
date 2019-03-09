using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using InventoryControl.Product.Dto;

namespace InventoryControl.Product
{
    public interface IProductAppService : IApplicationService
    {
        Task<ListResultDto<ProductDto>> GetAll();
        ListResultDto<ProductDto> GetAllByBrand(string brandName);
        void UpdateProduct(UpdateProductDto input);
        void CreateProduct(CreateProductDto input);
    }
}
