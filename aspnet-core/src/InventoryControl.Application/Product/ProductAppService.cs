using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Abp.Logging;
using InventoryControl.Product.Dto;
using Microsoft.EntityFrameworkCore;

namespace InventoryControl.Product
{
    public class ProductAppService : ApplicationService, IProductAppService
    {
        private readonly IProductRepository _productRepository;

        public ProductAppService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<ListResultDto<ProductDto>> GetAll()
        {
            var products = await _productRepository.GetAll().ToListAsync();
            return new ListResultDto<ProductDto>(ObjectMapper.Map<List<ProductDto>>(products));
        }

        public ListResultDto<ProductDto> GetAllByBrand(string brandName)
        {
            var products = _productRepository.GetAllByBrand(brandName).ToList();
            return new ListResultDto<ProductDto>(ObjectMapper.Map<List<ProductDto>>(products));
        }

        public void UpdateProduct(UpdateProductDto input)
        {
            Logger.Info("Updating a product for input: " + input);

            var product = _productRepository.Get(input.Id);

            if (!string.IsNullOrEmpty(input.Description))
            {
                product.Description = input.Description;
            }

            if (!string.IsNullOrEmpty(input.Brand))
            {
                product.Brand = input.Brand;
            }

            if (input.Price.HasValue)
            {
                product.Price = input.Price.Value;
            }

            if (input.Picture.Any())
            {
                product.Picture = input.Picture;
            }
        }

        public void CreateProduct(CreateProductDto input)
        {
            Logger.Info("Creating a product for input: " + input);

            var product = new Product
            {
                Code = input.Code,
                Description = input.Description,
                Brand = input.Brand,
                Price = input.Price,
                Picture = input.Picture
            };

            _productRepository.Insert(product);
        }
    }
}
