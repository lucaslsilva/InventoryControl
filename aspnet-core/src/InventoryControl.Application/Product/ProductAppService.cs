using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using InventoryControl.Product.Dto;
using Microsoft.EntityFrameworkCore;

namespace InventoryControl.Product
{
    public class ProductAppService : AsyncCrudAppService<Product, ProductDto, int, PagedProductResultRequestDto, CreateProductDto, ProductDto>, IProductAppService
    {
        private readonly IRepository<Product> _productRepository;

        public ProductAppService(IRepository<Product> productRepository) : base(productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<ListResultDto<ProductDto>> GetAll()
        {
            var products = await _productRepository.GetAll().ToListAsync();
            return new ListResultDto<ProductDto>(ObjectMapper.Map<List<ProductDto>>(products));
        }
    }
}
